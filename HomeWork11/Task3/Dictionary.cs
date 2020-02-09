using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Dictionary<TKey, TValue>
    {
        private readonly MyList<TKey> key;
        private readonly MyList<TValue> value;

        public int Count { get { return key.Count; } }

        public Dictionary()
        {
            key = new MyList<TKey>();
            value = new MyList<TValue>();
        }

        public string this [int index]
        {
            get
            {
                return key[index] + "---" + value[index];
            }
        }

        public string this [string index]
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if (value[i].ToString().ToLower() == index.ToLower() || key[i].ToString().ToLower() == index.ToLower())
                    {
                        return key[i] + "---" + value[i];
                    }
                    
                }
                return string.Format($"Word {index} is not found");
            }
        }

        public void Add (TKey k, TValue v)
        {
            key.Add(k);
            value.Add(v);
        }

        public void Clear()
        {
            key.Clear();
            value.Clear();
        }

    }
}
