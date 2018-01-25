using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicketPrice
{
    class TicketPrice
    {
        //Fields
        public int Age;
        public bool isMtk;
        public int NormalPrice;
        public decimal EndPrice;
        public int Discount;
        public bool isSoldier;
        public bool isStudent;

        //constructor
        public TicketPrice()
        {
            Age = 0;
            isMtk = false;
            NormalPrice = 16;
            EndPrice = 0;
            isSoldier = false;
            isStudent = false;
            Discount = 0;
        }

        //Methods
        public void Data()
        {
            Console.WriteLine("Tervetuloa! Lasketaanpa lippusi hinta\n");
            Console.Write("Anna ikäsi: ");
            Age = int.Parse(Console.ReadLine());
            isMtk = Answer("MTK:n jäsen");
            isSoldier = Answer("Varusmies");
            isStudent = Answer("Opiskelija");

        }
        public bool Answer(string msg)
        {
            Console.Write($"Oletko {msg} Y/N: ");
            string ans = Console.ReadLine().ToUpper();

            if (ans == "Y")
                return true;
            else 
                return false;
        }

        public void PriceCount()
        {
           
            //Ikä
            if(Age < 7)
            {
                Discount = 100;
            }
            else if (Age >= 7 && Age <= 15)
            {
                Discount = 50;
            }
            else if(Age >= 65)
            {
                Discount = 50;
            }
         

            //MTK
            if(isMtk)
            {
                Discount = 15;
            }
            

            //Sotilas
            if (isSoldier)
            {
                Discount = 50;
            }
          
            
            //Opiskelija
            if (isStudent)
            {
                Discount = 45;
            }

            if (isStudent && isMtk)
            {
                Discount = 60;
            }
      
           
            EndPrice = (NormalPrice - (NormalPrice * Convert.ToDecimal(Discount / 100m)));
            Console.WriteLine($"Lippusi hinta on: {EndPrice:C}");
        
        }
    }
}
