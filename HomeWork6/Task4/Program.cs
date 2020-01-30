using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 4, 3, 2 };
            ExtensionMethods.SortArray(array);
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
