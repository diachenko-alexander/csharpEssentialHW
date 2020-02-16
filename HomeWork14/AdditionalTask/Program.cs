using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        public static IEnumerable GetAllEven (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    yield return array[i];
                }
                
            }
        }
       
            

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            IEnumerable allEven = GetAllEven(array);

            foreach (int item in allEven)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
