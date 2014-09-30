using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Menu
    {

        private static int Start = (int)'A';

        public static char GetChar(int number)
        {
            return (char)(Menu.Start + number);
        }

        public static int GetCode(char item)
        {
            return (int)item - Menu.Start;
        }

        public static bool MenuCommand(ConIO command)
        {
            return false;
        }

    }
}
