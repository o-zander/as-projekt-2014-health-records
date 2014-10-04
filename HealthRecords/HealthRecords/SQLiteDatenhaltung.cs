using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace HealthRecords
{
  class SQLiteDatenhaltung : IFachkonzept
  {
    string Database { get; set; }
    SQLiteConnection Connection { get; set; }

    private void Connect()
    {
      SQLiteConnectionStringBuilder connectionStringBuilder = new SQLiteConnectionStringBuilder();
      connectionStringBuilder.DataSource = this.Database;
      this.Connection = new SQLiteConnection(connectionStringBuilder.ConnectionString);
      this.Connection.Open();
    }

    private void InitDatabase()
    {
      SQLiteCommand createTable = new SQLiteCommand("CREATE TABLE ?", this.Connection);
      createTable.Parameters.Add("T_Patients");
      createTable.ExecuteNonQuery();
    }

    public SQLiteDatenhaltung()
    {
      this.Database = "health-records.db";
      this.Connect();
    }

    public SQLiteDatenhaltung(string database)
    {
      this.Database = database;
      this.Connect();
    }

    public Patient[] GetPatients(int setSize, int lastID)
    {
      throw new NotImplementedException();
    }

    public Illness[] GetIllnesses(int setSize, int lastID)
    {
      throw new NotImplementedException();
    }

    public Patient GetPatient(int patientID)
    {
      throw new NotImplementedException();
    }

    public Illness GetIllness(int illnessID)
    {
      throw new NotImplementedException();
    }

    public bool CreatePatient(Patient patient)
    {
      throw new NotImplementedException();
    }

    public bool CreateIllness(Illness illness)
    {
      throw new NotImplementedException();
    }

    public bool UpdatePatient(Patient patient)
    {
      throw new NotImplementedException();
    }

    public bool UpdateIllness(Illness illness)
    {
      throw new NotImplementedException();
    }

    public bool LinkPatientIllness(Patient patient, Illness illness)
    {
      throw new NotImplementedException();
    }

    public bool DeletePatient(Patient patient)
    {
      throw new NotImplementedException();
    }

    public bool DeleteIllness(Illness illness)
    {
      throw new NotImplementedException();
    }
  }
}
