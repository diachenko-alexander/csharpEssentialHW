using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static class Helper
        {
            public static void Print (string message, int color)
            {
                switch (color)
                {
                    case (int)Colors.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case (int)Colors.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case (int)Colors.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                }
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        enum Colors
        {
            Red,
            Green,
            Blue,
        }

        static void Main(string[] args)
        {
            Helper.Print("Text", 0);
            Helper.Print("Text", 1);
            Helper.Print("Text", 2);
        }
    }
}
