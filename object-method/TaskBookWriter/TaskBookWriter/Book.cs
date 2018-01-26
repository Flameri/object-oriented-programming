using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookWriter
{
    class Book
    {
        //FIelds
        public string Name;
        public string Writer;
        public string Publisher;
        private double price;
        public static string ThemeName;


        //Constructor
        public Book(string name, string writer, string publisher, double price, string themename)
        {
            Name = name;
            Writer = "Dan Brown";
            Publisher = publisher;
            price = Price;
            ThemeName = themename;
        }

        //Methods
        public void GetBook(string name)
        {
            if (this.Name == name)
            {
                Console.WriteLine($"{Name}, {Publisher}, {Price:C}, {ThemeName}");
            }
            else
            {
                Console.WriteLine($"Hait kirjaa {name}. Kirjaa ei löytynyt\n");
            }
        }
        public static void ChangeTheme(string theme)
        {
            ThemeName = theme;
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 30)
                {
                    price = value * 0.9;
                }

            }
        }
    }
}
    


