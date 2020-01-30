using System;

namespace Task3
{
    class Book
    {
        public class Note
        {
            public string Text { get; set; }
        }
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }
}
