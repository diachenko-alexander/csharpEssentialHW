using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    public delegate double MyDelegate(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate avg = delegate (int a, int b, int c) { return (a + b + c) / 3; };
            Console.WriteLine(avg (2,2,2));
        }
    }
}
