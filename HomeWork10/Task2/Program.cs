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
            MyList<int> list = new MyList<int>();

            list.Add(1, 2, 3, 4, 5);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine(list[2]);

            list.Clear();
            Console.WriteLine(list.Count);
           
        }
    }
}
