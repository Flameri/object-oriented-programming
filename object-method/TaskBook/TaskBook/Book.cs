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
        public double Price;

        //Constructor
        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }

        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Nimi: {Title}\nKirjoittaja: {Author}\nId: {Id}\nHinta: {Price}\n");
        }

        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
                return ($"{this.Title} on kalliimpi kuin {book.Title} kirja\n");
            else
                return ($"{book.Title} on kalliimpi kuin {this.Title} kirja\n");
        }
    }

}
