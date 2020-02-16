using System;

namespace AdditionalTask
{
    class Calculator
    {
        public int Add (int a, int b)
        {
            return a + b;
        }

        public int Subt(int a, int b)
        {
            return a - b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int? Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something wrong has hapened");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
