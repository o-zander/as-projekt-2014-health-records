using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
  interface IFachkonzept
  {
    public Patient[] GetPatients();
    public Illness[] GetIllnesses();
    public Patient GetPatient();
    public Illness GetIllness();
    public Boolean CreatePatient(Patient patient);
    public Boolean CreateIllness(Illness illness);
    public Boolean UpdatePatient(Patient patient);
    public Boolean UpdateIllness(Illness illness);
    public Boolean LinkPatientIllness(Patient patient,Illness illness);
    public Boolean DeletePatient(Patient patient);
    public Boolean DeleteIllness(Illness illness);
  }
}
