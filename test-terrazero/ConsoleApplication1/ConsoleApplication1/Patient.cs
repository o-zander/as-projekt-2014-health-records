using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Patient
    {

        public int PatientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Patient()
        {
        }

        public Patient(string firstname, string lastname, DateTime birthday)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Birthday = birthday;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " : " + this.Birthday;
        }

    }
}
