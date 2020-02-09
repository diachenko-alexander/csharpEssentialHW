using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyCarCollection<T> : IMyCarCollection<T> where T : class
    {
        private T [] collection;

        public MyCarCollection()
        {
            collection = new T[0];
        }

        public string this [int index]
        {
            get
            {
                if (index < 0 || index > collection.Length)
                {
                    return "Index out of boundary values";
                }
                return collection[index].ToString();
            }
        }

        public int Count { get { return collection.Length; } }

        public void Add (params T [] a)
        {
            T[] tempCollection = new T[collection.Length + a.Length];
            collection.CopyTo(tempCollection, 0);
            for (int i = collection.Length, j = 0; i < tempCollection.Length; i++, j++)
            {
                tempCollection[i] = a[j];
            }

            collection = tempCollection;
        }

        public void Clear()
        {
            collection = new T[0];
        }
    }
}
