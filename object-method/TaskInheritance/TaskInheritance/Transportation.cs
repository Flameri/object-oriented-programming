using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInheritance
{
    class Transportation
    {
        //fields
        protected string Type;
        protected string Model;
        protected int Year;
        protected double Price;

        //Constructor
        public Transportation(string type, string model, int year, double price)
        {
            Type = type;
            Model = model;
            Year = year;
            Price = price;
        }

        //methods
        virtual public void PrintInfo()
        {
            Console.WriteLine($"\n{Type}" +
                $"\n{Model}" +
                $"\n{Year}\n" +
                $"{Price:C}");
        }
    }
}
