using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProductInterface
{
    class Store : ICustomers, IProducts
    {
        //Fields
        public string Name;
        public string Turnover;
        public List<Product> products;
        public List<Customer> customers;

        //Constructor
        public Store(string name, string turnover)
        {
            Name = name;
            Turnover = turnover;
            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();
        }

        //Override ToString
        public override string ToString()
        {
            return ($"\n{Name}\n{Turnover:C}\n");
        }
        //Interface ICustomer methods
        public void AddCustomer(List<Customer> customer)
        {
            customers = customer ;
        }
        public void PrintCustomers()
        {
            foreach (Customer c in customers)
            { 
                Console.WriteLine($" {c.ToString()}");
                c.CalculateBonus();
            }
            Console.WriteLine($"Asiakkaat listalla:" +
                $" {customers.Count()}");
            Console.WriteLine(new string('-',25));
        }
        //INterface IProducts methods
        public void AddProducts(List<Product> product)
        {
            products = product;
        }
        public void PrintProducts()
        {
            foreach (Product p in products)
            {
                Console.WriteLine($"{p.ToString()}");
                p.CalculateTotal();
            }
            Console.WriteLine($"Tuotteita listalla:" +
                $" {products.Count()}");
            Console.WriteLine(new string('-', 25));
        }
    }
}
