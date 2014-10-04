using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class Fachkonzept : IFachkonzept
    {
        private IDatenhaltung datenhaltung; 

        public Fachkonzept(DatenhaltungDB datenhaltungDB)
        {
            this.datenhaltung = datenhaltungDB;
        }

        public Fachkonzept(DatenhaltungXML datenhaltungXML)
        {
            this.datenhaltung = datenhaltungXML;            
        }

        public Patient[] GetPatients(int setSize, int lastID)
        {
            return datenhaltung.GetPatientsData(setSize, lastID);            
        }

        public Illness[] GetIllnesses(int setSize, int lastID)
        {
            Illness[] illnesses = new Illness[setSize];
            return illnesses;
        }

        public Patient GetPatient(int patientID)
        {
            return datenhaltung.GetPatientData(patientID);            
        }

        public Illness GetIllness(int illnessID)
        {
            Illness illness = new Illness();
            return illness;
        }

        public Boolean CreatePatient(Patient patient)
        {
            return datenhaltung.CreatePatientData(patient);            
        }

        public Boolean CreateIllness(Illness illness)
        {
            return true;
        }

        public Boolean UpdatePatient(Patient patient)
        {
            return datenhaltung.UpdatePatientData(patient);
        }

        public Boolean UpdateIllness(Illness illness)
        {
            return true;
        }

        public Boolean LinkPatientIllness(Patient patient, Illness illness)
        {
            return true;
        }

        public Boolean DeletePatient(Patient patient)
        {
            return true;
        }

        public Boolean DeleteIllness(Illness illness)
        {
            return true;
        }
    }
}
