using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IMyList<T>
    {
        
        T this [int index ] { get;}

        int Count { get; }
                
        void Add(params T[] a);

        void Reverse();

        void Clear();


    }
}
