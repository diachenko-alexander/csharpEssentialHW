using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyArrayList
    {
        private object[] array;

        public MyArrayList()
        {
            array = new object[0];
        }

        

        public int Count { get { return array.Length; } }

        public object this [int index]
        {
            get
            {
                return array[index];
            }

            
        }

        public void Add(params object[] a)
        {
            object[] tempArray = new object[array.Length + a.Length];
            array.CopyTo(tempArray, 0);
            for (int i = array.Length, j = 0; i < tempArray.Length; i++, j++)
            {
                tempArray[i] = a[j];
            }

            array = tempArray;
        }
        
        public void Clear()
        {
            array = new object[0];
        }

        
    }
}
