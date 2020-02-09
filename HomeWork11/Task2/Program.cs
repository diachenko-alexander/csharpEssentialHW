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
            MyCar<string, DateTime> bmwX5 = new MyCar<string, DateTime>("BMW X5", new DateTime (2015,01,05));
            MyCar<string, DateTime> audiQ7 = new MyCar<string, DateTime>("Audi Q7", new DateTime(2019,01,06));
            MyCar<string, DateTime> fordFocus = new MyCar<string, DateTime>("Ford focus", new DateTime(2018,05,06));

            MyCarCollection<MyCar<string, DateTime>> myCarCollection = new MyCarCollection<MyCar<string, DateTime>>();
            myCarCollection.Add(bmwX5, audiQ7);
            Console.WriteLine(myCarCollection[0]);

            myCarCollection.Add(fordFocus);

            for (int i = 0; i < myCarCollection.Count; i++)
            {
                Console.WriteLine(myCarCollection[i]);
            }

            myCarCollection.Clear();
            Console.WriteLine(myCarCollection.Count);

            Console.ReadLine();
        }
    }
}
