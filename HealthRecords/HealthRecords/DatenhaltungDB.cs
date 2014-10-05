using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class DatenhaltungDB:IDatenhaltung
    {
        public Patient[] GetPatientsData(int setSize, int lastID)
        {
            Patient[] patients = new Patient[setSize];
            return patients;
        }

        public Illness[] GetIllnessesData(int setSize, int lastID)
        {
            Illness[] illnesses = new Illness[setSize];
            return illnesses;
        }

        public Patient GetPatientData(int patientID)
        {
            Patient patient = new Patient();
            return patient;
        }

        public Illness GetIllnessData(int illnessID)
        {
            Illness illness = new Illness();
            return illness;
        }

        public int CreatePatientData(Patient patient)
        {
            throw new NotImplementedException();            
        }

        public int CreateIllnessData(Illness illness)
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

        public bool DeletePatientData(Patient patient)
        {
            return true;
        }

        public bool DeleteIllnessData(Illness illness)
        {
            return true;
        }
    }
}
