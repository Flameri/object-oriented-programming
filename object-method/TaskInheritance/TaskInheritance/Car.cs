using System;
using System.Collections.Generic;
using System.Text;


namespace TaskInheritance
{
    class Car : Transportation
    {
        //Fields
        protected double MotorSize;
        protected string Brand;
        protected int Doors;

        public Car(string type, string model, int year, double price, double motorsize, string brand, int doors) : base(type, model, year, price)
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
        //override Tostring
        public override string ToString()
        {
            return ($"\n{MotorSize}\n{Brand}\n{Doors}");
        }
        //override Equals
        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;
            if (carObj == null)
                return false;
            else
                return Model.Equals(carObj.Model);
        }
    }
}
