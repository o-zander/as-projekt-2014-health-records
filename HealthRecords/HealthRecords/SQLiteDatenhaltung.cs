using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace HealthRecords
{

    class SQLiteDatenhaltung : IDatenhaltung
    {

        private string Database { get; set; }
        private SQLiteConnection Connection { get; set; }
        private ExceptionMessage LastError { get; set; }

        private string[] Tables = {
            @"T_Patients (
	            patientID INTEGER PRIMARY KEY AUTOINCREMENT,
	            firstName VARCHAR(100) NOT NULL,
	            lastName VARCHAR(100) NOT NULL,
	            birthday DATE NOT NULL
            )",
            @"T_Illnesses (
	            illnessID INTEGER PRIMARY KEY AUTOINCREMENT,
	            name VARCHAR(100) NOT NULL,
	            contagious BOOLEAN NOT NULL,
	            lethal BOOLEAN NOT NULL,
	            curable BOOLEAN NOT NULL
            )",
            @"T_PatientsIllnesses (
	            patientID INTEGER NOT NULL,
	            illnessID INTEGER NOT NULL,
                PRIMARY KEY(patientID, illnessID)
            )"
        };

        private void Connect()
        {
            SQLiteConnectionStringBuilder connectionStringBuilder = new SQLiteConnectionStringBuilder();
            connectionStringBuilder.DataSource = this.Database;
            this.Connection = new SQLiteConnection(connectionStringBuilder.ConnectionString);
            this.Connection.Open();
        }

        private void InitDatabase()
        {
            foreach (string table in this.Tables)
            {
                this.ExecuteNonQuery(
                    new SQLiteCommand(
                        String.Format("CREATE TABLE IF NOT EXISTS {0}", table),
                        this.Connection)
                );
            }
        }

        public SQLiteDatenhaltung()
        {
            this.Database = "health-records.db";
            this.Connect();
            this.InitDatabase();
        }

        public SQLiteDatenhaltung(string database)
        {
            this.Database = database;
            this.Connect();
            this.InitDatabase();
        }

        private int ParseScalarToInt(object result)
        {
            return Int32.Parse(result.ToString());
        }

        private long ParseScalarToLong(object result)
        {
            return Int64.Parse(result.ToString());
        }

        private int ExecuteNonQuery(SQLiteCommand command) {
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                this.LastError = new ExceptionMessage(1, e);
                return 0;
            }
        }

        private SQLiteDataReader ExecuteReader(SQLiteCommand command)
        {
            try
            {
                return command.ExecuteReader();
            }
            catch (SQLiteException e)
            {
                this.LastError = new ExceptionMessage(1, e);
                return null;
            }
        }

        private object ExecuteScalar(SQLiteCommand command)
        {
            try
            {
                return command.ExecuteScalar();
            }
            catch (SQLiteException e)
            {
                this.LastError = new ExceptionMessage(1, e);
                return null;
            }
        }

        private SQLiteDataReader Select(string table)
        {
            return this.ExecuteReader(
                new SQLiteCommand(
                    String.Format("SELECT * FROM {0}", table),
                    this.Connection
                )
            );
        }

        private SQLiteDataReader Select(string table, string where)
        {
            return this.ExecuteReader(
                new SQLiteCommand(
                    String.Format("SELECT * FROM {0} WHERE {1}", table, where),
                    this.Connection
                )
            );
        }

        private SQLiteDataReader Select(string table, string[] fields, string where)
        {
            return this.ExecuteReader(
                new SQLiteCommand(
                    String.Format("SELECT {0} FROM {1} WHERE {2}", String.Join(",", fields), table, where),
                    this.Connection
                )
            );
        }

        private SQLiteDataReader Select(string table, string[] fields, string where, string limit)
        {
            return this.ExecuteReader(
                new SQLiteCommand(
                    String.Format("SELECT {0} FROM {1} WHERE {2} LIMIT {3}", String.Join(",", fields), table, where, limit),
                    this.Connection
                )
            );
        }

        private SQLiteDataReader Select(string table, string[] fields, string innerJoin, string joinOn, string where)
        {
            return this.ExecuteReader(
                new SQLiteCommand(
                    String.Format("SELECT {0} FROM {1} INNER JOIN {2} ON {3} WHERE {4}", String.Join(",", fields), table, innerJoin, joinOn, where),
                    this.Connection
                )
            );
        }

        private SQLiteDataReader Select(string table, string[] fields, string innerJoin, string joinOn, string where, string limit)
        {
            return this.ExecuteReader(
                new SQLiteCommand(
                    String.Format("SELECT {0} FROM {1} INNER JOIN {2} ON {3} WHERE {4} LIMIT {5}", String.Join(",", fields), table, innerJoin, joinOn, where, limit),
                    this.Connection
                )
            );
        }

        private long GetLastInsertRowID()
        {
            return this.ParseScalarToLong(
                this.ExecuteScalar(
                    new SQLiteCommand(
                        "SELECT last_insert_rowid()",
                        this.Connection
                    )
                )
            );
        }

        private Patient GetPatientFromReader(SQLiteDataReader reader)
        {
            return new Patient(
                (long) reader["patientID"],
                (string) reader["firstName"],
                (string) reader["lastName"],
                (DateTime) reader["birthday"]
            );
        }

        private Illness GetIllnessFromReader(SQLiteDataReader reader)
        {
            return new Illness(
                (long) reader["illnessID"],
                (string) reader["name"],
                (bool) reader["contagious"],
                (bool) reader["lethal"],
                (bool) reader["curable"]
            );
        }

        public Patient[] GetPatientsData()
        {
            using (SQLiteDataReader reader = this.Select("T_Patients"))
            {
                List<Patient> patients = new List<Patient>();
                while (reader != null && reader.Read())
                {
                    patients.Add(this.GetPatientFromReader(reader));
                }
                return patients.ToArray();
            }
        }

        public Illness[] GetIllnessesData()
        {
            using (SQLiteDataReader reader = this.Select("T_Illnesses"))
            {
                List<Illness> illnesses = new List<Illness>();
                while (reader != null && reader.Read())
                {
                    illnesses.Add(this.GetIllnessFromReader(reader));
                }
                return illnesses.ToArray();
            }
        }

        public Patient[] GetPatientsData(int page, int pageSize)
        {
            using (SQLiteDataReader reader = this.Select("T_Patients", new string[1] { "*" }, "1", String.Format("{0}, {1}", page * pageSize, pageSize)))
            {
                List<Patient> patients = new List<Patient>();
                while (reader != null && reader.Read())
                {
                    patients.Add(this.GetPatientFromReader(reader));
                }
                return patients.ToArray();
            }
        }

        public Illness[] GetIllnessesData(int page, int pageSize)
        {
            using (SQLiteDataReader reader = this.Select("T_Illnesses", new string[1] { "*" }, "1", String.Format("{0}, {1}", page * pageSize, pageSize)))
            {
                List<Illness> illnesses = new List<Illness>();
                while (reader != null && reader.Read())
                {
                    illnesses.Add(this.GetIllnessFromReader(reader));
                }
                return illnesses.ToArray();
            }
        }

        public Patient GetPatientData(long patientID)
        {
            using (SQLiteDataReader reader = this.Select("T_Patients", String.Format("patientID = {0}", patientID)))
            {
                return reader != null && reader.Read() ? this.GetPatientFromReader(reader) : null;
            }
        }

        public Illness GetIllnessData(long illnessID)
        {
            using (SQLiteDataReader reader = this.Select("T_Illnesses", String.Format("illnessID = {0}", illnessID)))
            {
                return reader != null && reader.Read() ? this.GetIllnessFromReader(reader) : null;
            }
        }

        public bool CreatePatientData(Patient patient)
        {
            if (patient.PatientID == 0)
            {
                SQLiteCommand command = new SQLiteCommand(
                    @"INSERT INTO T_Patients (firstName, lastName, birthday)
                      VALUES (@firstName, @lastName, @birthday)",
                    this.Connection
                );
                command.Parameters.Add("@firstName", DbType.String).Value = patient.FirstName;
                command.Parameters.Add("@lastName", DbType.String).Value = patient.LastName;
                command.Parameters.Add("@birthday", DbType.DateTime).Value = patient.Birthday;
                return this.ExecuteNonQuery(command) == 1 ? (patient.PatientID = this.GetLastInsertRowID()) > 0 : false;
            }
            else
            {
                return false;
            }
        }

        public bool CreateIllnessData(Illness illness)
        {
            if (illness.IllnessID == 0)
            {
                SQLiteCommand command = new SQLiteCommand(
                    @"INSERT INTO T_Illnesses (name, contagious, lethal, curable)
                      VALUES (@name, @contagious, @lethal, @curable)",
                    this.Connection
                );
                command.Parameters.Add("@name", DbType.String).Value = illness.Name;
                command.Parameters.Add("@contagious", DbType.Boolean).Value = illness.Contagious;
                command.Parameters.Add("@lethal", DbType.Boolean).Value = illness.Lethal;
                command.Parameters.Add("@curable", DbType.Boolean).Value = illness.Curable;
                return this.ExecuteNonQuery(command) == 1 ? (illness.IllnessID = this.GetLastInsertRowID()) > 0 : false;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePatientData(Patient patient)
        {
            if (patient.PatientID > 0)
            {
                SQLiteCommand command = new SQLiteCommand(
                    @"UPDATE T_Patients
                      SET firstName = @firstName, lastName = @lastName, birthday = @birthday
                      WHERE patientID = @patientID",
                    this.Connection
                );
                command.Parameters.Add("@firstName", DbType.String).Value = patient.FirstName;
                command.Parameters.Add("@lastName", DbType.String).Value = patient.LastName;
                command.Parameters.Add("@birthday", DbType.DateTime).Value = patient.Birthday;
                command.Parameters.Add("@patientID", DbType.Int64).Value = patient.PatientID;
                return this.ExecuteNonQuery(command) == 1;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateIllnessData(Illness illness)
        {
            if (illness.IllnessID > 0)
            {
                SQLiteCommand command = new SQLiteCommand(
                    @"UPDATE T_Illnesses
                      SET name = @name, contagious = @contagious, lethal = @lethal, curable = @curable
                      WHERE illnessID = @illnessID",
                    this.Connection
                );
                command.Parameters.Add("@name", DbType.String).Value = illness.Name;
                command.Parameters.Add("@contagious", DbType.Boolean).Value = illness.Contagious;
                command.Parameters.Add("@lethal", DbType.Boolean).Value = illness.Lethal;
                command.Parameters.Add("@curable", DbType.Boolean).Value = illness.Curable;
                command.Parameters.Add("@illnessID", DbType.Int64).Value = illness.IllnessID;
                return this.ExecuteNonQuery(command) == 1;
            }
            else
            {
                return false;
            }
        }

        public bool LinkPatientIllnessData(Patient patient, Illness illness)
        {
            if (patient.PatientID > 0 && illness.IllnessID > 0)
            {
                SQLiteCommand exists = new SQLiteCommand(
                    @"SELECT COUNT(*) FROM T_PatientsIllnesses
                    WHERE (patientID = @patientID) AND (illnessID = @illnessID)",
                    this.Connection
                );
                exists.Parameters.Add("@patientID", DbType.Int64).Value = patient.PatientID;
                exists.Parameters.Add("@illnessID", DbType.Int64).Value = illness.IllnessID;
                if (Int32.Parse(exists.ExecuteScalar().ToString()) > 0)
                    return false;
                SQLiteCommand command = new SQLiteCommand(
                    @"INSERT INTO T_PatientsIllnesses (patientID, illnessID)
                      VALUES (@patientID, @illnessID)",
                    this.Connection
                );
                command.Parameters.Add("@patientID", DbType.Int64).Value = patient.PatientID;
                command.Parameters.Add("@illnessID", DbType.Int64).Value = illness.IllnessID;
                return this.ExecuteNonQuery(command) == 1;
            }
            else
            {
                return false;
            }
        }

        public bool UnLinkPatientIllness(Patient patient, Illness illness)
        {
            if (patient.PatientID > 0 && illness.IllnessID > 0)
            {
                SQLiteCommand command = new SQLiteCommand(
                    @"DELETE FROM T_PatientsIllnesses
                      WHERE (patientID = @patientID) AND (illnessID = @illnessID)",
                    this.Connection
                );
                command.Parameters.Add("@patientID", DbType.Int64).Value = patient.PatientID;
                command.Parameters.Add("@illnessID", DbType.Int64).Value = illness.IllnessID;
                return this.ExecuteNonQuery(command) == 1;
            }
            else
            {
                return false;
            }
        }

        public bool DeletePatientData(Patient patient)
        {
            if (patient.PatientID > 0)
            {
                SQLiteCommand command = new SQLiteCommand(
                    "DELETE FROM T_Patients WHERE patientID = @patientID",
                    this.Connection
                );
                command.Parameters.Add("@patientID", DbType.Int64).Value = patient.PatientID;
                return this.ExecuteNonQuery(command) == 1 ? (patient.PatientID = 0) == 0 : false;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteIllnessData(Illness illness)
        {
            if (illness.IllnessID > 0)
            {
                SQLiteCommand command = new SQLiteCommand(
                    "DELETE FROM T_Illnesses WHERE illnessID = @illnessID",
                    this.Connection
                );
                command.Parameters.Add("@illnessID", DbType.Int64).Value = illness.IllnessID;
                return this.ExecuteNonQuery(command) == 1 ? (illness.IllnessID = 0) == 0 : false;
            }
            else
            {
                return false;
            }
        }

        public Illness[] GetPatientIllnessesData(Patient patient)
        {
            if (patient.PatientID > 0)
            {
                using (SQLiteDataReader reader = this.Select("T_PatientsIllnesses AS pi",
                                                             new String[5] { "i.illnessID", "i.name", "i.contagious", "i.lethal", "i.curable" },
                                                             "T_Illnesses AS i",
                                                             "pi.illnessID = i.illnessID",
                                                             String.Format("pi.patientID = {0}", patient.PatientID)
                                                             )
                      )
                {
                    List<Illness> illnesses = new List<Illness>();
                    while (reader != null && reader.Read())
                    {
                        illnesses.Add(this.GetIllnessFromReader(reader));
                    }
                    return illnesses.ToArray();
                }
            }
            else
            {
                return new Illness[0];
            }

        }

        public Patient[] GetIllnessPatientsData(Illness illness)
        {
            if (illness.IllnessID > 0)
            {
                using (SQLiteDataReader reader = this.Select("T_PatientsIllnesses AS pi",
                                                             new String[4] { "p.patientID", "p.firstName", "p.lastName", "p.birthday" },
                                                             "T_Patients AS p",
                                                             "pi.patientID = p.patientID",
                                                             String.Format("pi.illnessID = {0}", illness.IllnessID)
                                                             )
                      )
                {
                    List<Patient> patients = new List<Patient>();
                    while (reader != null && reader.Read())
                    {
                        patients.Add(this.GetPatientFromReader(reader));
                    }
                    return patients.ToArray();
                }
            }
            else
            {
                return new Patient[0];
            }
        }
        
        public Illness[] GetPatientIllnessesData(Patient patient, int page, int pageSize)
        {
            if (patient.PatientID > 0)
            {
                using (SQLiteDataReader reader = this.Select("T_PatientsIllnesses AS pi",
                                                             new String[5] { "i.illnessID", "i.name", "i.contagious", "i.lethal", "i.curable" },
                                                             "T_Illnesses AS i", "pi.illnessID = i.illnessID",
                                                             String.Format("pi.patientID = {0}", patient.PatientID),
                                                             String.Format("{0}, {1}", page * pageSize, pageSize)
                                                             )
                      )
                {
                    List<Illness> illnesses = new List<Illness>();
                    while (reader != null && reader.Read())
                    {
                        illnesses.Add(this.GetIllnessFromReader(reader));
                    }
                    return illnesses.ToArray();
                }
            }
            else
            {
                return new Illness[0];
            }

        }

        public Patient[] GetIllnessPatientsData(Illness illness,int page, int pageSize)
        {
            if (illness.IllnessID > 0)
            {
                using (SQLiteDataReader reader = this.Select("T_PatientsIllnesses AS pi",
                                                             new String[4] { "p.patientID", "p.firstName", "p.lastName", "p.birthday" },
                                                             "T_Patients AS p", "pi.patientID = p.patientID",
                                                             String.Format("pi.illnessID = {0}", illness.IllnessID),
                                                             String.Format("{0}, {1}", page * pageSize, pageSize) 
                                                             )
                      )
                {
                    List<Patient> patients = new List<Patient>();
                    while (reader != null && reader.Read())
                    {
                        patients.Add(this.GetPatientFromReader(reader));
                    }
                    return patients.ToArray();
                }
            }
            else
            {
                return new Patient[0];
            }
        }


        public int GetPatientsCountData()
        {
            return Int32.Parse(new SQLiteCommand("SELECT COUNT(*) FROM T_Patients", this.Connection).ExecuteScalar().ToString());
        }

        public int GetIllnessesCountData()
        {
            return Int32.Parse(new SQLiteCommand("SELECT COUNT(*) FROM T_Illnesses", this.Connection).ExecuteScalar().ToString());
        }

        public int GetPatientIllnessesCountData(Patient patient)
        {
            if (patient.PatientID > 0)
            {
                SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM T_PatientsIllnesses WHERE patientID = @patientID", this.Connection);
                command.Parameters.Add("@patientID", DbType.Int64).Value = patient.PatientID;
                return this.ParseScalarToInt(command.ExecuteScalar());
            }
            else
            {
                return 0;
            }            
        }

        public int GetIllnessPatientsCountData(Illness illness)
        {
            if (illness.IllnessID > 0)
            {
                SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM T_PatientsIllnesses WHERE illnessID = @illnessID", this.Connection);
                command.Parameters.Add("@illnessID", DbType.Int64).Value = illness.IllnessID;
                return Int32.Parse(command.ExecuteScalar().ToString());
            }
            else
            {
                return 0;
            }  
        }

        public ExceptionMessage GetLastErrorData()
        {
            return this.LastError;
        }

    }

}
