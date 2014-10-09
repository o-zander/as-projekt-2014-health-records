using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    /* Ein zwischenspeicherndes Fachkonzept
     * versucht get-Befehle zwischen zu speichern
     */
    class CachedFachkonzept : IFachkonzept
    {
        IDatenhaltung Datenhaltung { get; set; }
        Dictionary<long, Patient> PatientCache { get; set; }
        Dictionary<long, Illness> IllnessCache { get; set; }

        public CachedFachkonzept(IDatenhaltung datenhaltung)
        {
            this.Datenhaltung = datenhaltung;
            this.PatientCache = new Dictionary<long, Patient>();
            this.IllnessCache = new Dictionary<long, Illness>();
        }

        public Patient[] GetPatients()
        {
            if (this.PatientCache.Count != this.GetPatientsCount())
            {
                foreach (Patient patient in this.Datenhaltung.GetPatientsData())
                {
                    this.PatientCache[patient.PatientID] = patient;
                }
            }
            return this.PatientCache.Values.ToArray();
        }

        public Illness[] GetIllnesses()
        {
            if (this.IllnessCache.Count != this.GetIllnessesCount())
            {
                foreach (Illness illness in this.Datenhaltung.GetIllnessesData())
                {
                    this.IllnessCache[illness.IllnessID] = illness;
                }
            }
            return this.IllnessCache.Values.ToArray();
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
            if (!this.PatientCache.ContainsKey(patientID))
            {
                this.PatientCache[patientID] = this.Datenhaltung.GetPatientData(patientID);
            }
            return this.PatientCache[patientID];
        }

        public Illness GetIllness(long illnessID)
        {
            if (!this.IllnessCache.ContainsKey(illnessID))
            {
                this.IllnessCache[illnessID] = this.Datenhaltung.GetIllnessData(illnessID);
            }
            return this.IllnessCache[illnessID];
        }

        public bool CreatePatient(Patient patient)
        {
            if (this.Datenhaltung.CreatePatientData(patient))
            {
                return (this.PatientCache[patient.PatientID] = patient) != null;
            }
            else return false;
        }

        public bool CreateIllness(Illness illness)
        {
            if (this.Datenhaltung.CreateIllnessData(illness))
            {
                return (this.IllnessCache[illness.IllnessID] = illness) != null;
            }
            else return false;
        }

        public bool UpdatePatient(Patient patient)
        {
            return this.Datenhaltung.UpdatePatientData(patient);
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
            long patientID = patient.PatientID;

            if (this.Datenhaltung.DeletePatientData(patient))
            {
                return this.PatientCache.Remove(patientID) || true;
            }
            else return false;
        }

        public bool DeleteIllness(Illness illness)
        {
            long illnessID = illness.IllnessID;

            if (this.Datenhaltung.DeleteIllnessData(illness))
            {
                return this.IllnessCache.Remove(illnessID) || true;
            }
            else return false;
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
