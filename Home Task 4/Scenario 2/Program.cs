using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_2
{
    class Program
    {
        static void Main(string[] args)
        {
             Employee Employee1 = new Employee(1212,"Fahad","IT",80000);
            Employee1.DisplayEmployeeDetails();
            Employee1.IncreaseSalary(4000);

            Console.WriteLine();
            Employee Employee2 = new Employee(1220, "Abdullah", "Finance", 120000);
            Employee2.DisplayEmployeeDetails();
            Employee2.IncreaseSalary(6000);

            Console.WriteLine();
            Employee Employee3 = new Employee(1221, "Sabeer", "Design", 76000);
            Employee3.DisplayEmployeeDetails();
            Employee3.IncreaseSalary(3800);

        }
    }
}
