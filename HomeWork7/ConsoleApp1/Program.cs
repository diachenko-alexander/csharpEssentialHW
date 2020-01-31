using System;

namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[0]; 
            Train train1 = new Train("Fastov", 1, DateTime.Now.AddDays(1));
            Train train2 = new Train("Kiev", 2, DateTime.Now.AddDays(2));
            TrainHelpers.AddTrainsToArray(ref trains, train2);
            
            Train train3 = new Train("Lvov", 3, DateTime.Now.AddDays(3));
            Train train4 = new Train("Odessa", 4, DateTime.Now.AddDays(4));
            TrainHelpers.AddTrainsToArray(ref trains, train4, train3, train1);
            
            TrainHelpers.SortTrains(trains);

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine(trains[i].Number);
            }

            TrainHelpers.ShowTrainByNumber(2, trains);

        }
    }
}
