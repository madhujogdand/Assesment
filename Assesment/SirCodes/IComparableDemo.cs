using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class Employee2:IComparable<Employee2>
    {
        public string name;
        public int salary;

        public Employee2(string name, int salarry)
        {
            this.name = name;
            this.salary = salarry;
        }

        public int CompareTo(Employee2? other)
        {
            if (this.salary > other.salary)
            {
                return 1;
            }
            else if(this.salary<other.salary)
            { 
                return -1;
            }
            else{
                return 0;
            }
            
        }

        public override string ToString()
        {
            return $"Name:{name},Salary:{salary}";
        }
    }
    public  class IComparableDemo
    {
        static void Main(string[] args)
        {
            Employee2 emp = new Employee2("Ritu", 30000);
            Console.WriteLine(emp.ToString());
            Employee2 emp1 = new Employee2("Rina", 25000);
            Console.WriteLine(emp1.ToString());
            int result=emp.CompareTo(emp1);

            if (result == 1)
            {
                Console.WriteLine("Ritu has more slary than Rina");
            }
            else if (result == -1)
            {
                Console.WriteLine("Ritu has less slary than Rina");
            }
            else {
                Console.WriteLine("Both have equal salary");
            }
        }
    }
}
