using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    interface IFachkonzept
    {
        Patient[] GetPatients();
        Illness[] GetIllnesses();
        Patient[] GetPatients(int page, int pageSize);
        Illness[] GetIllnesses(int page, int pageSize);
        Patient GetPatient(long patientID);
        Illness GetIllness(long illnessID);
        bool CreatePatient(Patient patient);
        bool CreateIllness(Illness illness);
        bool UpdatePatient(Patient patient);
        bool UpdateIllness(Illness illness);
        bool LinkPatientIllness(Patient patient, Illness illness);
        bool UnLinkPatientIllness(Patient patient, Illness illness);
        bool DeletePatient(Patient patient);
        bool DeleteIllness(Illness illness);
        Illness[] GetPatientIllnesses(Patient patient);
        Patient[] GetIllnessPatients(Illness illness);
        int GetPatientsCount();
        int GetIllnessesCount();
    }
}
