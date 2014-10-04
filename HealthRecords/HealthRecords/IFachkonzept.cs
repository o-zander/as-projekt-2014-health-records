using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
  interface IFachkonzept
  {
     Patient[] GetPatients(int setSize, int lastID);
     Illness[] GetIllnesses(int setSize, int lastID);
     Patient GetPatient(int patientID);
     Illness GetIllness(int illnessID);
     Boolean CreatePatient(Patient patient);
     Boolean CreateIllness(Illness illness);
     Boolean UpdatePatient(Patient patient);
     Boolean UpdateIllness(Illness illness);
     Boolean LinkPatientIllness(Patient patient,Illness illness);
     Boolean DeletePatient(Patient patient);
     Boolean DeleteIllness(Illness illness);
  }
}
