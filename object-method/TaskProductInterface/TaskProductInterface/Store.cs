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
        public double Turnover;
        public List<Product> products;
        public List<Customer> customers;

        //Constructor
        public Store(string name, double turnover, List<Product> products, List<Customer> customers)
        {
            Name = name;
            Turnover = turnover;
            this.products = products;
            this.customers = customers;
        }

        //Override ToString
        public override string ToString()
        {
            return ($"\n{Name}\n{Turnover:C}\n");
        }
        //Interface ICustomer methods
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void PrintCustomers()
        {
            Console.WriteLine($"{customers}");
        }
        //INterface IProducts methods
        public void AddProducts(Product product)
        {
            products.Add(product);
            
        }
        public void PrintProducts()
        {
            Console.WriteLine($"{products.Count} {products}");
        }
    }
}
