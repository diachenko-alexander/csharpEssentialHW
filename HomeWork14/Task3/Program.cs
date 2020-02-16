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
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("testKey", "testValue");
            myDictionary.Add("testKey2", "testValue2");

            foreach(var element in myDictionary)
            {
                Console.WriteLine(element);
            }

            foreach (var element in myDictionary)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(myDictionary[1]);
        }
    }
}
