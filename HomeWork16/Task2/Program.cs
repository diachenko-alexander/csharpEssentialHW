using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block a = new Block(12, 2, 12, 2);
            Block b = new Block(2, 12, 2, 12);
            Block c = new Block(2, 3, 4, 5);

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(b.Equals(c));

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());

            if (a.GetHashCode() == b.GetHashCode())
            {
                Console.WriteLine("Block are equals");
            }
            else Console.WriteLine("Blocks are not equals");
        }
    }
}
