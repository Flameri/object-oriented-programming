using System;

namespace TaskInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Transportation Car1 = new Transportation("Farmari", "Volvo", 2000, 4000);
            Car1.PrintInfo();

            Car car2 = new Car("Sedan", "Toyota", 2005,2000, 4.5, "Rav4",4);
            car2.PrintInfo();
            Console.ReadKey();
        }
    }
}
