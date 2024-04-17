using Assesment.SirCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{

    public class Manager : Employee1
    {
        private double food;

        public Manager():base()
        {

        }

    public Manager(int id, string name, double b, double h, double p, double food) :
    base(id, name, b, h, p)
    {
        this.food = food;
    }

    public override void CalculateSalary1()
    {
        gross = (bs + hra+food) - pf;
    }

    public override string Display1()
    {
        return $" Manager salary empid={empid}, empname={empname}, gross={gross}";

    }
}
    public class ManagerDetails
    {
        static void Main(string[] args)
        {
            Employee1 e1= new Employee1(1,"xyz",2000,1000,250);
        e1.CalculateSalary1();
        Console.WriteLine(e1.Display1());

        //object of child class

        Manager m = new Manager(2, "PQR", 3000, 2000, 500, 1000);

        m.CalculateSalary1();
        Console.WriteLine(m.Display1());

        //create reference of base class but object of child class

        Employee1 e = new Manager(3, "MNO", 4000, 2000, 500, 1000);
        e.CalculateSalary1();
        Console.WriteLine( e.Display1());

    }
    }
}
