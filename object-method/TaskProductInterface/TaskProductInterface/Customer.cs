using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProductInterface
{
    class Customer : ICustomer
    {
        //fields
        public string Name;
        public double Groceries;

        //Constructor
        public Customer(string name, double groceries)
        {
            Name = name;
            Groceries = groceries;
        }
        //Override ToString
        public override string ToString()
        {
            return ($"\n{Name}\n{Groceries}\n");
        }

        //ICustomer methods
        public void GetCustomer()
        {
            string NewCustomer = Name;
            if (NewCustomer == Name)
            {
                Console.WriteLine($"{Name}");
            }
            else
            {
                Console.WriteLine($"{null}");
            }
        }
        public void CalculateBonus()
        {
            double Total;
            if(Groceries <= 1000)
            {
                Total = Groceries * 0.02;
                Console.WriteLine($"Bonus on 2%: {Total}");
            }
            else if (Groceries > 1000 && Groceries < 200)
            {
                Total = Groceries * 0.03;
                Console.WriteLine($"Bonus on 3%: {Total}");
            }
            else
            {
                Total = Groceries * 0.05;
                Console.WriteLine($"Bonus on 5%: {Total}");
            }

        }
    }
}
