using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class Patient
    {    
        public long PatientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Patient()
        {
            this.PatientID = 0;
            this.FirstName = "";
            this.LastName = "";
            this.Birthday = DateTime.Today;
        }

        public Patient(String firstName, String lastName, DateTime birthday)
        {
            this.PatientID = 0;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        public Patient(long patientID, String firstName, String lastName, DateTime birthday)
        {
            this.PatientID = patientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        public override string ToString()
        {
            return String.Format("Patient #{0} {1} {2} ({3:dd.MM.yyyy})", this.PatientID, this.FirstName, this.LastName, this.Birthday);
        }
    }
}
