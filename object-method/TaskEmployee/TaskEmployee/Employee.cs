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
        public string Salary;

        //Constructor
        public Employee(string name, int id, string position, string salary)
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
                Console.WriteLine($"{Employee.Name} palkka on pienempi kuin henkilön {employee.Name} palkka");
            }
            else
            {
                Console.WriteLine($"{employee.Name} palkka on pienempi kuin henkilön {Employee.Name} palkka);
            }

        }
    }
}
