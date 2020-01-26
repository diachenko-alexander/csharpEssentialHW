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
            int[] array = new int[4];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.WriteLine(array[i]);
            }

            int maxValue = array.Max();
            int minValue = array.Min();
            int summ = 0;
            int averageValue = summ / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }

            Console.WriteLine($"MAX Value: {maxValue}\nMIN Value: {minValue}\nSUMM: {summ}\nAverage: {averageValue}\n");
            Console.Write("Not even numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
