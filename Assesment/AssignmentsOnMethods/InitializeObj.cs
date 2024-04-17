using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5)Write a program for class and object : (initialization through method)
Note: Initializing object simply means storing data into object*/

namespace Assesment.AssignmentsOnMethods
{
    public class Employee
    {
        public int id;
        public string name;


        public void Accept(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
        }
    }
    public class InitializeObj
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee();
            emp.Accept(1, "Shiv");
            emp.Display();
        }
    }
}
