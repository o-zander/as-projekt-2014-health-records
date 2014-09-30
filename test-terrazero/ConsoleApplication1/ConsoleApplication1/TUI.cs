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
        }

        public void run()
        {
            while (true)
            {
                ConIO command = ConIO.Input("Input");
                this.Command(command);
            }
        }

        public void Command(ConIO command) 
        {
            if (this.SimpleCommand(command)) return;
            if (Menu.MenuCommand(command)) return;
            ConIO.OutputLine("Befehl '" + command.StringInput + "' konnte nicht gefunden werden.");
        }

        public bool SimpleCommand(ConIO command)
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

    }
}
