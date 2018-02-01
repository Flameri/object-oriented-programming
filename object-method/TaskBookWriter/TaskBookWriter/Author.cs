using Literature.TaskBookWriter;
using System;
using System.Collections.Generic;
using System.Text;
using TaskBookWriter;

namespace TaskBookWriter
{
    class Author
    {
        //Fields
        public string Name;
        public string Birthday;
        Book Book;

        //Constructor
        public Author(string name, string birthday, Book book)
        {
            Name = name;
            Birthday = birthday;
            Book = book;
        }

        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Kirjailijan nimi on {Name}," +
                $"\nHän on syntynyt {Birthday}");
            Book.GetBook("La Cosa Nostra");
        }
    }
}
