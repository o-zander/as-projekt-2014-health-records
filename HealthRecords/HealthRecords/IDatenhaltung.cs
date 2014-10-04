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
     Boolean CreatePatientData(Patient patient);
     Boolean CreateIllnessData(Illness illness);
     Boolean UpdatePatientData(Patient patient);
     Boolean UpdateIllnessData(Illness illness);
     Boolean LinkPatientIllnessData(Patient patient, Illness illness);
     Boolean DeletePatientData(Patient patient);
     Boolean DeleteIllnessData(Illness illness);
  }
}
