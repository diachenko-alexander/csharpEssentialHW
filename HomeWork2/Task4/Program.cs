using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "serg", "rosetka");
            invoice.Article = "mouse";
            invoice.Quantity = 1;
            Console.WriteLine($"With nds: {invoice.CalculateInvoice(true)}");
            Console.WriteLine($"Without nds: {invoice.CalculateInvoice(false)}");
            Console.ReadLine();
            
        }
    }
}
