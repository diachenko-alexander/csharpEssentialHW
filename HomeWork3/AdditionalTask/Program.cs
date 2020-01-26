using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer2 printerGreen = new Printer2(ConsoleColor.Green);
            printerGreen.Print("print2");

            Printer2 printerRed = new Printer2(ConsoleColor.Red);
            printerRed.Print("printDown");

            Printer prinBase = printerGreen;
            

            


            Console.ReadKey();
        }
    }
}
