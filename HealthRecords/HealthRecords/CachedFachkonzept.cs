using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class CachedFachkonzept : IFachkonzept
    {
        IDatenhaltung datenhaltung { get; set; }
        Dictionary<long, Patient> PatientCache { get; set; }
        Dictionary<long, Illness> IllnessCache { get; set; }

        public CachedFachkonzept(IDatenhaltung datenhaltung)
        {
            this.PatientCache = new Dictionary<long,Patient>();
            this.IllnessCache = new Dictionary<long, Illness>();
        }

        public Patient[] GetPatients(int setSize, long lastID)
        {
            throw new NotImplementedException();
        }

        public Illness[] GetIllnesses(int setSize, long lastID)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatient(long patientID)
        {
            if (!this.PatientCache.ContainsKey(patientID))
            {
                this.PatientCache[patientID] = this.datenhaltung.GetPatientData(patientID);
            }
            return this.PatientCache[patientID];
        }

        public Illness GetIllness(long illnessID)
        {
            if (!this.IllnessCache.ContainsKey(illnessID))
            {
                this.IllnessCache[illnessID] = this.datenhaltung.GetIllnessData(illnessID);
            }
            return this.IllnessCache[illnessID];
        }

        public long CreatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public long CreateIllness(Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIllness(Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool LinkPatientIllness(Patient patient, Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool UnLinkPatientIllness(Patient patient, Illness illness)
        {
            throw new NotImplementedException();
        }

        public bool DeletePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIllness(Illness illness)
        {
            throw new NotImplementedException();
        }

        public Illness[] GetPatientIllnesses(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Patient[] GetIllnessPatients(Illness illness)
        {
            throw new NotImplementedException();
        }

    }
}
