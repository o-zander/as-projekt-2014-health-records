﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecords
{
    interface IFachkonzept
    {
        Patient[] GetPatients();
        Illness[] GetIllnesses();
        Patient GetPatient();
        Illness GetIllness();
        Boolean CreatePatient(Patient patient);
        Boolean CreateIllness(Illness illness);
        Boolean UpdatePatient(Patient patient);
        Boolean UpdateIllness(Illness illness);
        Boolean LinkPatientIllness(Patient patient, Illness illness);
        Boolean DeletePatient(Patient patient);
        Boolean DeleteIllness(Illness illness);
    }
}
