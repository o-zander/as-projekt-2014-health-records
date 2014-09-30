using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class DatenhaltungDB
    {
        public Patient[] GetPatientsData(int pager)
        {
            Patient[] patients = new Patient[pager];
            return patients;
        }

        public Illness[] GetIllnessesData(int pager)
        {
            Illness[] illnesses = new Illness[pager];
            return illnesses;
        }

        public Patient GetPatientData()
        {
            Patient patient = new Patient();
            return patient;
        }

        public Illness GetIllnessData()
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
