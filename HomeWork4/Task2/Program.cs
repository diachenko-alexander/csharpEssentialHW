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
            Console.Write("Enter document format:");
            string documentFormat = Console.ReadLine().ToLower();

            AbstractHandler document = null;

            switch (documentFormat)
            {
                case "doc":
                    document = new TXTHandler();
                    break;
                case "txt":
                    document = new TXTHandler();
                    break;
                case "xml":
                    document = new XMLHandler();
                    break;
                default:
                    Console.WriteLine("Unknown format");
                    break;

            }

            document.Open();
            document.Create();
            document.Change();
            document.Save();
        }

        
    }
}
