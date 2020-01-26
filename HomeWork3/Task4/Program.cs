using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter key:");
            string key = Console.ReadLine();

            DocumentWorker document = null;

            switch (key.ToLower())
            {
                case "pro":
                    document = new ProDocumentWorker();
                    break;
                case "exp":
                    document = new ExpertDocumentWorker();
                    break;
                default:
                    document = new DocumentWorker();
                    break;
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            Console.ReadKey();

        }
    }
}
