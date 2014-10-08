using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    interface IDatenhaltung
    {
        Patient[] GetPatientsData();
        Illness[] GetIllnessesData();
        Patient[] GetPatientsData(int page, int pageSize);
        Illness[] GetIllnessesData(int page, int pageSize);
        Patient GetPatientData(long patientID);
        Illness GetIllnessData(long illnessID);
        bool CreatePatientData(Patient patient);
        bool CreateIllnessData(Illness illness);
        bool UpdatePatientData(Patient patient);
        bool UpdateIllnessData(Illness illness);
        bool LinkPatientIllnessData(Patient patient, Illness illness);
        bool UnLinkPatientIllness(Patient patient, Illness illness);
        bool DeletePatientData(Patient patient);
        bool DeleteIllnessData(Illness illness);
        Illness[] GetPatientIllnessesData(Patient patient);
        Patient[] GetIllnessPatientsData(Illness illness);
        int GetPatientsCountData();
        int GetIllnessesCountData();
    }
}
