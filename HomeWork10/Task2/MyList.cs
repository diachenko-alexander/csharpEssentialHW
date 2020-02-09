using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyList <T> : IMyList<T>
    {
        private T[] array;

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

        public int Count { get { return array.Length; } }

        public void Add (params  T[] a)
        {
            T[] tempArray = new T[array.Length + a.Length];
            array.CopyTo(tempArray, 0);

            for (int i = array.Length, j = 0; i < tempArray.Length; i++, j++)
            {
                tempArray[i] = a[j];
            }

            array = tempArray;
        }

        public void Reverse()
        {
            T[] tempArray = new T[array.Length];
            
            for (int i = tempArray.Length-1, j = 0; i >= 0; i--, j++)
            {
                tempArray[j] = array[i];
            }

            array = tempArray;
        }

        public void Clear()
        {
            array = new T[0];
        }
    }
}
