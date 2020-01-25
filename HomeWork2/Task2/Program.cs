using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter USD: ");
            double usd = double.Parse(Console.ReadLine());

            Console.Write("Please enter EUR: ");
            double eur = double.Parse(Console.ReadLine());

            Console.Write("Please enter RUB: ");
            double rub = double.Parse(Console.ReadLine());

            Console.Write("Please enter Ammount: ");
            double ammount = double.Parse(Console.ReadLine());

            Console.Write("Please enter currency to convert: ");
            string currency = Console.ReadLine();

            Converter conv = new Converter(usd, eur, rub);

            Console.Write("Please enter Operation\n1. TO GRN\n2. FROM GRN\n");
            int operation = int.Parse(Console.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine(conv.ConvertToGrn(ammount, currency));
            }
            else if (operation == 2)
            {
                Console.WriteLine(conv.ConvertGrnTo(ammount, currency));
            }

        }
    }
}
