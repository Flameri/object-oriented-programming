using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
{
    class Book
    {
        //Fields
        public string Title;
        public string Author;
        public int Id;
        public int Price;

        //Constructor
        public Book(string Title, string Author, int Id, int Price)
        {
            Title = Title;
            Author = Author;
            Id = Id;
            Price = Price;
        }

        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Nimi: {Title}\nKirjoittaja: {Author}\nId: {Id}\nHinta{Price}");
        }

    }
}
