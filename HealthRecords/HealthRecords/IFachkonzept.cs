using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
  interface IFachkonzept
  {
     Patient[] GetPatients(int setSize, long lastID);
     Illness[] GetIllnesses(int setSize, long lastID);
     Patient GetPatient(long patientID);
     Illness GetIllness(long illnessID);
     long CreatePatient(Patient patient);
     long CreateIllness(Illness illness);
     bool UpdatePatient(Patient patient);
     bool UpdateIllness(Illness illness);
     bool LinkPatientIllness(Patient patient,Illness illness);
     bool UnLinkPatientIllness(Patient patient, Illness illness);
     bool DeletePatient(Patient patient);
     bool DeleteIllness(Illness illness);
     Illness[] GetPatientIllnesses(Patient patient);
     Patient[] GetIllnessPatients(Illness illness);

  }
}
