using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecords
{
    class TUI
    {

        public IFachkonzept Fachkonzept { get; set; }

        public TUI(IFachkonzept fachkonzept)
        {
            this.Fachkonzept = fachkonzept;
            this.CurrentMenu = "root";
            this.PagerNumber = 5;
        }

        /*
         * start the console application
         */
        public void run()
        {
            while (true)
            {
                this.Page();
            }
        }

        /*
         * Build the entire page 
         */
        public void Page()
        {
            Console.Clear();
            // print the current menu and current page
            this.PrintMenu();
            ConIO.OutputNewLine();
            if (this.PrintMenuPage(this.CurrentMenu, this.CurrentPage))
            {
                ConIO.OutputNewLine();
            }
            ConIO command = null;

            // if a current command is given than skip the user input
            if (this.CurrentCommand == null)
            {
                command = ConIO.Input("Input");
                ConIO.OutputNewLine();
            }
            else
            {
                command = new ConIO(this.CurrentCommand);
                this.CurrentCommand = null;
            }

            // execute the command
            this.Command(command);
        }

        /*
         * Execute a command through all command functions
         */
        public void Command(ConIO command)
        {
            if (this.CommandCommand(command)) return;
            if (this.MenuCommand(command)) return;
            if (this.PageCommand(command)) return;

            // if no function returned true the command was not found
            ConIO.OutputError("ERROR: Command '" + command.StringInput + "' was not found!");
        }

        /*
         * Execute the normal console commands
         * Return true if the command was found
         */
        public bool CommandCommand(ConIO command)
        {
            switch (command.StringInput)
            {
                case "exit":
                    ConIO.OutputLine("Programm beendet!");
                    Environment.Exit(0);
                    return true;
                case "clear":
                    Console.Clear();
                    return true;
            }
            return false;
        }

        //settings
        private int PagerNumber { get; set; }

        //current vars
        private string CurrentMenu { get; set; }
        private string CurrentPage { get; set; }
        private int CurrentPager { get; set; }
        private Patient CurrentPatient { get; set; }
        private Illness CurrentIllness { get; set; }
        private string CurrentCommand { get; set; }

        /*
         * @see this.GoTo(string, string)
         * goto the defined menu
         */
        public void GoTo(string menu)
        {
            this.GoTo(menu, "none");
        }

        /*
         * goto the defined menu and page
         */
        public void GoTo(string menu, string page)
        {
            this.CurrentMenu = menu;
            this.CurrentPage = page;
            // set the pager to 0 by list page call
            switch (page)
            {
                case "patientlist":
                case "illnesslist":
                case "patient-illnesslist":
                case "illness-patientlist":
                    this.CurrentPager = 0;
                    break;
            }
        }

        /*
         * @see this.GoTo(string, string)
         * command - the command which execute, ignore the input of the user
         */
        public void GoToPage(string menu, string page, string command)
        {
            this.GoTo(menu, page);
            this.CurrentCommand = command;
        }

        /*
         * The function to print the full menu in order
         */
        public void PrintMenu()
        {
            this.PrintActionMenu();
            this.PrintCommandMenu();
            this.PrintPageMenu();
        }

        /*
         * Print the normal commands, depends on current menu
         * e.g. exit and clear the console
         */
        public void PrintCommandMenu()
        {
            switch (this.CurrentMenu)
            {
                case "patient-add":
                case "illness-add":
                case "patient-edit":
                case "illness-edit":
                    // print no command menu
                    break;
                default:
                    //this.PrintItem("Clear the Console", "clear");
                    this.PrintItem("Close the Console", "exit");
                    break;
            }
        }

        /*
         * Print the commands for the normal menu, depends on current menu
         */
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
                    ConIO.OutputLine("Menu: Root > Patients");
                    ConIO.OutputNewLine();
                    this.PrintItem("Add a Patient", "add");
                    this.PrintItem("Show Patient");
                    this.PrintItem("Go Back", "back");
                    break;
                case "illnesses":
                    ConIO.OutputLine("Menu: Root > Illnesses");
                    ConIO.OutputNewLine();
                    this.PrintItem("Add a Illness", "add");
                    this.PrintItem("Show Illness");
                    this.PrintItem("Go Back", "back");
                    break;
                case "patient":
                    ConIO.OutputLine("Menu: Root > Patients > Patient(" + this.DescribePatient(this.CurrentPatient) + ")");
                    ConIO.OutputNewLine();
                    this.PrintItem("Edit Patient", "edit");
                    this.PrintItem("Delete Patient", "delete");
                    this.PrintItem("Show Illnesses of Patient", "illnesses");
                    this.PrintItem("Go Back", "back");
                    break;
                case "illness":
                    ConIO.OutputLine("Menu: Root > Illnesses > Illness(" + this.DescribeIllness(this.CurrentIllness) + ")");
                    ConIO.OutputNewLine();
                    this.PrintItem("Edit Illness", "edit");
                    this.PrintItem("Delete Illness", "delete");
                    this.PrintItem("Show Patients of Illness", "patients");
                    this.PrintItem("Go Back", "back");
                    break;
                case "patient-illness":
                    ConIO.OutputLine("Menu: Root > Patients > Patient(" + this.DescribePatient(this.CurrentPatient) + ") > Illnesses");
                    ConIO.OutputNewLine();
                    this.PrintItem("Remove a Illness", "remove");
                    this.PrintItem("Add a Illness to the Patient", "add");
                    this.PrintItem("Go Back", "back");
                    break;
                case "illness-patient":
                    ConIO.OutputLine("Menu: Root > Illnesses > Illness(" + this.DescribeIllness(this.CurrentIllness) + ") > Patients");
                    ConIO.OutputNewLine();
                    this.PrintItem("Remove a Patient", "remove");
                    this.PrintItem("Add a Patient to the Illness", "add");
                    this.PrintItem("Go Back", "back");
                    break;
                case "patient-add":
                    ConIO.OutputLine("Menu: Root > Patients >> Add Patient");
                    ConIO.OutputNewLine();
                    this.PrintItem("Abort new Patient", "cancel");
                    break;
                case "illness-add":
                    ConIO.OutputLine("Menu: Root > Illnesses >> Add Illness");
                    ConIO.OutputNewLine();
                    this.PrintItem("Abort new Illness", "cancel");
                    break;
                case "patient-edit":
                    ConIO.OutputLine("Menu: Root > Patients > Patient(" + this.DescribePatient(this.CurrentPatient) + ") >> Edit Patient");
                    ConIO.OutputNewLine();
                    this.PrintItem("Abort edit Patient", "cancel");
                    break;
                case "illness-edit":
                    ConIO.OutputLine("Menu: Root > Illnesses > Illness(" + this.DescribeIllness(this.CurrentIllness) + ") >> Edit Illness");
                    ConIO.OutputNewLine();
                    this.PrintItem("Abort edit Illness", "cancel");
                    break;
                case "patient-illness-add":
                    ConIO.OutputLine("Menu: Root > Patients > Patient(" + this.DescribePatient(this.CurrentPatient) + ") > Illnesses >> Add Illness");
                    ConIO.OutputNewLine();
                    this.PrintItem("Add illness to patient");
                    this.PrintItem("Abort add illness", "back");
                    break;
                case "patient-illness-remove":
                    ConIO.OutputLine("Menu: Root > Patients > Patient(" + this.DescribePatient(this.CurrentPatient) + ") > Illnesses >> Remove Illness");
                    ConIO.OutputNewLine();
                    this.PrintItem("Remove illness from patient");
                    this.PrintItem("Abort remove illness", "back");
                    break;
                case "illness-patient-add":
                    ConIO.OutputLine("Menu: Root > Illnesses > Illness(" + this.DescribeIllness(this.CurrentIllness) + ") > Patients >> Add Patient");
                    ConIO.OutputNewLine();
                    this.PrintItem("Add patient to illness");
                    this.PrintItem("Abort add patient", "back");
                    break;
                case "illness-patient-remove":
                    ConIO.OutputLine("Menu: Root > Illnesses > Illness(" + this.DescribeIllness(this.CurrentIllness) + ") > Patients >> Remove Patient");
                    ConIO.OutputNewLine();
                    this.PrintItem("Remove patient from illness");
                    this.PrintItem("Abort remove patient", "back");
                    break;
            }
        }

        /*
         * Print commands depends of the current page 
         * e.g. the pager functions
         */
        public void PrintPageMenu()
        {
            switch (this.CurrentPage)
            {
                case "patientlist":
                case "illnesslist":
                case "patient-illnesslist":
                case "illness-patientlist":
                    this.PrintItem("Show Next Page", "next");
                    this.PrintItem("Show Previous Page", "prev");
                    break;
            }
        }

        /*
         * Get the maximum pager number
         */
        public int GetMaxPager(int count)
        {
            return (count - 1) / this.PagerNumber;
        }

        /*
         * Print a page depends on menu and page
         * e.g. for a full patient to show or a list of illnesses
         * Return true if a page is given for the menu and page
         */
        public bool PrintMenuPage(string menu, string page)
        {
            switch (page)
            {
                // print a list of patients
                case "patientlist":
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + (this.GetMaxPager(this.Fachkonzept.GetPatientsCount()) + 1));
                    Patient[] patients = this.Fachkonzept.GetPatients(this.CurrentPager, this.PagerNumber);
                    for (int i = 0; i < patients.Length; i++)
                    {
                        ConIO.OutputLine("(" + patients[i].PatientID + ") " + this.DescribePatientRow(patients[i]));
                    }
                    return true;
                // print a loaded patient
                case "patient":
                    ConIO.OutputLine("Patient:");
                    ConIO.OutputLine("ID: " + this.CurrentPatient.PatientID);
                    ConIO.OutputLine("Firstname: " + this.CurrentPatient.FirstName);
                    ConIO.OutputLine("Lastname: " + this.CurrentPatient.LastName);
                    ConIO.OutputLine("Birthdate: " + this.CurrentPatient.Birthday.ToShortDateString());
                    return true;
                // print a list of illnesses
                case "illnesslist":
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + (this.GetMaxPager(this.Fachkonzept.GetIllnessesCount()) + 1));
                    Illness[] illnesses = this.Fachkonzept.GetIllnesses(this.CurrentPager, this.PagerNumber);
                    for (int i = 0; i < illnesses.Length; i++)
                    {
                        ConIO.OutputLine("(" + illnesses[i].IllnessID + ") " + this.DescribeIllnessRow(illnesses[i]));
                    }
                    return true;
                // print a loaded illness
                case "illness":
                    ConIO.OutputLine("Illness:");
                    ConIO.OutputLine("ID: " + this.CurrentIllness.IllnessID);
                    ConIO.OutputLine("Name: " + this.CurrentIllness.Name);
                    ConIO.OutputLine("Contagious: " + this.CurrentIllness.Contagious);
                    ConIO.OutputLine("Lethal: " + this.CurrentIllness.Lethal);
                    ConIO.OutputLine("Curable: " + this.CurrentIllness.Curable);
                    return true;
                // print a list of illnesses associated by a loaded patient
                case "patient-illnesslist":
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + (this.GetMaxPager(this.Fachkonzept.GetPatientIllnessesCount(this.CurrentPatient)) + 1));
                    Illness[] patientillnesses = this.Fachkonzept.GetPatientIllnesses(this.CurrentPatient, this.CurrentPager, this.PagerNumber);
                    for (int i = 0; i < patientillnesses.Length; i++)
                    {
                        ConIO.OutputLine("(" + patientillnesses[i].IllnessID + ") " + this.DescribeIllnessRow(patientillnesses[i]));
                    }
                    return true;
                // print a list of patients associated by a loaded illness
                case "illness-patientlist":
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + (this.GetMaxPager(this.Fachkonzept.GetIllnessPatientsCount(this.CurrentIllness)) + 1));
                    Patient[] illnesspatients = this.Fachkonzept.GetIllnessPatients(this.CurrentIllness, this.CurrentPager, this.PagerNumber);
                    for (int i = 0; i < illnesspatients.Length; i++)
                    {
                        ConIO.OutputLine("(" + illnesspatients[i].PatientID + ") " + this.DescribePatientRow(illnesspatients[i]));
                    }
                    return true;
                case "patient-add":
                case "illness-add":
                    this.CurrentCommand = "add";
                    break;
                case "patient-edit":
                case "illness-edit":
                    this.CurrentCommand = "edit";
                    break;
                case "illness-patient-add":
                case "patient-illness-add":
                    this.CurrentCommand = "add";
                    break;
                case "illness-patient-remove":
                case "patient-illness-remove":
                    this.CurrentCommand = "remove";
                    break;
            }
            return false;
        }

        /*
         * Test if the add-patient command was canceled by user
         * Return true if canceled
         */
        public bool CancelAddPatient(string input)
        {
            if (input == "cancel")
            {
                ConIO.OutputNewLine();
                ConIO.OutputLine("Abort new Patient!");
                ConIO.OutputNewLine();
                this.GoTo("patients", "patientlist");
                this.CurrentPatient = null;
                return true;
            }
            return false;
        }

        /*
         * Test if the add-illness command was canceled by user
         * Return true if canceled
         */
        public bool CancelAddIllness(string input)
        {
            if (input == "cancel")
            {
                ConIO.OutputNewLine();
                ConIO.OutputLine("Abort new Illness!");
                ConIO.OutputNewLine();
                this.GoTo("illnesses", "illnesslist");
                this.CurrentPatient = null;
                return true;
            }
            return false;
        }

        /*
         * Test if the edit-patient command was canceled by user
         * Return true if canceled
         */
        public bool CancelEditPatient(string input)
        {
            if (input == "cancel")
            {
                ConIO.OutputNewLine();
                ConIO.OutputLine("Abort edit Patient!");
                ConIO.OutputNewLine();
                this.GoTo("patient", "patient");

                // load a fresh patient to undo the edits by user
                this.CurrentPatient = this.Fachkonzept.GetPatient(this.CurrentPatient.PatientID);
                return true;
            }
            return false;
        }

        /*
         * Test if the edit-illness command was canceled by user
         * Return true if canceled
         */
        public bool CancelEditIllness(string input)
        {
            if (input == "cancel")
            {
                ConIO.OutputNewLine();
                ConIO.OutputLine("Abort edit Illness!");
                ConIO.OutputNewLine();
                this.GoTo("illness", "illness");

                // load a fresh illness to undo the edits by user
                this.CurrentIllness = this.Fachkonzept.GetIllness(this.CurrentIllness.IllnessID);
                return true;
            }
            return false;
        }

        /*
         * Print a menu item which has no defined command
         */
        public void PrintItem(string item)
        {
            ConIO.OutputLine(item + " ( ### )");
        }

        /*
         * print a single menu item with command
         */
        private void PrintItem(string item, string command)
        {
            ConIO.OutputLine(item + " ( " + command + " )");
        }

        /*
         * Execute commands that depends on menu
         * Return true if the command was found
         */
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
                        case "back":
                            if (ConIO.Confirm("Exit programm?"))
                            {
                                ConIO.OutputLine("Programm beendet!");
                                Environment.Exit(0);
                            }
                            return true;
                    }
                    break;
                case "patients":
                    if (command.TestInt())
                    {
                        Patient loadPatient = this.Fachkonzept.GetPatient(command.IntInput);
                        if (loadPatient == null)
                        {
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
                            this.GoTo("illness-add", "illness-add");
                            return true;
                        case "back":
                            this.GoTo("root");
                            return true;
                    }
                    break;
                case "patient":
                    switch (command.StringInput)
                    {
                        case "edit":
                            this.GoTo("patient-edit", "patient-edit");
                            return true;
                        case "delete":
                            if (ConIO.Confirm("Delete Patient (" + this.DescribePatient(this.CurrentPatient) + ")?"))
                            {
                                if (this.Fachkonzept.DeletePatient(this.CurrentPatient))
                                {
                                    this.GoTo("patients", "patientlist");
                                }
                                else
                                {
                                    ConIO.OutputError("ERROR: Can not delete Patient (" + this.DescribePatient(this.CurrentPatient) + ")!");
                                }
                            }
                            return true;
                        case "illnesses":
                            this.GoTo("patient-illness", "patient-illnesslist");
                            return true;
                        case "back":
                            this.GoTo("patients", "patientlist");
                            return true;
                    }
                    break;
                case "illness":
                    switch (command.StringInput)
                    {
                        case "edit":
                            this.GoTo("illness-edit", "illness-edit");
                            return true;
                        case "delete":
                            if (ConIO.Confirm("Delete Illness (" + this.DescribeIllness(this.CurrentIllness) + ")?"))
                            {
                                if (this.Fachkonzept.DeleteIllness(this.CurrentIllness))
                                {
                                    this.GoTo("illnesses", "illnesslist");
                                }
                                else
                                {
                                    ConIO.OutputError("ERROR: Can not delete Illness (" + this.DescribeIllness(this.CurrentIllness) + ")!");
                                }
                            }
                            return true;
                        case "patients":
                            this.GoTo("illness-patient", "illness-patientlist");
                            return true;
                        case "back":
                            this.GoTo("illnesses", "illnesslist");
                            return true;
                    }
                    break;
                case "patient-illness":
                    switch (command.StringInput)
                    {
                        case "add":
                            this.GoTo("patient-illness-add", "illnesslist");
                            return true;
                        case "remove":
                            this.GoTo("patient-illness-remove", "patient-illnesslist");
                            return true;
                        case "back":
                            this.GoTo("patient", "patient");
                            return true;
                    }
                    break;
                case "illness-patient":
                    switch (command.StringInput)
                    {
                        case "add":
                            this.GoTo("illness-patient-add", "patientlist");
                            return true;
                        case "remove":
                            this.GoTo("illness-patient-remove", "illness-patientlist");
                            return true;
                        case "back":
                            this.GoTo("illness", "illness");
                            return true;
                    }
                    break;
                case "patient-add":
                    switch (command.StringInput)
                    {
                        case "add":
                            this.CurrentPatient = new Patient();
                            ConIO input = null;

                            // set the FirstName field of the new patient
                            do
                            {
                                input = ConIO.Input("Patient First Name", "           : ");
                                if (this.CancelAddPatient(input.StringInput)) return true;
                            } while (input.StringInput.Length == 0);
                            this.CurrentPatient.FirstName = input.StringInput;

                            // set the LastName field of the new patient
                            do
                            {
                                input = ConIO.Input("Patient Last Name", "            : ");
                                if (this.CancelAddPatient(input.StringInput)) return true;
                            } while (input.StringInput.Length == 0);
                            this.CurrentPatient.LastName = input.StringInput;

                            // set the Birthday field of the new patient
                            bool isDate = false;
                            do
                            {
                                input = ConIO.Input("Patient Birthday (dd.mm.YYYY)");
                                if (this.CancelAddPatient(input.StringInput))
                                {
                                    isDate = false;
                                    break;
                                }
                                isDate = input.TestDate();
                                if (!isDate)
                                {
                                    ConIO.OutputNewLine();
                                    ConIO.OutputError("ERROR: Wrong date format!");
                                }
                            } while (!isDate);
                            if (isDate)
                            {
                                this.CurrentPatient.Birthday = input.DateInput;
                            }
                            else
                            {
                                return true;
                            }

                            // confirm the new patient from the user before save the patient
                            ConIO.OutputNewLine();
                            this.PrintMenuPage("patient-add", "patient");
                            ConIO.OutputNewLine();
                            if (ConIO.Confirm("Add the Patient?"))
                            {
                                if (!this.Fachkonzept.CreatePatient(this.CurrentPatient))
                                {
                                    ConIO.OutputError("ERROR: Can not create patient!");
                                    this.GoTo("patients", "patientlist");
                                    return true;
                                }
                            }
                            else
                            {
                                this.GoTo("patients", "patientlist");
                                return true;
                            }

                            this.GoTo("patient", "patient");
                            return true;
                    }
                    break;
                case "illness-add":
                    switch (command.StringInput)
                    {
                        case "add":
                            this.CurrentIllness = new Illness();
                            ConIO input = null;

                            // set the Name field of the new illness
                            do
                            {
                                input = ConIO.Input("Illness Name", "       : ");
                                if (this.CancelAddIllness(input.StringInput)) return true;
                            } while (input.StringInput.Length == 0);
                            this.CurrentIllness.Name = input.StringInput;

                            // set the Contagious field of the new illness
                            do
                            {
                                input = ConIO.Input("Is Contagious?(j/n)");
                            } while (!input.TestBool() && input.StringInput != "cancel");
                            if (this.CancelAddIllness(input.StringInput)) return true;
                            this.CurrentIllness.Contagious = input.BoolInput;

                            // set the Lethal field of the new illness
                            do
                            {
                                input = ConIO.Input("Is Lethal?(j/n)", "    : ");
                            } while (!input.TestBool() && input.StringInput != "cancel");
                            if (this.CancelAddIllness(input.StringInput)) return true;
                            this.CurrentIllness.Lethal = input.BoolInput;

                            // set the Curable field of the new illness
                            do
                            {
                                input = ConIO.Input("Is Curable?(j/n)", "   : ");
                            } while (!input.TestBool() && input.StringInput != "cancel");
                            if (this.CancelAddIllness(input.StringInput)) return true;
                            this.CurrentIllness.Curable = input.BoolInput;

                            // confirm the new illness from the user before save the illness
                            ConIO.OutputNewLine();
                            this.PrintMenuPage("illness-add", "illness");
                            ConIO.OutputNewLine();
                            if (ConIO.Confirm("Add the Illness?"))
                            {
                                if (!this.Fachkonzept.CreateIllness(this.CurrentIllness))
                                {
                                    ConIO.OutputError("ERROR: Can not create illness!");
                                    this.GoTo("illnesses", "illnesslist");
                                    return true;
                                }
                            }
                            else
                            {
                                this.GoTo("illnesses", "illnesslist");
                                return true;
                            }

                            this.GoTo("illness", "illness");
                            return true;
                    }
                    break;
                case "patient-edit":
                    switch (command.StringInput)
                    {
                        case "edit":
                            ConIO.OutputLine("Enter an empty text to not change the value!");
                            ConIO.OutputNewLine();
                            ConIO input = null;

                            // edit the FirstName field of the current patient
                            input = this.InputEditField(this.CurrentPatient.FirstName, "First name");
                            if (this.CancelEditPatient(input.StringInput)) return true;
                            if (input.StringInput.Length != 0) this.CurrentPatient.FirstName = input.StringInput;

                            // edit the LastName field of the current patient
                            input = this.InputEditField(this.CurrentPatient.LastName, "Last name ");
                            if (this.CancelEditPatient(input.StringInput)) return true;
                            if (input.StringInput.Length != 0) this.CurrentPatient.LastName = input.StringInput;

                            // edit the Birthday field of the current patient
                            bool isDate = false;
                            do
                            {
                                input = this.InputEditField(this.CurrentPatient.Birthday.ToShortDateString(), "Birthday  ");
                                if (this.CancelEditPatient(input.StringInput)) return true;
                                if (input.StringInput.Length == 0) break;
                                isDate = input.TestDate();
                                if (!isDate)
                                {
                                    ConIO.OutputNewLine();
                                    ConIO.OutputError("ERROR: Wrong date format");
                                }
                            } while (!isDate);
                            if (isDate) this.CurrentPatient.Birthday = input.DateInput;

                            // confirm the edit patient from the user before update the patient
                            ConIO.OutputNewLine();
                            this.PrintMenuPage("patient-edit", "patient");
                            ConIO.OutputNewLine();
                            if (ConIO.Confirm("Edit the Patient?"))
                            {
                                if (!this.Fachkonzept.UpdatePatient(this.CurrentPatient))
                                {
                                    ConIO.OutputError("ERROR: Can not update patient!");
                                    this.CurrentPatient = this.Fachkonzept.GetPatient(this.CurrentPatient.PatientID);
                                }
                            }
                            else
                            {
                                this.CurrentPatient = this.Fachkonzept.GetPatient(this.CurrentPatient.PatientID);
                            }

                            this.GoTo("patient", "patient");
                            return true;
                    }
                    break;
                case "illness-edit":
                    switch (command.StringInput)
                    {
                        case "edit":
                            ConIO.OutputLine("Enter an empty text to not change the value!");
                            ConIO.OutputNewLine();
                            ConIO input = null;

                            // edit the Name field of the current illness
                            input = this.InputEditField(this.CurrentIllness.Name, "Illness name       ");
                            if (this.CancelEditIllness(input.StringInput)) return true;
                            if (input.StringInput.Length != 0) this.CurrentIllness.Name = input.StringInput;

                            // edit the Contagious field of the current illness
                            do
                            {
                                input = this.InputEditField(this.CurrentIllness.Contagious.ToString(), "Is Contagious?(j/n)");
                            } while (!input.TestBool() && input.StringInput != "cancel" && input.StringInput.Length != 0);
                            if (this.CancelEditIllness(input.StringInput)) return true;
                            if (input.StringInput.Length != 0) this.CurrentIllness.Contagious = input.BoolInput;

                            // edit the Lethal field of the current illness
                            do
                            {
                                input = this.InputEditField(this.CurrentIllness.Lethal.ToString(), "Is Lethal?(j/n)    ");
                            } while (!input.TestBool() && input.StringInput != "cancel" && input.StringInput.Length != 0);
                            if (this.CancelEditIllness(input.StringInput)) return true;
                            if (input.StringInput.Length != 0) this.CurrentIllness.Lethal = input.BoolInput;

                            // edit the Curable field of the current illness
                            do
                            {
                                input = this.InputEditField(this.CurrentIllness.Curable.ToString(), "Is Curable?(j/n)   ");
                            } while (!input.TestBool() && input.StringInput != "cancel" && input.StringInput.Length != 0);
                            if (this.CancelEditIllness(input.StringInput)) return true;
                            if (input.StringInput.Length != 0) this.CurrentIllness.Curable = input.BoolInput;

                            // confirm the edit illness from the user before update the illness
                            ConIO.OutputNewLine();
                            this.PrintMenuPage("illness-edit", "illness");
                            ConIO.OutputNewLine();
                            if (ConIO.Confirm("Edit the Illness?"))
                            {
                                if (!this.Fachkonzept.UpdateIllness(this.CurrentIllness))
                                {
                                    ConIO.OutputError("ERROR: Can not update Illness!");
                                    this.CurrentIllness = this.Fachkonzept.GetIllness(this.CurrentIllness.IllnessID);
                                }
                            }
                            else
                            {
                                this.CurrentIllness = this.Fachkonzept.GetIllness(this.CurrentIllness.IllnessID);
                            }

                            this.GoTo("illness", "illness");
                            return true;
                    }
                    break;
                case "patient-illness-add":
                    switch (command.StringInput)
                    {
                        case "back":
                            this.GoTo("patient-illness", "patient-illnesslist");
                            return true;
                        default:
                            if (command.TestInt())
                            {
                                Illness illness = this.Fachkonzept.GetIllness(command.IntInput);
                                if (illness == null)
                                {
                                    ConIO.OutputError("ERROR: Can not load Illness!");
                                }
                                else
                                {
                                    // Confirm the link from illness to patient
                                    if (ConIO.Confirm("Add Illness to patient?"))
                                    {
                                        if (!this.Fachkonzept.LinkPatientIllness(this.CurrentPatient, illness))
                                        {
                                            ConIO.OutputError("ERROR: Can not link Illness to Patient!");
                                        }
                                    }
                                    this.GoTo("patient-illness", "patient-illnesslist");
                                }
                                return true;
                            }
                            break;
                    }
                    break;
                case "patient-illness-remove":
                    switch (command.StringInput)
                    {
                        case "back":
                            this.GoTo("patient-illness", "patient-illnesslist");
                            return true;
                        default:
                            if (command.TestInt())
                            {
                                Illness illness = this.Fachkonzept.GetIllness(command.IntInput);
                                if (illness == null)
                                {
                                    ConIO.OutputError("ERROR: Can not load Illness!");
                                }
                                else
                                {
                                    // Confirm the delink of illness from patient
                                    if (ConIO.Confirm("Remove Illness from Patient?"))
                                    {
                                        if (!this.Fachkonzept.UnLinkPatientIllness(this.CurrentPatient, illness))
                                        {
                                            ConIO.OutputError("ERROR: Can not delink Illness from Patient!");
                                        }
                                    }
                                    this.GoTo("patient-illness", "patient-illnesslist");
                                }
                                return true;
                            }
                            break;
                    }
                    break;
                case "illness-patient-add":
                    switch (command.StringInput)
                    {
                        case "back":
                            this.GoTo("illness-patient", "illness-patientlist");
                            return true;
                        default:
                            if (command.TestInt())
                            {
                                Patient patient = this.Fachkonzept.GetPatient(command.IntInput);
                                if (patient == null)
                                {
                                    ConIO.OutputError("ERROR: Can not load Patient!");
                                }
                                else
                                {
                                    // Confirm the link from patient to illness
                                    if (ConIO.Confirm("Add Patient to Illness?"))
                                    {
                                        if (!this.Fachkonzept.LinkPatientIllness(patient, this.CurrentIllness))
                                        {
                                            ConIO.OutputError("ERROR: Can not link Patient to Illness!");
                                        }
                                    }
                                    this.GoTo("illness-patient", "illness-patientlist");
                                }
                                return true;
                            }
                            break;
                    }
                    break;
                case "illness-patient-remove":
                    switch (command.StringInput)
                    {
                        case "back":
                            this.GoTo("illness-patient", "illness-patientlist");
                            return true;
                        default:
                            if (command.TestInt())
                            {
                                Patient patient = this.Fachkonzept.GetPatient(command.IntInput);
                                if (patient == null)
                                {
                                    ConIO.OutputError("ERROR: Can not load Patient!");
                                }
                                else
                                {
                                    // Confirm the delink of Patient from Illness
                                    if (ConIO.Confirm("Remove Patient from Illness?"))
                                    {
                                        if (!this.Fachkonzept.UnLinkPatientIllness(patient, this.CurrentIllness))
                                        {
                                            ConIO.OutputError("ERROR: Can not delink Patient from Illness!");
                                        }
                                    }
                                    this.GoTo("illness-patient", "illness-patientlist");
                                }
                                return true;
                            }
                            break;
                    }
                    break;
            }
            return false;
        }

        public ConIO InputEditField(string current, string description)
        {
            return ConIO.Input(description + " : " + current, " > ");
        }



        /*
         * Execute commands that depends on page
         * Return true if the command was found
         */
        public bool PageCommand(ConIO command)
        {
            switch (this.CurrentPage)
            {
                case "patientlist":
                    switch (command.StringInput)
                    {
                        case "next":
                            if (this.CurrentPager < this.GetMaxPager(this.Fachkonzept.GetPatientsCount()))
                            {
                                this.CurrentPager++;
                            }
                            return true;
                        case "prev":
                            if (this.CurrentPager > 0)
                            {
                                this.CurrentPager--;
                            }
                            return true;
                    }
                    break;
                case "illnesslist":
                    switch (command.StringInput)
                    {
                        case "next":
                            if (this.CurrentPager < this.GetMaxPager(this.Fachkonzept.GetIllnessesCount()))
                            {
                                this.CurrentPager++;
                            }
                            return true;
                        case "prev":
                            if (this.CurrentPager > 0)
                            {
                                this.CurrentPager--;
                            }
                            return true;
                    }
                    break;
                case "illness-patientlist":
                    switch (command.StringInput)
                    {
                        case "next":
                            if (this.CurrentPager < this.GetMaxPager(this.Fachkonzept.GetIllnessPatientsCount(this.CurrentIllness)))
                            {
                                this.CurrentPager++;
                            }
                            return true;
                        case "prev":
                            if (this.CurrentPager > 0)
                            {
                                this.CurrentPager--;
                            }
                            return true;
                    }
                    break;
                case "patient-illnesslist":
                    switch (command.StringInput)
                    {
                        case "next":
                            if (this.CurrentPager < this.GetMaxPager(this.Fachkonzept.GetPatientIllnessesCount(this.CurrentPatient)))
                            {
                                this.CurrentPager++;
                            }
                            return true;
                        case "prev":
                            if (this.CurrentPager > 0)
                            {
                                this.CurrentPager--;
                            }
                            return true;
                    }
                    break;
            }
            return false;
        }

        /*
         * Describe a Patient Row
         */
        public string DescribePatientRow(Patient patient)
        {
            return patient.FirstName + " " + patient.LastName + " : " + patient.Birthday.ToShortDateString();
        }

        /*
         * Describe a Illness Row
         */
        public string DescribeIllnessRow(Illness illness)
        {
            string row = illness.Name;
            if (illness.Contagious)
            {
                row += " : Contagious";
            }
            if (illness.Curable)
            {
                row += " : Curable";
            }
            if (illness.Lethal)
            {
                row += " : Lethal";
            }
            return row;
        }

        /*
         * Describe a Patient short
         */
        public string DescribePatient(Patient patient)
        {
            return patient.FirstName + " " + patient.LastName;
        }

        /*
         * Describe a Illness Short
         */
        public string DescribeIllness(Illness illness)
        {
            return illness.Name;
        }

    }
}
