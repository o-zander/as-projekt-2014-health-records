using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TUI
    {

        public IFachkonzept Fachkonzept { get; set; }

        public TUI(IFachkonzept fachkonzept)
        {
            this.Fachkonzept = fachkonzept;
            this.CurrentMenu = "root";
            this.Number = 5;
        }

        public void run()
        {
            while (true)
            {
                this.Page();
            }
        }

        public void PrePage()
        {
            this.PrintMenu();
            this.PrintCommand("Clear the Console", "clear");
            this.PrintCommand("Close the Console", "exit");
            ConIO.OutputNewLine();
        }

        public void Page()
        {
            this.PrePage();
            this.PrintMenuPage(this.CurrentMenu, this.CurrentPage);
            ConIO command = ConIO.Input("Input");
            this.Command(command);
        }

        public void Command(ConIO command) 
        {
            if (this.CommandCommand(command)) return;
            if (this.MenuCommand(command)) return;
            if (this.PageCommand(command)) return;
            ConIO.OutputNewLine();
            ConIO.OutputLine("Befehl '" + command.StringInput + "' konnte nicht gefunden werden.");
        }

        public bool CommandCommand(ConIO command)
        {
            switch (command.StringInput)
            {
                case "exit" :
                    ConIO.OutputLine("Programm beendet!");
                    Environment.Exit(0);
                    return true;
                case "clear" :
                    Console.Clear();
                    return true;
                default :
                    return false;
            }
        }

        public void PrintCommand(string item, string command)
        {
            ConIO.OutputLine(item + " ( " + command + " )");
        }


        //######################### Menu ###############################
        /*
         * Menu strucktur
         * 
         * root 
         *     patients 
         *         patient
         *             patient-illness
         *     illnesses
         *         illness 
         *             illness-patient
         */
        /*
         * Pages
         * 
         * none
         * patientlist
         * illnesslist
         * patient-illnesslist
         * illness-patientlist
         * patient
         * illness
         */

        private string CurrentMenu { get; set; }
        private string CurrentPage { get; set; }
        private int CurrentPager { get; set; }
        private Patient CurrentPatient { get; set; }
        private Illness CurrentIllness { get; set; }

        private int Number { get; set; }

        public void GoTo(string menu)
        {
            this.GoTo(menu, "none");
        }

        public void GoTo(string menu, string page)
        {
            this.CurrentMenu = menu;
            this.CurrentPage = page;
            // set the pager to 0 by list page call
            if (page == "patientlist" || page == "illnesslist")
            {
                this.CurrentPager = 0;
            }
        }

        public void GoToPage(string menu, string page)
        {
            this.GoTo(menu, page);
            this.Page();
        }

        public void PrintMenu()
        {
            ConIO.OutputNewLine();
            this.PrintActionMenu();
            this.PrintPageMenu();
        }

        public void PrintActionMenu()
        {
            switch (this.CurrentMenu)
            {
                case "root":
                    ConIO.OutputLine("Menu: Root");
                    ConIO.OutputNewLine();
                    this.PrintItem("Show Patients", "patients");
                    this.PrintItem("Show Illnesses", "illnesses");
                    break;
                case "patients":
                    ConIO.OutputLine("Menu: Patients");
                    ConIO.OutputNewLine();
                    this.PrintItem("Add a Patient", "add");
                    this.PrintItem("Show Patient");
                    this.PrintItem("Go Back", "back");
                    break;
                case "illnesses":
                    ConIO.OutputLine("Menu: Illnesses");
                    ConIO.OutputNewLine();
                    this.PrintItem("Add a Illness", "add");
                    this.PrintItem("Show Illness");
                    this.PrintItem("Go Back", "back");
                    break;
                case "patient":
                    ConIO.OutputLine("Menu: Patient");
                    ConIO.OutputNewLine();
                    this.PrintItem("Edit Patient", "edit");
                    this.PrintItem("Delete Patient", "delete");
                    this.PrintItem("Show Illnesses of Patient", "illnesses");
                    this.PrintItem("Go Back", "back");
                    break;
                case "illness":
                    ConIO.OutputLine("Menu: Illness");
                    ConIO.OutputNewLine();
                    this.PrintItem("Edit Illness", "edit");
                    this.PrintItem("Delete Illness", "delete");
                    this.PrintItem("Show Patients of Illness", "patients");
                    this.PrintItem("Go Back", "back");
                    break;
                case "patient-illness" :
                    ConIO.OutputLine("Menu: Patient - Illnesses");
                    ConIO.OutputNewLine();
                    this.PrintItem("Remove a Illness", "remove");
                    this.PrintItem("Add a Illness to the Patient", "add");
                    this.PrintItem("Go Back", "back");
                    break;
                case "illness-patient" :
                    ConIO.OutputLine("Menu: Illness - Patients");
                    ConIO.OutputNewLine();
                    this.PrintItem("Remove a Patient", "remove");
                    this.PrintItem("Add a Patient to the Illness", "add");
                    this.PrintItem("Go Back", "back");
                    break;
                case "patient-add" :
                    ConIO.OutputLine("Menu: Add Patient");
                    ConIO.OutputNewLine();
                    this.PrintItem("Abort new Patient", "cancel");
                    break;
            }
        }

        public void PrintPageMenu()
        {
            switch (this.CurrentPage) 
            { 
                case "patientlist" :
                case "illnesslist":
                case "patient-illnesslist" :
                case "illness-patientlist" :
                    this.PrintItem("Show Next Page", "next");
                    this.PrintItem("Show Previous Page", "prev");
                    break;
            }
        }

        public void PrintMenuPage(string menu, string page)
        {
            switch (page)
            {
                case "patientlist" :
                    // TODO die maximale page anzahl 
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + "5");
                    Patient[] patients = this.Fachkonzept.GetPatients(this.CurrentPager, this.Number);
                    for (int i = 0; i < patients.Length; i++)
                    {
                        ConIO.OutputLine("(" + patients[i].PatientID + ") " + patients[i]);
                    }
                    ConIO.OutputNewLine();
                    break;
                case "patient" :
                    ConIO.OutputLine("Patient:");
                    ConIO.OutputLine("ID: " + this.CurrentPatient.PatientID);
                    ConIO.OutputLine("Firstname: " + this.CurrentPatient.FirstName);
                    ConIO.OutputLine("Lastname: " + this.CurrentPatient.LastName);
                    ConIO.OutputLine("Birthdate: " + this.CurrentPatient.Birthday);
                    ConIO.OutputNewLine();
                    break;
                case "illnesslist" :
                    // TODO die maximale page anzahl 
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + "5");
                    Illness[] illnesses = this.Fachkonzept.GetIllnesses(this.CurrentPager, this.Number);
                    for (int i = 0; i < illnesses.Length; i++)
                    {
                        ConIO.OutputLine("(" + illnesses[i].IllnessID + ") " + illnesses[i]);
                    }
                    ConIO.OutputNewLine();
                    break;
                case "illness" :
                    ConIO.OutputLine("Illness:");
                    ConIO.OutputLine("ID: " + this.CurrentIllness.IllnessID);
                    ConIO.OutputLine("Name: " + this.CurrentIllness.Name);
                    ConIO.OutputLine("Contagious: " + this.CurrentIllness.Contagious);
                    ConIO.OutputLine("Curable: " + this.CurrentIllness.Curable);
                    ConIO.OutputLine("Lethal: " + this.CurrentIllness.Lethal);
                    ConIO.OutputNewLine();
                    break;
                case "patient-illnesslist" :
                    // TODO die maximale page anzahl 
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + "5");
                    Illness[] patientillnesses = this.Fachkonzept.GetIllnessesToPatient(this.CurrentPatient, this.CurrentPager, this.Number);
                    for (int i = 0; i < patientillnesses.Length; i++)
                    {
                        ConIO.OutputLine("(" + patientillnesses[i].IllnessID + ") " + patientillnesses[i]);
                    }
                    ConIO.OutputNewLine();
                    break;
                case "illness-patientlist" :
                    // TODO die maximale page anzahl 
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + "5");
                    Patient[] illnesspatients = this.Fachkonzept.GetPatientsToIllness(this.CurrentIllness, this.CurrentPager, this.Number);
                    for (int i = 0; i < illnesspatients.Length; i++)
                    {
                        ConIO.OutputLine("(" + illnesspatients[i].PatientID + ") " + illnesspatients[i]);
                    }
                    ConIO.OutputNewLine();
                    break;
                case "patient-add" :
                    this.CurrentPatient = new Patient();
                    ConIO input = null;

                    input = ConIO.Input("Patient First Name");
                    if (input.StringInput == "cancel")
                    {
                        this.CancelAddPatient();
                        break;
                    }
                    this.CurrentPatient.FirstName = input.StringInput;

                    input = ConIO.Input("Patient Last Name");
                    if (input.StringInput == "cancel")
                    {
                        this.CancelAddPatient();
                        break;
                    }
                    this.CurrentPatient.LastName = input.StringInput;

                    input = ConIO.Input("Patient Birthday");
                    if (input.StringInput == "cancel")
                    {
                        this.CancelAddPatient();
                        break;
                    }
                    this.CurrentPatient.Birthday = Convert.ToDateTime(input.StringInput);

                    ConIO.OutputNewLine();
                    this.PrintMenuPage(this.CurrentMenu, "patient");
                    if (ConIO.Confirm("Add the Patient?"))
                    {
                        this.Fachkonzept.CreatePatient(this.CurrentPatient);
                    }
                    else
                    {
                        this.GoToPage("patients", "patientlist");
                    }
                    this.GoToPage("patient", "patient");
                    break;
            }
        }

        public void CancelAddPatient()
        {
            this.GoTo("patients", "patientlist");
            this.CurrentPatient = null;
        }

        public void PrintItem(string item)
        {
            ConIO.OutputLine(item + " ( ### )");
        }

        private void PrintItem(string item, int number)
        {
            ConIO.OutputLine(item + " ( " + Menu.GetChar(number) + " )");
        }

        private void PrintItem(string item, string command)
        {
            ConIO.OutputLine(item + " ( " + command + " )");
        }

        public bool MenuCommand(ConIO command)
        {
            switch (this.CurrentMenu)
            {
                case "root":
                    switch (command.StringInput)
                    {
                        case "patients":
                            this.GoTo("patients", "patientlist");
                            return true;
                        case "illnesses":
                            this.GoTo("illnesses", "illnesslist");
                            return true;
                    }
                    break;
                case "patients":
                    if (command.TestInt())
                    {
                        Patient loadPatient = this.Fachkonzept.GetPatient(command.IntInput);
                        if (loadPatient == null)
                        {
                            ConIO.OutputNewLine();
                            ConIO.OutputError("ERROR: Patient " + command.IntInput + " not found!");
                        }
                        else
                        {
                            this.CurrentPatient = loadPatient;
                            this.GoTo("patient", "patient");
                        }
                        return true;
                    }
                    switch (command.StringInput)
                    {
                        case "add":
                            this.GoTo("patient-add", "patient-add");
                            return true;
                        case "back":
                            this.GoTo("root");
                            return true;
                    }
                    break;
                case "illnesses":
                    if (command.TestInt())
                    {
                        Illness loadIllness = this.Fachkonzept.GetIllness(command.IntInput);
                        if (loadIllness == null)
                        {
                            ConIO.OutputNewLine();
                            ConIO.OutputError("ERROR: Illness " + command.IntInput + " not found!");
                        }
                        else
                        {
                            this.CurrentIllness = loadIllness;
                            this.GoTo("illness", "illness");
                        }
                        return true;
                    }
                    switch (command.StringInput)
                    {
                        case "add":
                            // TODO add a illness
                            return true;
                        case "back":
                            this.GoTo("root");
                            return true;
                    }
                    break;
                case "patient":
                    switch (command.StringInput)
                    {
                        case "delete" :
                            ConIO.OutputNewLine();
                            if (ConIO.Confirm("Delete Patient (" + this.CurrentPatient.PatientID + ")?"))
                            {
                                if (this.Fachkonzept.DeletePatient(this.CurrentPatient))
                                {
                                    this.GoTo("patients", "patientlist");
                                }
                                else
                                {
                                    ConIO.OutputError("ERROR: Can not delete Patient " + this.CurrentPatient.PatientID);
                                }
                            }
                            return true;
                        case "illnesses" :
                            this.GoTo("patient-illness", "patient-illnesslist");
                            return true;
                        case "back" :
                            this.GoTo("patients", "patientlist");
                            return true;
                    }
                    break;
                case "illness":
                    switch (command.StringInput)
                    {
                        case "delete":
                            ConIO.OutputNewLine();
                            if (ConIO.Confirm("Delete Illness (" + this.CurrentIllness.IllnessID + ")?"))
                            {
                                if (this.Fachkonzept.DeleteIllness(this.CurrentIllness))
                                {
                                    this.GoTo("illnesses", "illnesslist");
                                }
                                else
                                {
                                    ConIO.OutputError("ERROR: Can not delete Illness " + this.CurrentIllness.IllnessID);
                                }
                            }
                            return true;
                        case "patients" :
                            this.GoTo("illness-patient", "illness-patientlist");
                            break;
                        case "back" :
                            this.GoTo("illnesses", "illnesslist");
                            return true;
                    }
                    break;
                case "patient-illness" :
                    switch (command.StringInput)
                    {
                        case "back" :
                            this.GoTo("patient", "patient");
                            return true;
                    }
                    break;
                case "illness-patient" :
                    switch (command.StringInput)
                    {
                        case "back" :
                            this.GoTo("illness", "illness");
                            return true;
                    }
                    break;
            }
            return false;
        }

        public bool PageCommand(ConIO command)
        {
            switch (this.CurrentPage)
            {
                case "patientlist" : 
                case "illnesslist" :
                case "illness-patientlist":
                case "patient-illnesslist":
                    switch (command.StringInput)
                    {
                        case "next" :
                            this.CurrentPager++;
                            // TODO maximum page abfangen
                            return true;
                        case "prev" :
                            this.CurrentPager--;
                            if (this.CurrentPager < 0) this.CurrentPager = 0;
                            return true;
                    }
                    break;
            }
            return false;
        }

    }
}
