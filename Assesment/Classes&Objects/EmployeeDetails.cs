using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF.
 * Accept the value of id, name & basic salary from constructor.
 * Calculate the employee gross salary  & display employee details using ToString() method
a.	HRA- 40% of basic salary
b.	TA – 20% of basic salary
c.	PF -12 % of basic salary

5.Use above Employee class, create a static field to auto increment the employee id &
create static method to display the total object count.

6.Use above Employee class, make a constant field as PT(professional tax) as 200. 
Deduct the PT from salary & display the gross salary.
*/
namespace Assesment.Classes_Objects
{
    public class Employee
    { 
       private int id;
        private string name;
        private double basicSalary;
        private double HRA;
        private double TA;
        private double PF;
        private static int count=0;
        private const double PT = 200;

        public Employee( string name, double basicSalary)
        {
            count++;
            id = count;
            //this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            this.HRA = 0.4 * basicSalary;
            this.TA = 0.2 * basicSalary;
            this.PF = 0.12 * basicSalary;
        }

        public double CalculateGrossSalary()
        {
            double grossSalary= basicSalary + HRA + TA - PF;

            grossSalary -= PT;
            return grossSalary;
        }

        public static void TotalObjectCount()
        {
            Console.WriteLine($"Total number of Employee objects: {count}");
        }

        public override string ToString()
        {
            return $"Employee ID: {id}\nName: {name}\nBasic Salary: {basicSalary}\nHRA: {HRA}\nTA: {TA}\nPF: {PF}\nPT: {PT}\nGross Salary: {CalculateGrossSalary()}\n";
        }

    }
    public class EmployeeDetails
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Jiya", 50000);
            Console.WriteLine(emp.ToString());

            Employee emp1 = new Employee("John", 60000);
            Console.WriteLine(emp1.ToString());

            Employee.TotalObjectCount();
        }
    }
}
