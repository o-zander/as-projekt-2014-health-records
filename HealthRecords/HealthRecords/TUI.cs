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
            System.Console.ReadLine();
        }
    }
}
