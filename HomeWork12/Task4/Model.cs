using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Model
    {
        public double Add (double a, double b)
        {
            return a + b;
        }

        public double Subtract (double a, double b)
        {
            return a - b;
        }

        public double Multiply (double a, double b)
        {
            return a * b;
        }

        public double Division (double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }

            return a / b;
        }
    }
}
