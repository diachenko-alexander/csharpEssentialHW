using System;


namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook dell = new Notebook("Dell");
            dell.Show();

            Notebook dell2 = new Notebook("Dell G3 15", "Dell", 1000);
            dell2.Show();

            Console.ReadKey();
        }
    }
}
