using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter side1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter side2: ");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine($"Area is: {rect.Area}");
            Console.WriteLine($"Perimetr is: {rect.Perimeter}");

            Console.ReadLine();

        }
    }
}
