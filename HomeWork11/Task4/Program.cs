using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList myArrayList = new MyArrayList();
            myArrayList.Add("text", 12, 12.5);

            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }
        }
    }
}
