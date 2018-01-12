using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book newBook = new Book("Kiirastuli", "Jussi Holli",1234,23.50);
            newBook.PrintInfo();
           

            Book newBook2 = new Book("Digimonien salat", "Pekka Holli", 4321, 25.00);
            newBook2.PrintInfo();

            Book newBook3 = new Book("Digimonien salat 2", "Pekka Holli", 5467, 30.00);
            newBook3.PrintInfo();

            Book newBook4 = new Book("Vatikaanin historia", "Dan Brown", 6789, 35.00);
            newBook4.PrintInfo();

            Console.WriteLine(newBook.CompareBook(newBook3));

            Console.WriteLine(newBook2.CompareBook(newBook4));

            Console.WriteLine(newBook3.CompareBook(newBook2));


            Console.ReadKey();
        }
    }
}
