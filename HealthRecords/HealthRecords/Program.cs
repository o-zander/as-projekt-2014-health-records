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
                GUI newGUI = new GUI(new Fachkonzept(new DatenhaltungDB()));
                break;
            case "TUI":
                TUI newTUI = new TUI(new Fachkonzept(new DatenhaltungDB()));
                break;
            default:
                throw new Exception("Es konnte kein Benutzerschnittstelle gefunden werden.");                
        }

    }
  }
}
