using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("qwerty", "alex", "Diachenko", 18);
            user.Age = 10;
            user.ShowUserData();
            
            Console.ReadKey();
        }
    }
}
