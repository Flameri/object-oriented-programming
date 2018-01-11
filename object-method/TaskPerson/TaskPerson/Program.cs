using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Person personArto = new Person();
            personArto.Name = "Arto L";
            Console.WriteLine($"Arton ikä {personArto.GetAge()}");

            personArto.GrowOld();
            Console.WriteLine($"Arton ikä {personArto.GetAge()}");
            personArto.GrowOld(50);
            personArto.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();


            Console.ReadKey();
        }
    }
}
