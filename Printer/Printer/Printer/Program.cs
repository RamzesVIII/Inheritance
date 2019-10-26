using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterHP firstprinter = new PrinterHP();
            firstprinter.Print("Hello world.");
            Console.WriteLine(new string ('-',20));

            Printer secondprinter = firstprinter as Printer;
            secondprinter.Print("Hello world.");
            Console.WriteLine(new string('-', 20));

            PrinterCanon therdprinter = new PrinterCanon();
            therdprinter.Print("Hello world");
            Console.WriteLine(new string('-', 20));

            Printer baseprinter = therdprinter;
            baseprinter.Print("Hello world.");
        }
    }
}
