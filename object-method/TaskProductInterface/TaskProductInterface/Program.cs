using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProductInterface
{
    class Program
    {
        private static readonly List<Product> listproducts;
        private static List<Customer> listcustomers;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Product[] products = new Product[3];
            Product product1 = new Product("Pultti", 0.50, 100);
            Product product2 = new Product("Mutteri", 0.60, 150);
            Product product3 = new Product("Ruuvi", 0.40, 200);

            products[0] = product1;
            products[1] = product2;
            products[2] = product3;

            products[0].GetProduct();
            products[0].CalculateTotal();

            products[1].GetProduct();
            products[1].CalculateTotal();
            products[2].GetProduct();
            products[2].CalculateTotal();

            Customer[] customers = new Customer[3];
            Customer customer1 = new Customer("Pertti", 400);
            Customer customer2 = new Customer("Köpi", 4000);
            Customer customer3 = new Customer("Sepi", 1000);
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            customers[0].GetCustomer();
            customers[0].CalculateBonus();
            customers[1].GetCustomer();
            customers[1].CalculateBonus();
            customers[2].GetCustomer();
            customers[2].CalculateBonus();

            Store store = new Store("Valintatalo", 30000000, listproducts, listcustomers);
            
            Console.ReadKey();
        }
    }
}
