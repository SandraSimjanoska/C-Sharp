using System;

namespace EmployeeLibrary
{
    public class SalesPerson : Employee
    {
        private double salesAmount;

        public SalesPerson(string firstName, string lastName)
            : base(firstName, lastName, Role.Sales, 500)
        {
            salesAmount = 0;
        }

        public void AddSuccessRevenue(double amount)
        {
            salesAmount = amount;
        }

        public override double GetSalary()
        {
            if (salesAmount <= 2000)
                return 500 + 500;  

            if (salesAmount <= 5000)
                return 500 + 1000; 

            return 500 + 1500;     
        }
    }
}