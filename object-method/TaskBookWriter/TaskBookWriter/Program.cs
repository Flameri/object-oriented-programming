﻿using System;

namespace TaskBookWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book book1 = new Book( "La Cosa Nostra","Dan Brown", "Tammi", 31.10, "Elämänkerta\n");
            book1.GetBook("La Cosa Nostra");
            Book.ChangeTheme("Fantasia");
            Console.WriteLine($"Uusi teema on: {Book.ThemeName}\n");

            Book book2 = new Book("Digimonit", "Jukka Päätalo", "Otava", 29.90, "Jännitys\n");
            book2.GetBook("Digimonit");
            book2.GetBook("pellavapää");
            book2.Price = 40;

            Console.WriteLine($"Uusi hinta on: {book2.Price:C}");


            Console.ReadKey();
        }
    }
}
