using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IFachkonzept
    {

        Patient[] GetPatients(int pager);
        Illness[] GetIllnesses(int pager);
        Patient GetPatient(int id);
        Illness GetIllness(int id);
        Boolean CreatePatient(Patient patient);
        Boolean CreateIllness(Illness illness);
        Boolean UpdatePatient(Patient patient);
        Boolean UpdateIllness(Illness illness);
        Boolean LinkPatientIllness(Patient patient, Illness illness);
        Boolean DeletePatient(Patient patient);
        Boolean DeleteIllness(Illness illness);

    }
}
