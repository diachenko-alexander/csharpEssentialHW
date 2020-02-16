using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Workers
    {
        Worker[] workers;

        public Workers()
        {
            workers = new Worker[0];
        }

        public void Add (Worker worker)
        {
            Worker[] tempWorkers = new Worker[workers.Length + 1];
            workers.CopyTo(tempWorkers, 0);
            tempWorkers[workers.Length] = worker;
            workers = tempWorkers;
            SortWorkersByName();
        }

        public string this[int index]
        {
            get 
            {
                string result = "";
                for (int i = 0; i < workers.Length; i++)
                {
                    if(workers[i].GetYearInCompany() > index)
                    {
                        result += workers[i].Surname + " " + workers[i].Position + " " + workers[i].GetYearInCompany() + "\n";
                    }
                }
                if (result.Length > 0)
                {
                    return result;
                }
                else return "No workers with such experience in company";
            }
            
        }

        public void AddByConsole()
        {
            Console.Write("Enter workers count:");
            string userInputCount = Console.ReadLine();
            int workersCount;

            try
            {
                workersCount = Convert.ToInt32(userInputCount);
            }
            catch (Exception)
            {
                Console.WriteLine("Not valid number, workers count is set to 1");
                workersCount = 1;
            }

            for (int i = 0; i < workersCount; i++)
            {
                int year;
                Console.Write("Enter surname:");
                string surname = Console.ReadLine();

                Console.Write("Enter position:");
                string position = Console.ReadLine();

                Console.Write("Enter year:");
                string userInput = Console.ReadLine();
                try
                {
                   year = Convert.ToInt32(userInput);
                }
                catch (Exception)
                {
                    Console.WriteLine($"You entered not valid year, year is set to {DateTime.Now.Year}");
                    year = DateTime.Now.Year;
                }

                Worker worker = new Worker(surname, position, year);
                Add(worker);
            }
            
        }

        private void SortWorkersByName()
        {
            workers = workers.OrderBy(worker => worker.Surname).ToArray<Worker>();
        }
    }
}
