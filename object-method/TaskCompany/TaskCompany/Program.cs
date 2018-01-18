using System;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Company newCompany = new Company("Diamond Group", "Skinnarilankatu 38", "050 124562", 10000, 2000);
            Company newCompany2 = new Company(newCompany);
            Company newCompany3 = new Company();
            Company newCompany4 = new Company(newCompany3);


            newCompany.PrintInfo();
            newCompany.CompanyProfit();
            newCompany2.PrintInfo();
            newCompany2.CompanyProfit();
            newCompany3.PrintInfo();
            newCompany4.PrintInfo();
            


            Console.ReadLine();
        }
    }
}
