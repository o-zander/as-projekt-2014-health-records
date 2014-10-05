﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class Fachkonzept : IFachkonzept
    {
        private IDatenhaltung datenhaltung;  

        public Fachkonzept(IDatenhaltung datenhaltung)
        {
            this.datenhaltung = datenhaltung;            
        }

        public Patient[] GetPatients(int setSize, long lastID)
        {
            return datenhaltung.GetPatientsData(setSize, lastID);            
        }

        public Illness[] GetIllnesses(int setSize, long lastID)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatient(long patientID)
        {
            return datenhaltung.GetPatientData(patientID);            
        }

        public Illness GetIllness(long illnessID)
        {
            throw new NotImplementedException();
        }

        public long CreatePatient(Patient patient)
        {
            return datenhaltung.CreatePatientData(patient);            
        }

        public long CreateIllness(Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePatient(Patient patient)
        {
            return datenhaltung.UpdatePatientData(patient);
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
            return datenhaltung.DeletePatientData(patient);
        }

        public bool DeleteIllness(Illness illness)
        {
            throw new NotImplementedException();
        }
    }
}
