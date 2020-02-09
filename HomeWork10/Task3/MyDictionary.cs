using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] key;
        private TValue[] value;

        public int Lenght { get { return key.Length; } }

        public string this [int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + "---" + value[index];
                }
                return "Index out of boundary values";
            }
        }

        public MyDictionary()
        {
            key = new TKey[0];
            value = new TValue[0];
        }

        public void Add (TKey k, TValue v)
        {
            TKey [] tempKey = new TKey[key.Length + 1];
            TValue[] tempValue = new TValue[value.Length + 1];

            key.CopyTo(tempKey, 0);
            value.CopyTo(tempValue, 0);

            tempKey[key.Length] = k;
            tempValue[value.Length] = v;

            key = tempKey;
            value = tempValue;
        }


    }
}
