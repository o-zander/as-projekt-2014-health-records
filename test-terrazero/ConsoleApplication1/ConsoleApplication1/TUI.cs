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
                this.PrePage();
                this.Page();
                ConIO command = ConIO.Input("Input");
                this.Command(command);
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
            this.PrintMenuPage();
        }

        public void Command(ConIO command) 
        {
            if (this.CommandCommand(command)) return;
            if (this.MenuCommand(command)) return;
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

        private string CurrentMenu { get; set; }
        private int CurrentPager { get; set; }
        private int Number { get; set; }

        public void PrintMenu()
        {
            ConIO.OutputNewLine();
            int number = 0;
            switch (this.CurrentMenu)
            {
                case "root":
                    ConIO.OutputLine("Menu: Root");
                    ConIO.OutputNewLine();
                    this.PrintItem("Show Patients", number++);
                    this.PrintItem("Show Illnesses", number++);
                    break;
                case "patients":
                    ConIO.OutputLine("Menu: Patients");
                    ConIO.OutputNewLine();
                    this.PrintItem("Show Next Page", number++);
                    this.PrintItem("Show Previous Page", number++);
                    this.PrintItem("Show Patient");
                    this.PrintItem("Go Back", number++);
                    break;
                case "illnesses":
                    ConIO.OutputLine("Menu: Illnesses");
                    break;
                case "patient":
                    ConIO.OutputLine("Menu: Patient");
                    break;
                case "illness":
                    ConIO.OutputLine("Menu: Illness");
                    break;
            }
        }

        public void PrintMenuPage()
        {
            switch (this.CurrentMenu)
            {
                case "patients" :
                    // TODO die maximale page anzahl 
                    ConIO.OutputLine("Page " + (this.CurrentPager + 1) + " / " + "5");
                    Patient[] patients = this.Fachkonzept.GetPatients(this.CurrentPager, this.Number);
                    for (int i = 0; i < patients.Length; i++)
                    {
                        ConIO.OutputLine(patients[i].ToString());
                    }
                    ConIO.OutputNewLine();
                    break;
            }
        }

        public void PrintItem(string item)
        {
            ConIO.OutputLine(item + " ( ### )");
        }

        private void PrintItem(string item, int number)
        {
            ConIO.OutputLine(item + " ( " + Menu.GetChar(number) + " )");
        }

        public bool MenuCommand(ConIO command)
        {
            switch (this.CurrentMenu)
            {
                case "root":
                    if (command.TestChar())
                    {
                        switch (command.CharInput)
                        {
                            case 'A':
                                this.CurrentMenu = "patients";
                                this.CurrentPager = 0;
                                return true;
                            case 'B':
                                this.CurrentMenu = "illnesses";
                                this.CurrentPager = 0;
                                return true;
                        }
                    }
                    break;
                case "patients":
                    if (command.TestInt())
                    {
                        ConIO.OutputLine("TODO Implemate");
                    }
                    break;
                case "illnesses":

                    break;
                case "patient":

                    break;
                case "illness":

                    break;
            }
            return false;
        }

    }
}
