using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProductInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Product> products = new List<Product>();
            Product product1 = new Product("Pultti", 0.50, 100);
            Product product2 = new Product("Mutteri", 0.60, 150);
            Product product3 = new Product("Ruuvi", 0.40, 200);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);


            products[0].GetProduct();
            products[0].CalculateTotal();

            products[1].GetProduct();
            products[1].CalculateTotal();
            products[2].GetProduct();
            products[2].CalculateTotal();

            List<Customer> customers = new List<Customer>();
            Customer customer1 = new Customer("Pertti", 400);
            Customer customer2 = new Customer("Köpi", 4000);
            Customer customer3 = new Customer("Sepi", 1000);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            
            customers[0].GetCustomer();
            customers[0].CalculateBonus();
            customers[1].GetCustomer();
            customers[1].CalculateBonus();
            customers[2].GetCustomer();
            customers[2].CalculateBonus();

            Store store = new Store("Valintaliike", "3 000 000");
            store.AddCustomer(customers);
            store.AddProducts(products);
            store.PrintCustomers();
            store.PrintProducts();
            Console.ReadKey();
        }
    }
}
