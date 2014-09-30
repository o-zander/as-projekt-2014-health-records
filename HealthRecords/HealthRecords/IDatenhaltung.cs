using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
  interface IDatenhaltung
  {
     Patient[] GetPatientsData(int pager);
     Illness[] GetIllnessesData(int pager);
     Patient GetPatientData();
     Illness GetIllnessData();
     Boolean CreatePatientData(Patient patient);
     Boolean CreateIllnessData(Illness illness);
     Boolean UpdatePatientData(Patient patient);
     Boolean UpdateIllnessData(Illness illness);
     Boolean LinkPatientIllnessData(Patient patient, Illness illness);
     Boolean DeletePatientData(Patient patient);
     Boolean DeleteIllnessData(Illness illness);
  }
}
