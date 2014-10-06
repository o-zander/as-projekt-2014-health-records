using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TestFachkonzept : IFachkonzept
    {

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

        public Patient GetPatient(int id)
        {
            if (id == 55)
            {
                return null;
            }
            Patient patient = new Patient("first " + id, "last " + id, DateTime.Now.AddYears(-2));
            patient.PatientID = id;
            return patient;
        }

        public Illness GetIllness(int id)
        {
            if (id == 55)
            {
                return null;
            }
            Illness illness = new Illness("name " + id, (id / 3 + 8) % 2 == 0, (id / 8 + 3) % 3 == 0, (id / 3 - 9) % 5 == 0);
            illness.IllnessID = id;
            return illness;
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

        public bool DelinkPatientIllness(Patient patient, Illness illness)
        {
            return true;
        }

        public Illness[] GetIllnessesToPatient(Patient patient, int pager, int number)
        {
            return this.GetIllnesses(patient.PatientID + pager, number);
        }

        public Patient[] GetPatientsToIllness(Illness illness, int pager, int number)
        {
            return this.GetPatients(illness.IllnessID + pager, number);
        }

    }
}
