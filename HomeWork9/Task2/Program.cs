using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        delegate double MyDelegate(double a, double b);
        static void Main(string[] args)
        {
            MyDelegate add = (a, b) => { return a + b; }; ;
            Console.WriteLine(add(2,2));

            MyDelegate sub = (a, b) => { return a - b; }; 
            Console.WriteLine(sub(4,2));

            MyDelegate mul = (a, b) => { return a * b; };
            Console.WriteLine(mul(2,2));

            MyDelegate div = (a, b) => { return b == 0 ? 0 : a / b; };
            Console.WriteLine(div(4,2));

        }
    }
}
