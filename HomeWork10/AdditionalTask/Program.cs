using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class SomeClass
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            SomeClass myClass = MyClass<SomeClass>.FactoryMethod();
            Console.WriteLine(myClass.GetType());
        }
    }
}
