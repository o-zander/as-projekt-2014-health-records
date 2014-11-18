using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{

    abstract class BaseFachkonzept
    {

        protected IDatenhaltung datenhaltung;


        public BaseFachkonzept(IDatenhaltung datenhaltung)
        {
            this.datenhaltung = datenhaltung;
        }

        public bool DeleteIllness(Illness illness)
        {
            int result = this.datenhaltung.GetIllnessPatientsCountData(illness);

            if (result == 0) {
                return this.datenhaltung.DeleteIllnessData(illness);
            } else if (result > 0) {
                // TODO create exception
            }
            return false;
        }    
   
    }

}
