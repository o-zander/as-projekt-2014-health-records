using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthRecords
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            switch (Properties.Settings.Default.UI)
            {
                case "GUI":
                    //GUI newGUI = new GUI(new Fachkonzept(new DatenhaltungXML()));
                    GUI newGUI = new GUI(new Fachkonzept(new SQLiteDatenhaltung()));
                    break;
                case "TUI":
                    //TUI newTUI = new TUI(new Fachkonzept(new DatenhaltungXML()));
                    TUI newTUI = new TUI(new Fachkonzept(new SQLiteDatenhaltung()));
                    break;
                default:
                    throw new Exception("Es konnte kein Benutzerschnittstelle gefunden werden.");
            }

        }
    }
}
