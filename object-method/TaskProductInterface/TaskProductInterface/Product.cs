using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProductInterface
{
    class Product : IProduct
    {
        //FIelds
        public string Name;
        public double Price;
        public double Count;

        //Constructor
        public Product(string name, double price, double count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        //Override ToString
        public override string ToString()
        {
            return ($"\n{Name}\n{Price}\n{Count}\n");
        }

        //Interface Methods
        public void GetProduct()
        {
            string NewName = Name;
            if(NewName == Name)
            {
                Console.WriteLine($"{Name}");
            }
            else
            {
                Console.WriteLine($"{null}");
            }
        }

        public void CalculateTotal()
        {
            double Total = Price * Count;
            Console.WriteLine($"Yhteisarvo on: {Total}");
        }
    }
}
