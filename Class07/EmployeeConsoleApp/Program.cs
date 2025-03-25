using System;
using System.Data;
using EmployeeLibrary;

namespace EmployeeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(
                "Sandra",
                "Simjanoska",
                Role.Other,
                1000
            );

            employee.PrintInfo();
            Console.WriteLine($"Salary: {employee.GetSalary()}");


            SalesPerson angel = new SalesPerson("Angel", "Ivanovski");

            angel.AddSuccessRevenue(1500);
            Console.WriteLine($"Angel's salary: ${angel.GetSalary()}");

            angel.AddSuccessRevenue(3000);
            Console.WriteLine($"Angel's new salary: ${angel.GetSalary()}");



            Manager bob = new Manager("Bob", "Bobsky", 60000);

            bob.AddBonus(5000);  
            bob.AddBonus(2000);  

            Console.WriteLine("Manager's Pay:");
            Console.WriteLine($"Base Salary: {bob.GetSalary() - bob.GetBonus()}");
            Console.WriteLine($"Bonus: {bob.GetBonus()}");
            Console.WriteLine($"Total: {bob.GetSalary()}");
        }
    }
}