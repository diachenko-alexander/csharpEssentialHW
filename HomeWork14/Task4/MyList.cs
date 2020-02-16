using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyList <T> : IEnumerable<T>
    {
        T [] array = null;
        int position = -1;

        public MyList()
        {
            array = new T[0];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public int Count { get { return array.Length; } }

        public void Add(T a)
        {
            T[] tempArray = new T[array.Length + 1];
            array.CopyTo(tempArray, 0);
            tempArray[array.Length] = a;
            array = tempArray;
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator<T> GetEnumerator ()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position]; 
                } else
                {
                    Reset();
                    yield break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
