using System;

namespace TaskInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Transportation car1 = new Transportation("Farmari", "Volvo", 2000, 4000);
            
            car1.PrintInfo();

            Car car2 = new Car("Sedan", "Toyota", 2005,2000, 4.5, "Rav4",4);
            car2.PrintInfo();

            Console.WriteLine(car2.ToString());

            Console.WriteLine(car1.Equals(car1));
            Console.WriteLine(car1.Equals(car2));

            Truck truck1 = new Truck("Pickup","Ford",2017,40000, 5.5, "F150", 4, 3000, 15);
            truck1.PrintInfo();

            Console.WriteLine(truck1.CalcCons());

            Console.ReadKey();
        }
    }
}
