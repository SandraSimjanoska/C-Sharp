using EmployeeLibrary.Enums;
using System;

namespace EmployeeLibrary
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName)
            : base(firstName, lastName, Role.Sales, 500)
        {
            SuccessSaleRevenue = 0;
        }

        public void AddSuccessRevenue(double amount)
        {
            SuccessSaleRevenue += amount;
        }

        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
                return Salary + 500;

            if (SuccessSaleRevenue <= 5000)
                return Salary + 1000;

            return Salary + 1500;
        }
    }
}