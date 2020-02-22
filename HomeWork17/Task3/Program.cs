using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myDictionary = new Dictionary<dynamic, dynamic>
            {
                {new {Key = "apple"}, new {Value = "яблок" } },
                {new {Key = "pen"}, new {Value = "ручка" } },
                {new {Key = "boy"}, new {Value = "мальчик" } },
                {new {Key = "girl"}, new {Value = "девочка" } },
                {new {Key = "good"}, new {Value = "хорошо" } },
                {new {Key = "bad"}, new {Value = "плохо" } },
            };

            foreach (var word in myDictionary)
            {
                Console.WriteLine($"{word.Key} --- {word.Value}");
            }
        }
    }
}
