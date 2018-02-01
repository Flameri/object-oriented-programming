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
    class Car : Transportation
    {
        //Fields
        protected double MotorSize;
        protected string Brand;
        protected int Doors;

        public Car(string type, string model, int year, double price,double motorsize, string brand, int doors) : base(type, model, year, price)
        {
            MotorSize = motorsize;
            Brand = brand;
            Doors = doors;
        }

        //override method
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{MotorSize}\n{Brand}\n{Doors}");
        }
    }
}
