using Dictionary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary  = new MyDictionary<string, string>();
            dictionary.Add("test", "test1");
            System.Console.WriteLine(dictionary.Count);
        }
    }
}
