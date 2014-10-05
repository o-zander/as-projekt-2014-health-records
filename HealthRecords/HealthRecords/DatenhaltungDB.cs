using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class DatenhaltungDB:IDatenhaltung
    {
        public Patient[] GetPatientsData(int setSize, long lastID)
        {
            Patient[] patients = new Patient[setSize];
            return patients;
        }

        public Illness[] GetIllnessesData(int setSize, long lastID)
        {
            Illness[] illnesses = new Illness[setSize];
            return illnesses;
        }

        public Patient GetPatientData(long patientID)
        {
            Patient patient = new Patient();
            return patient;
        }

        public Illness GetIllnessData(long illnessID)
        {
            Illness illness = new Illness();
            return illness;
        }

        public long CreatePatientData(Patient patient)
        {
            throw new NotImplementedException();            
        }

        public long CreateIllnessData(Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePatientData(Patient patient)
        {
            return true;
        }

        public bool UpdateIllnessData(Illness illness)
        {
            return true;
        }

        public bool LinkPatientIllnessData(Patient patient, Illness illness)
        {
            return true;
        }

        public bool UnLinkPatientIllness(Patient patient, Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool DeletePatientData(Patient patient)
        {
            return true;
        }

        public bool DeleteIllnessData(Illness illness)
        {
            return true;
        }

        public Illness[] GetPatientIllnessesData(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Patient[] GetIllnessPatientsData(Illness illness)
        {
            throw new NotImplementedException();
        }
    }
}
