using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Articles articles = new Articles();
            articles.AddByConsole();
            Console.WriteLine(articles["1"]);
        }
    }
}
