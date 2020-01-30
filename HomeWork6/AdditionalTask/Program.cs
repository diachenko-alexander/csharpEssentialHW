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
            var add = Calculator.Add(2, 2);
            Console.WriteLine(add);
            
            var subb = Calculator.Subt(4, 2);
            Console.WriteLine(subb);

            var mult = Calculator.Mult(2, 2);
            Console.WriteLine(mult);

            var div = Calculator.Div(4, 2);
            Console.WriteLine(div);

            Console.ReadKey();
        }
    }
}
