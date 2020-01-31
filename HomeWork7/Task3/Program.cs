using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "not changed";
            ClassTaker(myClass);
            Console.WriteLine(myClass.change);

            MyStruct myStruct = new MyStruct();
            myStruct.change = "not changed";
            StruktTaker(myStruct);
            Console.WriteLine(myStruct.change);
        }

        static void ClassTaker (MyClass myClass)
        {
            myClass.change = "changed";
        }

        static void StruktTaker (MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
}
