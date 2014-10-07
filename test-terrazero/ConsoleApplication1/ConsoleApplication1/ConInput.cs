using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ConIO
    {

        private string stringInput;
        public string StringInput { 
            set {
                this.stringInput = value;
            } 
            get {
                return this.stringInput;
            } 
        }

        public int IntInput { get; set; }
        public char CharInput { get; set; }
        public bool BoolInput { get; set; }
        public DateTime DateInput { get; set; }

        public ConIO(string input)
        {
            this.StringInput = input;
        }

        public bool TestInt()
        {
            try
            {
                this.IntInput = Convert.ToInt32(this.StringInput);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool TestBool()
        {
            if (this.stringInput == "j" || this.stringInput == "true" || this.stringInput == "y" || this.stringInput == "yes")
            {
                this.BoolInput = true;
            }
            else if (this.stringInput == "n" || this.stringInput == "false" || this.stringInput == "no")
            {
                this.BoolInput = false;
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool TestDate()
        {
            try
            {
                this.DateInput = Convert.ToDateTime(this.stringInput);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TestChar()
        {
            if (this.StringInput.Length == 1)
            {
                this.CharInput = this.StringInput.ToUpper()[0];
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ConIO Input()
        {
            return ConIO.Input("", "");
        }

        public static ConIO Input(string description)
        {
            return ConIO.Input(description, ": ");
        }

        public static ConIO Input(string description, string seperator)
        {
            ConIO.Output(description + seperator);
            return new ConIO(Console.ReadLine());
        }

        public static void Output(string text)
        {
            Console.Write(text);
        }

        public static void OutputLine(string text)
        {
            Console.WriteLine(text);
        }

        public static void OutputNewLine()
        {
            Console.WriteLine();
        }

        public static void OutputError(string text)
        {
            ConIO.OutputLine(text);
            ConIO.Input("Confirm with enter");
            ConIO.OutputNewLine();
        }

        public static bool Confirm(string message)
        {
            ConIO confirm = null;
            do
            {
                ConIO.OutputLine(message);
                confirm = ConIO.Input("Confirm with (j/n)");
                ConIO.OutputNewLine();
            } while (!confirm.TestBool());
            return confirm.BoolInput;
        }

    }
}
