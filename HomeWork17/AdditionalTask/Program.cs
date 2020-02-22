using System;

namespace AdditionalTask
{
    static class Calculator
    {
        public static dynamic Add (dynamic a, dynamic b)
        {
            return a + b;
        }

        public static dynamic Sub (dynamic a, dynamic b)
        {
            return a - b;
        }

        public static dynamic Mul(dynamic a, dynamic b)
        {
            return a * b;
        }

        public static dynamic Div (dynamic a, dynamic b)
        {
           try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(2,2));
            Console.WriteLine(Calculator.Sub(10,2));
            Console.WriteLine(Calculator.Mul(3,3));
            Console.WriteLine(Calculator.Div(10,2));
            Console.WriteLine(Calculator.Div(10, 0));

        }
    }
}
