using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Matti Meikäläinen", 15236, "Toimitusjohtaja", 6000);
            employees[1] = new Employee("Maisa Meikäläinen", 13326, "Myyntipäällikkö", 2500);
            employees[2] = new Employee("Jorma Penttilä", 10002, "Omistaja", 10000);

            for (int i = 0; i < 3; i++)
            {
                employees[i].PrintEmployeeInfo();
            }
            employees[1].CompareSalary(employees[2]);
            employees[0].CompareSalary(employees[1]);
            employees[2].CompareSalary(employees[1]);


            Console.ReadKey();
        }
    }
}
