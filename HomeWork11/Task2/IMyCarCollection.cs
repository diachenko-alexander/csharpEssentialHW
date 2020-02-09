using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IMyCarCollection<T>
    {
        string this [int index] { get; }

        int Count { get; }

        void Add(T [] a);

        void Clear();

    }
}
