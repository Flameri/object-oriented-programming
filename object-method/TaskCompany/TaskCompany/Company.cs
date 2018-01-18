using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCompany
{
    class Company
    {
        //Fields
        public string Title;
        public string Address;
        public string Phone;
        public int Income;
        public int Expense;

        //Constructor määritelty parametrit
        public Company(string title, string address, string phone, int income, int expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Income = income;
            Expense = expense;
        }
        //Constructor määrittelemätön
        public Company()
        {
            Title = "Ei ole tiedossa";
            Address = "Ei ole tiedossa";
            Phone =  "0";
            Income = 0;
            Expense = 0;
        }
        // Constructor Kopiointimuodostin
        public Company(Company company)
        {
            Title = company.Title;
            Address = company.Address;
            Phone = company.Phone;
            Income = company.Income;
            Expense = company.Expense;
        }
        //methods 
        public void CompanyProfit()
        {
            double profit = (Income - Expense) / Expense;

            if(profit < 1)
            {
                Console.WriteLine("Yrityksellä menee huonosti");
            }
            else if(profit > 1 && profit < 3)
            {
                Console.WriteLine("Yrityksellä menee tyydyttävästi");
            }
            else if(profit >= 3)
            {
                Console.WriteLine("Yrityksellä menee hyvin");
            }
            Console.WriteLine("-------------------------");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\nYrityksen nimi: {Title}\nosoite: {Address}\n" +
                $"Puhelin nro: {Phone}\nTulot: {Income:C}\nMenot: {Expense:C}\n");
        }
    }
}
