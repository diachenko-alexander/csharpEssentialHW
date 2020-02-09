using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyCar<T, D>
    {
        public T CarName { get; set; }

        public D Year { get; set; }

        public MyCar(T name, D year)
        {
            CarName = name;
            Year = year;
        }

        public override string ToString()
        {
            return CarName + " " + Year;
        }


    }
}
