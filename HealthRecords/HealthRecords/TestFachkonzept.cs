using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class TestFachkonzept : IFachkonzept
    {
        private SQLiteDatenhaltung sQLiteDatenhaltung;

        public TestFachkonzept(SQLiteDatenhaltung sQLiteDatenhaltung)
        {
            // TODO: Complete member initialization
            this.sQLiteDatenhaltung = sQLiteDatenhaltung;
        }

        public Patient[] GetPatients()
        {
            return this.GetPatients(0, 20);
        }

        public Patient[] GetPatients(int pager, int number)
        {
            Patient[] patients = new Patient[5];
            for (int i = 0; i < patients.Length; i++)
            {
                int id = i + pager * 5;
                patients[i] = GetPatient(id);
            }
            return patients;
        }

        public Illness[] GetIllnesses()
        {
            return this.GetIllnesses(0, 20);
        }

        public Illness[] GetIllnesses(int pager, int number)
        {
            Illness[] illnesses = new Illness[5];
            for (int i = 0; i < illnesses.Length; i++)
            {
                int id = i + pager * 5;
                illnesses[i] = GetIllness(id);
            }
            return illnesses;
        }

        public bool CreatePatient(Patient patient)
        {
            if (patient.FirstName == "error")
            {
                return false;
            }
            patient.PatientID = 99;
            return true;
        }

        public bool CreateIllness(Illness illness)
        {
            if (illness.Name == "error")
            {
                return false;
            }
            illness.IllnessID = 99;
            return true;
        }

        public bool UpdatePatient(Patient patient)
        {
            if (patient.FirstName == "error")
            {
                return false;
            }
            return true;
        }

        public bool UpdateIllness(Illness illness)
        {
            if (illness.Name == "error")
            {
                return false;
            }
            return true;
        }

        public bool LinkPatientIllness(Patient patient, Illness illness)
        {
            if (patient.PatientID == 80 || illness.IllnessID == 80)
            {
                return false;
            }
            return true;
        }

        public bool DeletePatient(Patient patient)
        {
            if (patient.PatientID == 40)
            {
                return false;
            }
            return true;
        }

        public bool DeleteIllness(Illness illness)
        {
            if (illness.IllnessID == 40)
            {
                return false;
            }
            return true;
        }

        public Patient GetPatient(long patientID)
        {
            if (patientID == 55)
            {
                return null;
            }
            Patient patient = new Patient("first " + patientID, "last " + patientID, DateTime.Now.AddYears(-2));
            patient.PatientID = patientID;
            return patient;
        }

        public Illness GetIllness(long illnessID)
        {
            if (illnessID == 55)
            {
                return null;
            }
            Illness illness = new Illness("name " + illnessID, (illnessID / 3 + 8) % 2 == 0, (illnessID / 8 + 3) % 3 == 0, (illnessID / 3 - 9) % 5 == 0);
            illness.IllnessID = illnessID;
            return illness;
        }

        public bool UnLinkPatientIllness(Patient patient, Illness illness)
        {
            if (patient.PatientID == 80 || illness.IllnessID == 80)
            {
                return false;
            }
            return true;
        }

        public Illness[] GetPatientIllnesses(Patient patient)
        {
            return this.GetIllnesses();
        }

        public Patient[] GetIllnessPatients(Illness illness)
        {
            return this.GetPatients();
        }

        public Illness[] GetPatientIllnesses(Patient patient, int pager, int number)
        {
            return this.GetIllnesses((int)patient.PatientID + pager, number);
        }

        public Patient[] GetIllnessPatients(Illness illness, int pager, int number)
        {
            return this.GetPatients((int)illness.IllnessID + pager, number);
        }

        public int GetPatientsCount()
        {
            return 20;
        }

        public int GetIllnessesCount()
        {
            return 25;
        }

        public int GetPatientIllnessesCount(Patient patient)
        {
            return 6;
        }

        public int GetIllnessPatientsCount(Illness illness)
        {
            return 11;
        }

    }
}
