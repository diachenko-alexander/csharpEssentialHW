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
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("book", "книга");
            dictionary.Add("box", "коробка");

            Console.WriteLine(dictionary[1]);

            for (int i = 0; i < dictionary.Lenght; i++)
            {
                Console.WriteLine(dictionary[i]);
            }


        }
    }
}
