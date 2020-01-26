using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Ship : Vehicle
    {
        readonly string port;
        readonly uint passengers;
        
        public uint Passengers { get {return passengers; }  }

        public string Port { get { return port; } }

        public Ship(int nPosition, int sPosition, double price, uint speed, int year)
            :base (nPosition, sPosition, price, speed, year)
        {

        }

        public Ship(double price, uint speed, int year)
            :base (0, 0, price, speed, year)
        {

        }

        public Ship(int nPosition, int sPosition, double price, uint speed, int year, string port)
            :base (nPosition, sPosition, price, speed, year)
        {
            this.port = port;
        }

        public Ship(int nPosition, int sPosition, double price, uint speed, int year, string port, uint passengers)
            : base(nPosition, sPosition, price, speed, year)
        {
            this.port = port;
            this.passengers = passengers;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"North position: {nPosition}\nSouthPosition: {sPosition}\nPrice: {price}\nSpeed: {speed}\nYear: {year}\nPort: {port}\nPassengers: {passengers}");
        }
    }
}
