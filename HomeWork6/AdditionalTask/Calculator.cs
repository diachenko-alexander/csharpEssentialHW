using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    static class Calculator
    {
        public static double Add (double a, double b)
        {
            return a + b;
        }

        public static double Subt (double a, double b)
        {
            return a - b;
        }

        public static double Mult (double a, double b)
        {
            return a * b;
        }

        public static double Div (double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cant divide by zero");
                return 0;
            }
            return a / b;
        }
    }
}
