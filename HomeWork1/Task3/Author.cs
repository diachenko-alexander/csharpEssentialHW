using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Author
    {
        readonly string author;

        public Author (string author)
        {
            this.author = author;
        }

        public void Show ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Author: " + author);
        }
    }
}
