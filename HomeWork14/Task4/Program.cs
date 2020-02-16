using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class Helpers
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];

            int i = 0;
            foreach (var element in list)
            {
                array[i++] = element;
            }

            return array;
        }
    }
    class Program
    {     

        static void Main(string[] args)
        {
            MyList<string> myStringList = new MyList<string>();
            myStringList.Add("Test");
            myStringList.Add("Alex");
            myStringList.Add("C#");

            string[] arr = myStringList.GetArray();

            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }

        }
    }
}
