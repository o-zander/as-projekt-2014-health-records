using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
  interface IDatenhaltung
  {
     Patient[] GetPatientsData(int setSize, int lastID);
     Illness[] GetIllnessesData(int setSize, int lastID);
     Patient GetPatientData(int patientID);
     Illness GetIllnessData(int illnessID);
     int CreatePatientData(Patient patient);
     int CreateIllnessData(Illness illness);
     bool UpdatePatientData(Patient patient);
     bool UpdateIllnessData(Illness illness);
     bool LinkPatientIllnessData(Patient patient, Illness illness);
     bool DeletePatientData(Patient patient);
     bool DeleteIllnessData(Illness illness);
  }
}
