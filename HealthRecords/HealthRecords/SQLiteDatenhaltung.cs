﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace HealthRecords
{
    class SQLiteDatenhaltung : IDatenhaltung
    {
        string Database { get; set; }
        SQLiteConnection Connection { get; set; }

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
	            illnessID INTEGER NOT NULL
            )"
        };

        private int ItemsPerPage = 10;

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
                new SQLiteCommand(
                    String.Format("CREATE TABLE IF NOT EXISTS {0}", table),
                    this.Connection
                ).ExecuteNonQuery();
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

        private SQLiteDataReader Select(string table, int page)
        {
            return new SQLiteCommand(
                String.Format("SELECT * FROM {0} LIMIT {1}, {2}", table, this.ItemsPerPage * page, this.ItemsPerPage),
                this.Connection
            ).ExecuteReader();
        }

        private long GetLastInsertRowID()
        {
            return (long) new SQLiteCommand("SELECT last_insert_rowid()", this.Connection).ExecuteScalar();
        }

        public Patient[] GetPatientsData(int pager)
        {
            using (SQLiteDataReader reader = this.Select("T_Patients", pager)) 
            {
                List<Patient> patients = new List<Patient>();
                while (reader.Read()) {
                    patients.Add(new Patient(
                        (long) reader["patientID"],
                        (string) reader["firstName"],
                        (string) reader["lastName"],
                        (DateTime) reader["birthday"])
                    );
                }
                return patients.ToArray();
            }
        }

        public Illness[] GetIllnessesData(int pager)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatientData()
        {
            throw new NotImplementedException();
        }

        public Illness GetIllnessData()
        {
            throw new NotImplementedException();
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
                command.Parameters.Add("@lastName", DbType.String).Value = patient.FirstName;
                command.Parameters.Add("@birthday", DbType.DateTime).Value = patient.Birthday;
                if (command.ExecuteNonQuery() == 1)
                {
                    patient.PatientID = this.GetLastInsertRowID();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return this.UpdatePatientData(patient);
            }
        }

        public bool CreateIllnessData(Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePatientData(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIllnessData(Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool LinkPatientIllnessData(Patient patient, Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool DeletePatientData(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIllnessData(Illness illness)
        {
            throw new NotImplementedException();
        }
    }
}
