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
            /*
            System.Console.WriteLine("Lese Patient ...");
            Patient getPatient = fachkonzept.GetPatient(2);
            //System.Console.WriteLine("Vorname: {0} Nachname: {1} Geburtstag: {2} ID: {3}", getPatient.FirstName, getPatient.LastName, getPatient.Birthday.ToShortDateString(),getPatient.PatientID);            
            Patient[] patients = new Patient[20];
            patients = fachkonzept.GetPatients(20, 2);

            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i] != null)
                    System.Console.WriteLine("Vorname: {0} Nachname: {1} Geburtstag: {2} ID: {3}", patients[i].FirstName, patients[i].LastName, patients[i].Birthday.ToShortDateString(), patients[i].PatientID);
            }

            Patient updatePatient = new Patient() { FirstName = "Beatrice", LastName = "Bonnaparte", Birthday = DateTime.Parse("21.10.1987"), PatientID = 4 };
            System.Console.WriteLine("Update Patient ...");
            fachkonzept.UpdatePatient(updatePatient);            
            
            patients = fachkonzept.GetPatients(20, 0);

            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i] != null)
                    System.Console.WriteLine("Vorname: {0} Nachname: {1} Geburtstag: {2} ID: {3}", patients[i].FirstName, patients[i].LastName, patients[i].Birthday.ToShortDateString(), patients[i].PatientID);
            }
            
            System.Console.ReadLine();
             */
        }
    }
}
