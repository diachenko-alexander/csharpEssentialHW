using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task4
{
    static class Helpers
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var resultArray = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                resultArray[i] = list[i];
            }
            return resultArray;

        }
    }
    
    class Program
    {
        

        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Add(1, 2, 3, 4, 5);
            var array = list.GetArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
