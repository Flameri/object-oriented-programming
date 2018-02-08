using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInheritance
{
    abstract class Transportation
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
        abstract public void PrintInfo();
    }
}
