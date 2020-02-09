using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("some text");
            list.Add(2);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // С проблемами не столкнулся. Может что то не так понял.
        }
    }
}
