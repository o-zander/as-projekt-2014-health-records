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

        public Boolean CreatePatientData(Patient patient)
        {
            return true;
        }

        public Boolean CreateIllnessData(Illness illness)
        {
            return true;
        }

        public Boolean UpdatePatientData(Patient patient)
        {
            return true;
        }

        public Boolean UpdateIllnessData(Illness illness)
        {
            return true;
        }

        public Boolean LinkPatientIllnessData(Patient patient, Illness illness)
        {
            return true;
        }

        public Boolean DeletePatientData(Patient patient)
        {
            return true;
        }

        public Boolean DeleteIllnessData(Illness illness)
        {
            return true;
        }
    }
}
