using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<T, V> : IEnumerable<object>, IEnumerator<object>
    {
        T[] key = null;
        V[] value = null;

        int position = -1;

        public MyDictionary()
        {
            key = new T[0];
            value = new V[0];
        }

        public int Count { get { return key.Length; } }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index > key.Length - 1)
                {
                    return "Index out of bounary values";
                }
                return key[index] + "---" + value[index];
            }
        }

        public object Current { get { return key[position] + "---" + value[position]; } }

        public bool MoveNext()
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Add(T k, V v)
        {
            T[] tempKey = new T[key.Length + 1];
            V[] tempValue = new V[value.Length + 1];
            key.CopyTo(tempKey, 0);
            value.CopyTo(tempValue, 0);

            tempKey[key.Length] = k;
            tempValue[value.Length] = v;

            key = tempKey;
            value = tempValue;
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        public void Dispose()
        {

        }

    }
}