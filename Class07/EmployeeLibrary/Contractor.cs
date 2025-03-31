using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary.Enums;
namespace EmployeeLibrary
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, Manager responsible, double workHours, int payPerHour)
            : base(firstName, lastName, Role.Contractor, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}