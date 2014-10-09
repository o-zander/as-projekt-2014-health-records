using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    interface IFachkonzept
    {

        // load items
        Patient[] GetPatients();
        Illness[] GetIllnesses();
        Patient[] GetPatients(int page, int pageSize);
        Illness[] GetIllnesses(int page, int pageSize);
        Patient GetPatient(long patientID);
        Illness GetIllness(long illnessID);

        // create items
        bool CreatePatient(Patient patient);
        bool CreateIllness(Illness illness);

        // update items
        bool UpdatePatient(Patient patient);
        bool UpdateIllness(Illness illness);

        // delete items
        bool DeletePatient(Patient patient);
        bool DeleteIllness(Illness illness);

        // add referenz
        bool LinkPatientIllness(Patient patient, Illness illness);
        bool UnLinkPatientIllness(Patient patient, Illness illness);
        
        // load referenz
        Illness[] GetPatientIllnesses(Patient patient);
        Patient[] GetIllnessPatients(Illness illness);
        Illness[] GetPatientIllnesses(Patient patient, int pager, int number);
        Patient[] GetIllnessPatients(Illness illness, int pager, int number);

        // get counts
        int GetPatientsCount();
        int GetIllnessesCount();
        int GetPatientIllnessesCount(Patient patient);
        int GetIllnessPatientsCount(Illness illness);

    }
}
