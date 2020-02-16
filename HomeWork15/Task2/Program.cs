namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Workers workers = new Workers();
            workers.AddByConsole();
            System.Console.WriteLine(workers[2]);
        }
    }
}
