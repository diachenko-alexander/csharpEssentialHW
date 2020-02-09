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
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("table", "стол");
            dictionary.Add("apple", "яблоко");

            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary["apple"]);
            Console.WriteLine(dictionary["qwe"]);

            dictionary.Clear();
            Console.WriteLine(dictionary.Count);
        }
    }
}
