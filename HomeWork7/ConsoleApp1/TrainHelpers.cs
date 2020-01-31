using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class TrainHelpers
    {
        public static void SortTrains (Train [] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j].Number > array[j + 1].Number)
                    {
                        Train temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
        }

        public static void ShowTrainByNumber (int number, Train [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i].Number)
                {
                    Console.WriteLine($"Number: {array[i].Number} Station: {array[i].Station} Time: {array[i].Time}");
                    break;
                }
            } 
        }

        public static void AddTrainsToArray (ref Train [] existingArray, params Train [] array)
        {
            Train [] newArray = new Train[existingArray.Length + array.Length];
            existingArray.CopyTo(newArray, 0);

            for (int i = existingArray.Length, j = 0; j < array.Length; i++, j++)
            {
                newArray[i] = array[j];
            }

            existingArray = newArray;

        }
        

    }
}
