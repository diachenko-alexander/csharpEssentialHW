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
            MyList<string> myStringList = new MyList<string>();
            myStringList.Add("Test");
            myStringList.Add("Alex");
            myStringList.Add("C#");

            Console.WriteLine(myStringList.Count);

            foreach (var element in myStringList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
