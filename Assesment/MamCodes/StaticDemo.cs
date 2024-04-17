using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to demonstrate static keyword with variable, methhod, constructor and class */
namespace Assesment.MamCodes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //private int id;
        //private string name;
        private static int count;
        public Employee()
        {
            count++;
            Id = count;
            Name = "Neha";
        }
        public Employee(string name)
        {
            count++;
            Id = count;
            this.Name = name;

        }
        public static int GetCount()
        { 
           return count;
        }

    }
    public class StaticDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();  
            Console.WriteLine("Total count: "+Employee.GetCount());
            Console.WriteLine("Name:"+emp.Name);

            Employee emp2 = new Employee("madhu");
            Console.WriteLine("Total count: " + Employee.GetCount());
            Console.WriteLine("Name: " + emp2.Name);
        }
    }
}
