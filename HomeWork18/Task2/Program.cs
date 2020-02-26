extern alias T2;
using T2::BuildForTask2;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Test();
        }
    }
}
