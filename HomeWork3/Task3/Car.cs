using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Car : Vehicle
    {
        public Car(int nPosition, int sPosition, double price, uint speed, int year)
       :base (nPosition, sPosition, price, speed, year)
        {
           
        }

        public Car (double price, uint speed, int year)
            :base (0, 0, price, speed, year) 
        {

        }
        
    }
}
