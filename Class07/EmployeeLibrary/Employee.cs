using EmployeeLibrary.Enums;
using System;

namespace EmployeeLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}