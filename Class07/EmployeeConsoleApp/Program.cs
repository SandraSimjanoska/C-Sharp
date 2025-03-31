using System;
using System.Data;
using System.Runtime.ConstrainedExecution;
using EmployeeLibrary;
using EmployeeLibrary.Enums;

namespace EmployeeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Sandra", "Simjanoska", Role.Other, 1000);
            Employee employee2 = new Employee("Emilija", "Stamenkovska", Role.Other, 1000);
            Employee employee3 = new Employee("Ivana", "Ivanovska", Role.Other, 1000);

            employee1.PrintInfo();
            Console.WriteLine($"Salary: {employee1.GetSalary()}");

            SalesPerson angel = new SalesPerson("Angel", "Ivanovski");
            angel.AddSuccessRevenue(1500);
            Console.WriteLine($"Angel's salary: ${angel.GetSalary()}");
            angel.AddSuccessRevenue(3000);
            Console.WriteLine($"Angel's new salary: ${angel.GetSalary()}");

            Manager bob = new Manager("Bob", "Bobsky", 60000, "IT");
            bob.AddBonus(5000);
            bob.AddBonus(2000);
            Manager marija = new Manager("Marija", "Marijoska", 70000, "IT");

            Contractor john = new Contractor("John", "Doe", bob, 160, 50);
            Contractor jane = new Contractor("Jane", "Doe", bob, 160, 60);

            Console.WriteLine("\nManager's Pay:");
            Console.WriteLine($"Base Salary: {bob.GetSalary() - bob.GetSalary()}");
            Console.WriteLine($"Bonus: {bob.GetSalary() - 60000}");
            Console.WriteLine($"Total: {bob.GetSalary()}");

            Employee[] company = { john, jane, bob, marija, employee1 };

            CEO frose = new CEO("Frosina", "Stamenkovska", 10000, company);
            frose.AddSharesPrice(50);
            frose.Shares = 28;


            Console.WriteLine($"CEO:");
            frose.PrintInfo();
            Console.WriteLine($"Salary of CEO is: {frose.GetSalary()}");
            frose.PrintEmployees();
        }
    }
}