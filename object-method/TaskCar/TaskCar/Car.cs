using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    class Car
    {
        //Fields
        public string Brand;
        public int Speed;

        //Constructor
        public Car()
        {
            Brand = null;
            Speed = 0;
        }

        //Methods
        public void AskData()
        {
            Console.WriteLine($"Anna auton merkki ja nopeus km/h:");
            Brand = Console.ReadLine();
            Speed = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            
            Console.WriteLine($"Annoit merkiksi {Brand} ja nopeudeksi {Speed} km/h\n");
        }

        public void Accelerate()
        {
            Console.WriteLine("Anna kerroin jolla auton nopeutta lisätään");
            double speed1 = double.Parse(Console.ReadLine());

            if (speed1 < 1)
                Console.WriteLine("Negatiivista muutosta ei sallita");
            else
                Console.WriteLine($"Nopeutta lisättiin {speed1} kertaiseksi, uusi nopeus on {speed1 * Speed} km/h\n");
        }

        public void Brake()
        {
            double speed2 = Speed * 0.9;
            Console.WriteLine($"Nopeutta hidastettiin 10%, uusi nopeus on {speed2} km/h\n ------------------\n");
        }


    }
}
