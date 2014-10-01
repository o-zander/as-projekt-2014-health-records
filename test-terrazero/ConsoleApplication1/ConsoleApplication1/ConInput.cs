﻿using System;
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
            return new ConIO(Console.ReadLine());
        }

        public static ConIO Input(string description)
        {
            ConIO.Output(description + ": ");
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

    }
}
