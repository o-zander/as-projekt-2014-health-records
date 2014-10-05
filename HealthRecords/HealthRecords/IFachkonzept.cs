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
     int CreatePatient(Patient patient);
     int CreateIllness(Illness illness);
     bool UpdatePatient(Patient patient);
     bool UpdateIllness(Illness illness);
     bool LinkPatientIllness(Patient patient,Illness illness);
     bool DeletePatient(Patient patient);
     bool DeleteIllness(Illness illness);
  }
}
