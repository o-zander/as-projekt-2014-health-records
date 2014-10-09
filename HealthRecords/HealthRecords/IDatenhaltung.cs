using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    interface IDatenhaltung
    {
        // load items
        Patient[] GetPatientsData();
        Illness[] GetIllnessesData();
        Patient[] GetPatientsData(int page, int pageSize);
        Illness[] GetIllnessesData(int page, int pageSize);
        Patient GetPatientData(long patientID);
        Illness GetIllnessData(long illnessID);
        
        // create items
        bool CreatePatientData(Patient patient);
        bool CreateIllnessData(Illness illness);
        
        // update items
        bool UpdatePatientData(Patient patient);
        bool UpdateIllnessData(Illness illness);
        
        // delete items
        bool DeletePatientData(Patient patient);
        bool DeleteIllnessData(Illness illness);
        
        // add referenz
        bool LinkPatientIllnessData(Patient patient, Illness illness);
        bool UnLinkPatientIllness(Patient patient, Illness illness);

        // load referenz
        Illness[] GetPatientIllnessesData(Patient patient);
        Patient[] GetIllnessPatientsData(Illness illness);
        Illness[] GetPatientIllnessesData(Patient patient, int pager, int number);
        Patient[] GetIllnessPatientsData(Illness illness, int pager, int number);

        // get counts
        int GetPatientsCountData();
        int GetIllnessesCountData();
        int GetPatientIllnessesCountData(Patient patient);
        int GetIllnessPatientsCountData(Illness illness);
    }
}
