using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        //Fields
        public string Name;
        public int Id;
        public string Position;
        public int Salary;

        //Constructor
        public Employee(string name, int id, string position, int salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }
        //Methods
        public void CompareSalary(Employee employee)
        {
            if(Salary < employee.Salary)
            {
                Console.WriteLine($"\n{employee.Name} palkka on isompi kuin henkilön {Name} palkka");
            }
            else
            {
                Console.WriteLine($"\n{Name} palkka on isompi kuin henkilön {employee.Name} palkka");
            }
        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"\nTyöntekijän nimi: {Name}" +
                $"\nTyöntekijän tunnus: {Id}" +
                $"\nTyöntekijän asema{Position}" +
                $"\nTyöntekijän palkka: {Salary:C}");
        }
    }
}
