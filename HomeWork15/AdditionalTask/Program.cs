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
            Console.WriteLine("Calculator");
            Console.Write("Enter first operand: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter operation: ");
            string operation = Console.ReadLine();

            Console.Write("Enter second operand: ");
            int b = int.Parse(Console.ReadLine());

            int? result = 0;

            Calculator calculator = new Calculator();

            switch (operation)
            {
                case "+":
                    result = calculator.Add(a, b);
                    break;
                case "-":
                    result = calculator.Subt(a, b);
                    break;
                case "*":
                    result = calculator.Mult(a, b);
                    break;
                case "/":
                    result = calculator.Div(a, b);
                    break;
                default:
                    Console.WriteLine("No such operation");
                    break;
            }
            Console.WriteLine($"Result is: {result}");


        }
    }
}
