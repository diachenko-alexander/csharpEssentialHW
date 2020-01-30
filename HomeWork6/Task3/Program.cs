using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book.Note note = new Book.Note();
            note.Text = "Some text";
            Console.WriteLine(note.Text);
        }
    }
}
