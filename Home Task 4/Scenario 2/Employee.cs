using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_2
{
    class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        public Employee(int employeeID,string name, string department,double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Department = department;
            Salary = salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Name of the Employee: {Name}");
            Console.WriteLine($"Department of the Employee: {Department}");
            Console.WriteLine($"Salary of the Employee: {Salary}");
        }
        public void IncreaseSalary(double amount)
        {
            Salary = Salary + amount;
            Console.WriteLine($"Increment of the Employee: {Salary}");
        }
    }
}
