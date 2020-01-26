using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Plane : Vehicle
    {
        readonly uint height;
        readonly uint passengers;


        public uint Height { get { return height; }  }

        public uint Passengers { get {return passengers; } }

        public Plane(int nPosition, int sPosition, double price, uint speed, int year)
            :base (nPosition, sPosition, price, speed, year)
        {

        }

        public Plane(double price, uint speed, int year)
            :base (price, speed, year)
        {
                
        }

        public Plane(int nPosition, int sPosition, double price, uint speed, int year, uint height)
            :base (nPosition, sPosition, price, speed, year)
        {
            this.height = height;
        }

        public Plane(int nPosition, int sPosition, double price, uint speed, int year, uint height, uint passengers)
            : base(nPosition, sPosition, price, speed, year)
        {
            this.height = height;
            this.passengers = passengers;
        }

        public Plane(double price, uint speed, int year, uint height)
            : base(price, speed, year)
        {
            this.height = height;
        }

       
        public override void ShowInfo()
        {
            Console.WriteLine($"North position: {nPosition}\nSouthPosition: {sPosition}\nPrice: {price}\nSpeed: {speed}\nYear: {year}\nHeight: {height}\nPassengers: {passengers}");
        }
    }
}
