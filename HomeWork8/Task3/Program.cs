using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        enum Position
        {
            Dev = 30,
            Qa = 35,
            Ba = 40,
        }

        static class Accaunt
        {
            public static bool AskForBonus (Position position, int hours) 
            {
                if (hours > (int)position)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Accaunt.AskForBonus(Position.Dev, 35));
        }
    }
}
