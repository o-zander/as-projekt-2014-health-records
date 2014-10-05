using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
  interface IDatenhaltung
  {
     Patient[] GetPatientsData(int setSize, long lastID);
     Illness[] GetIllnessesData(int setSize, long lastID);
     Patient GetPatientData(long patientID);
     Illness GetIllnessData(long illnessID);
     long CreatePatientData(Patient patient);
     long CreateIllnessData(Illness illness);
     bool UpdatePatientData(Patient patient);
     bool UpdateIllnessData(Illness illness);
     bool LinkPatientIllnessData(Patient patient, Illness illness);
     bool DeletePatientData(Patient patient);
     bool DeleteIllnessData(Illness illness);
  }
}
