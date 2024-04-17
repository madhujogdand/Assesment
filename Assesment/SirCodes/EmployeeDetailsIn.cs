using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class Employee1
    {
        protected int empid;
        protected string empname;
        protected double bs, hra, pf, gross;

        public Employee1()
        {
            empid = 1;
            empname = "Madhu";
            bs = 4000;
            hra = 2000;
            pf = 1000;
        }

        public Employee1(int id, string name, double b, double h, double p)
        {
            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;
        }

        public virtual void CalculateSalary1()
        {
            gross = (bs + hra) - pf;
        }

        public virtual string Display1()
        {
            return $" employee salary empid={empid}, empname={empname}, gross={gross}";

        }
    
    }
    public class EmployeeDetailsIn
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Assign();
            emp.CalculateSalary();
            string result= emp.Display();
            Console.WriteLine( result);


            Employee emp1 = new Employee();
            emp1.Accept(2,"Shivansh",4500.50,3200.67,500.50);
            emp1.CalculateSalary();
            Console.WriteLine(emp1.Display());

        }
    }
}
