using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyList<T> : IMyList<T>
    {
        private T [] array;

        public int Count { get { return array.Length; } }

        public T this [int index]
        {
            get
            {
                return array[index];
            }
        }

        public MyList()
        {
            array = new T[0];
        }

        public void Add (T a)
        {
            T[] tempArray = new T[array.Length + 1];
            array.CopyTo(tempArray, 0);
            tempArray[array.Length] = a;
            array = tempArray;
        }

        public void Clear()
        {
            array = new T[0];
        }

        //public override string ToString()
        //{
        //    return arrayToString();
        //}

    }
}
