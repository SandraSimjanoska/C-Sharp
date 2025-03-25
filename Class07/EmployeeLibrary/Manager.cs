namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        private double bonus; 

        public Manager(string firstName, string lastName, double salary)
            : base(firstName, lastName, Role.Manager, salary)
        {
            bonus = 0;  
        }

        public void AddBonus(double amount)
        {
            bonus += amount;
        }

        public override double GetSalary()
        {
            return Salary + bonus;  
        }

        public double GetBonus()
        {
            return bonus;
        }
    }
}