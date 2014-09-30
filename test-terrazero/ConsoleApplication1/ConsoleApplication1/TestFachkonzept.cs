using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TestFachkonzept : IFachkonzept
    {

        public Patient[] GetPatients(int pager)
        {
            Patient[] patients = new Patient[5];
            for (int i = 0; i < patients.Length; i++)
            {
                int id = i + pager * 5;
                patients[i] = GetPatient(id);
            }
            return patients;
        }

        public Illness[] GetIllnesses(int pager)
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
            Patient patient = new Patient("first " + id, "last " + id, DateTime.Now.AddYears(-2));
            patient.PatientID = id;
            return patient;
        }

        public Illness GetIllness(int id)
        {
            Illness illness = new Illness("name " + id, (id / 3 + 8) % 2 == 0, (id / 8 + 3) % 3 == 0, (id / 3 - 9) % 5 == 0);
            illness.IllnessID = id;
            return illness;
        }

        public bool CreatePatient(Patient patient)
        {
            return true;
        }

        public bool CreateIllness(Illness illness)
        {
            return true;
        }

        public bool UpdatePatient(Patient patient)
        {
            return true;
        }

        public bool UpdateIllness(Illness illness)
        {
            return true;
        }

        public bool LinkPatientIllness(Patient patient, Illness illness)
        {
            return true;
        }

        public bool DeletePatient(Patient patient)
        {
            return true;
        }

        public bool DeleteIllness(Illness illness)
        {
            return true;
        }

    }
}
