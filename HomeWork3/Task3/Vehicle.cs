using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vehicle
    {
        protected readonly int nPosition;
        protected readonly int sPosition;
        protected readonly double price;
        protected readonly uint speed;
        protected readonly int year;

        public int NPosition { get { return nPosition; } }
        public int SPosition { get { return sPosition; } }
        public double Price { get { return price; } }
        public uint Speed { get { return speed; } }
        public int Year { get { return year; } }

        public Vehicle(int nPosition, int sPosition, double price, uint speed, int year)
        {
            this.nPosition = nPosition;
            this.sPosition = sPosition;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public Vehicle (double price, uint speed, int year)
        :this (0,0, price, speed, year)
        {

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"North position: {nPosition}\nSouthPosition: {sPosition}\nPrice: {price}\nSpeed: {speed}\nYear: {year}");
        }
        

    }
}
