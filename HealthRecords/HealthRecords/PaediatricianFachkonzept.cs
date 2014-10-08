using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    /* Ein Fachkonzept für Kinderärzte
     * Patienten die älter als 15 Jahre sind werden abgelehnt.
     */
    class PaediatricianFachkonzept : IFachkonzept
    {
        IDatenhaltung Datenhaltung { get; set; }

        public PaediatricianFachkonzept(IDatenhaltung datenhaltung)
        {
            this.Datenhaltung = datenhaltung;
        }

        private static bool AgeIsValid(DateTime birthday)
        {
            return (birthday - DateTime.Today).TotalDays < 16;
        }

        public Patient[] GetPatients()
        {
            return this.Datenhaltung.GetPatientsData();
        }

        public Illness[] GetIllnesses()
        {
            return this.Datenhaltung.GetIllnessesData();
        }

        public Patient[] GetPatients(int page, int pageSize)
        {
            return this.Datenhaltung.GetPatientsData(page, pageSize);
        }

        public Illness[] GetIllnesses(int page, int pageSize)
        {
            return this.Datenhaltung.GetIllnessesData(page, pageSize);
        }

        public Patient GetPatient(long patientID)
        {
            return this.Datenhaltung.GetPatientData(patientID);
        }

        public Illness GetIllness(long illnessID)
        {
            return this.Datenhaltung.GetIllnessData(illnessID);
        }

        public bool CreatePatient(Patient patient)
        {
            return AgeIsValid(patient.Birthday) ? this.Datenhaltung.CreatePatientData(patient) : false;
        }

        public bool CreateIllness(Illness illness)
        {
            return this.Datenhaltung.CreateIllnessData(illness);
        }

        public bool UpdatePatient(Patient patient)
        {
            return AgeIsValid(patient.Birthday) ? this.Datenhaltung.UpdatePatientData(patient) : false;
        }

        public bool UpdateIllness(Illness illness)
        {
            return this.Datenhaltung.UpdateIllnessData(illness);
        }

        public bool LinkPatientIllness(Patient patient, Illness illness)
        {
            return this.Datenhaltung.LinkPatientIllnessData(patient, illness);
        }

        public bool UnLinkPatientIllness(Patient patient, Illness illness)
        {
            return this.Datenhaltung.UnLinkPatientIllness(patient, illness);
        }

        public bool DeletePatient(Patient patient)
        {
            return this.Datenhaltung.DeletePatientData(patient);
        }

        public bool DeleteIllness(Illness illness)
        {
            return this.Datenhaltung.DeleteIllnessData(illness);
        }

        public Illness[] GetPatientIllnesses(Patient patient)
        {
            return this.Datenhaltung.GetPatientIllnessesData(patient);
        }

        public Patient[] GetIllnessPatients(Illness illness)
        {
            return this.Datenhaltung.GetIllnessPatientsData(illness);
        }

        public int GetPatientsCount()
        {
            return this.Datenhaltung.GetPatientsCountData();
        }

        public int GetIllnessesCount()
        {
            return this.Datenhaltung.GetIllnessesCountData();
        }
    }
}
