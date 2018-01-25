using System;

namespace TaskBookWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book book1 = new Book("Digimonit","Otava",29.90,"Jännitys");
            Book book2 = new Book("La Cosa Nostra", "Otava", 31.10, "Elämänkerta");

            book1.GetBook("Digimonit");
            book2.GetBook("La Cosa Nostra");
            book2.GetBook("pellavapää");

            Console.WriteLine(Book.ThemeName);
            Book.ChangeTheme("Fantasia");
            Console.WriteLine(Book.ThemeName);

            Console.ReadKey();
        }
    }
}
