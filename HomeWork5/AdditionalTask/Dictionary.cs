using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] eng = new string[5];
        private string[] ukr = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; eng[0] = "book"; ukr[0] = "Книга";
            key[1] = "ручка"; eng[1] = "pen"; ukr[1] = "Ручка";
            key[2] = "солнце"; eng[2] = "sun"; ukr[2] = "Сонце";
            key[3] = "яблоко"; eng[3] = "apple"; ukr[3] = "Яблуко";
            key[4] = "стол"; eng[4] = "table"; ukr[4] = "Стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index || eng[i] == index || ukr[i] == index)
                        return key[i] + " - " + eng[i] + " - " + ukr[i];
                        
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + eng[index] + " - " + ukr[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
