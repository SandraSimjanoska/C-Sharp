using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeLibrary.Enums;
namespace EmployeeLibrary
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, Employee[] employees)
            : base(firstName, lastName, Role.CEO, salary)
        {
            Employees = employees;
            Shares = 0;
            SharesPrice = 0;
        }

        public void AddSharesPrice(double price)
        {
            SharesPrice = price;
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}

