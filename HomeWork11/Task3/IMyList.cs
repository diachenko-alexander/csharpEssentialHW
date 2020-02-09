using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface IMyList<T>
    {
        void Add(T a);

        void Clear();

        T this [int index] {get;}

        int Count { get; }

    }
}
