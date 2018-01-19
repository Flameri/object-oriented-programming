using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicketPrice
{
    class TicketPrice
    {
        //Fields
        public int Age;
        public bool Mtk;
        public int NormalPrice;
        public decimal EndPrice;
        public int Discount;
        public bool Soldier;
        public bool Student;

        //constructor
        public TicketPrice()
        {
            Age = 0;
            Mtk = false;
            NormalPrice = 16;
            EndPrice = 0;
            Soldier = false;
            Student = false;
            Discount = 0;
        }

        //Methods
        public void Data()
        {
            Console.WriteLine("Tervetuloa! Lasketaanpa lippusi hinta\n");
            Console.WriteLine("Anna ikäsi");
            Age = Console.Read();
            Console.WriteLine("Oletko Mtk:n jäsen?");
            Mtk = bool.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Oletko varusmies? Y/N");
            Soldier = bool.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Oletko Opiskelija Y/N");
            Student = bool.Parse(Console.ReadLine().ToUpper());
        }

        public void PriceCount()
        {
            bool y = true;
            y = bool.Parse("Y");
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
            if(Mtk == true)
            {
                Discount = 15;
            }
            else if(Mtk == false)
            {
                Discount = 0;
            }

            //Sotilas
            if (Soldier == true)
            {
                Discount = 50;
            }
            else if (Soldier == false && Mtk == true)
            {
                Discount = 15;
            }
            else if(Soldier == true && Student == true && Mtk == true)
            {
                Discount = 50;
            }
            else if(Soldier == false)
            {
                Discount = 0;
            }
            
            //Opiskelija
            if (Student == true)
            {
                Discount = 45;
            }
            else if(Student == true && Mtk == true)
            {
                Discount = 60;
            }
            else if (Student == false)
            {
                Discount = 0;
            }
           
            EndPrice = (NormalPrice - (NormalPrice * Convert.ToDecimal(Discount / 100m)));
            Console.WriteLine($"Lippusi hinta on: {EndPrice:C} ");
        
        }
    }
}
