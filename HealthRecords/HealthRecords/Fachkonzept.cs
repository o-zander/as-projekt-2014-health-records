using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class Fachkonzept : IFachkonzept
    {
        public Fachkonzept(DatenhaltungDB datenhaltungDB)
        {

        }

        public Fachkonzept(DatenhaltungXML datenhaltungXML)
        {

        }
        public Patient[] GetPatients(int pager)
        {
            Patient[] patients = new Patient[pager];
            return patients;
        }

        public Illness[] GetIllnesses(int pager)
        {
            Illness[] illnesses = new Illness[pager];
            return illnesses;
        }

        public Patient GetPatient()
        {
            Patient patient = new Patient();
            return patient;
        }

        public Illness GetIllness()
        {
            Illness illness = new Illness();
            return illness;
        }

        public Boolean CreatePatient(Patient patient)
        {
            return true;
        }

        public Boolean CreateIllness(Illness illness)
        {
            return true;
        }

        public Boolean UpdatePatient(Patient patient)
        {
            return true;
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
