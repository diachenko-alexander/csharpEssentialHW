using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(20, 40, 1000000, 250, 2020);
            car.ShowInfo();

            Vehicle plane = new Plane(30, 50, 10000000, 900, 2019, 10000, 100);
            plane.ShowInfo();

            Vehicle ship = new Ship(35, 35, 50000000, 80, 2015, "Madagaskar", 150);
            ship.ShowInfo();

            Console.ReadKey();
        }
    }
}
