using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IFachkonzept
    {

        Patient[] GetPatients();
        Illness[] GetIllnesses();
        Patient[] GetPatients(int pager, int number);
        Illness[] GetIllnesses(int pager, int number);
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
