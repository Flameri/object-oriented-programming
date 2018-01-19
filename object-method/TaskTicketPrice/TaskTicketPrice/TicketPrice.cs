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
            Console.WriteLine("Anna ikäsi");
            Age = Console.Read();
            //Console.WriteLine("Oletko Mtk:n jäsen?");
            //Mtk = bool.Parse(Console.ReadLine().ToUpper());
            //Console.WriteLine("Oletko varusmies? Y/N");
            //Soldier = bool.Parse(Console.ReadLine().ToUpper());
            //Console.WriteLine("Oletko Opiskelija Y/N");
            //Student = bool.Parse(Console.ReadLine().ToUpper());
            isMtk = Answer("MTK:n jäsen");
            isSoldier = Answer("Varusmies");
            isStudent = Answer("Opiskelija");

        }
        public bool Answer(string msg)
        {
            Console.WriteLine($"Oletko {msg} Y/N");
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
            else if(Age >= 65 )
            {
                Discount = 50;
            }
            else
            {
                Discount = 0;
            }

            //MTK
            if(isMtk == true)
            {
                Discount = 15;
            }
            else if(isMtk == false)
            {
                Discount = 0;
            }

            //Sotilas
            if (isSoldier == true)
            {
                Discount = 50;
            }
            else if (isSoldier == false && isMtk == true)
            {
                Discount = 15;
            }
            else if(isSoldier == true && isStudent == true && isMtk == true)
            {
                Discount = 50;
            }
            else if(isSoldier == false)
            {
                Discount = 0;
            }
            
            //Opiskelija
            if (isStudent == true)
            {
                Discount = 45;
            }
            else if(isStudent == true && isMtk == true)
            {
                Discount = 60;
            }
            else if (isStudent == false)
            {
                Discount = 0;
            }
           
            EndPrice = (NormalPrice - (NormalPrice * Convert.ToDecimal(Discount / 100m)));
            Console.WriteLine($"Lippusi hinta on: {EndPrice:C} ");
        
        }
    }
}
