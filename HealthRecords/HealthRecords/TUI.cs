using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class TUI
    {
        public TUI()
        {
            System.Console.WriteLine("Hallo TUI");
            System.Console.ReadLine();
        }

        public TUI(Fachkonzept fachkonzept)
        {
            System.Console.WriteLine("Fachkonzept ist da!");
            System.Console.WriteLine("Schreibe Patient ...");            
            Patient createPatient = new Patient() { FirstName = "Gerlinde", LastName = "Buchnick", Birthday = DateTime.Today };
            System.Console.WriteLine("Vorname: " + createPatient.FirstName + " Nachname: " + createPatient.LastName);
            fachkonzept.CreatePatient(createPatient);

            System.Console.ReadLine();
        }
    }
}
