using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
  interface IDatenhaltung
  {
    public Patient[] GetPatientsData();
    public Illness[] GetIllnessesData();
    public Patient GetPatientData();
    public Illness GetIllnessData();
    public Boolean CreatePatientData(Patient patient);
    public Boolean CreateIllnessData(Illness illness);
    public Boolean UpdatePatientData(Patient patient);
    public Boolean UpdateIllnessData(Illness illness);
    public Boolean LinkPatientIllnessData(Patient patient, Illness illness);
    public Boolean DeletePatientData(Patient patient);
    public Boolean DeleteIllnessData(Illness illness);
  }
}
