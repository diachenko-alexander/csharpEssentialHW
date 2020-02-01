using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public delegate int MyDelegate();
    public delegate double MyDelegateArray (MyDelegate[] delegates);
    class Program
    {
       
        public static int Rnd1()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100);
        }

        public static int Rnd2()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }

        public static int Rnd3()
        {
            Random rnd = new Random();
            return rnd.Next(0, 20);
        }


        static void Main(string[] args)
        {
            MyDelegate Rnd1 = new MyDelegate(Program.Rnd1);
            MyDelegate Rnd2 = new MyDelegate(Program.Rnd2);
            MyDelegate Rnd3 = new MyDelegate(Program.Rnd3);
            MyDelegate[] arrayOfDelegates = new MyDelegate[] { Rnd1, Rnd2, Rnd3 };

            MyDelegateArray myDelegateArray = delegate ( MyDelegate[] myDelegates)
            {
                double summ = 0;
                for (int i = 0; i < myDelegates.Length; i++)
                {
                    Console.WriteLine(myDelegates[i]());
                    summ += myDelegates[i]();
                }
                return summ / myDelegates.Length;
            };

            Console.WriteLine(myDelegateArray (arrayOfDelegates));

        }
    }
}
