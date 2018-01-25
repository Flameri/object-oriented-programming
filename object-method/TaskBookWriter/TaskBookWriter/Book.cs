using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookWriter
{
    class Book
    {
        //FIelds
        public string Name;
        public string Publisher;
        public double Price;
        public static string ThemeName;


        //Constructor
        public Book()
        {
            Name = "";
            Publisher = "";
            Price = 0;
            ThemeName = "";
        }

        public Book(string name, string publisher, double price, string themename)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            ThemeName = themename;
        }

        //Methods
        public void GetBook(string name)
        {
            //Console.WriteLine("Anna etsimäsi kirjan nimi");
            //name = Console.ReadLine();
            if (this.Name == name)
            {
                Console.WriteLine($"{Name}, {Publisher}, {Price:C}, {ThemeName}");
            }
            else
            {
                Console.WriteLine("Kirjaa ei löytynyt");
            }
        }
        public static void  ChangeTheme(string theme)
        {
            ThemeName = theme;
        }
    }
}
