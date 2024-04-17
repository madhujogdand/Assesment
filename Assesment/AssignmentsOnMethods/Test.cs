using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.add method displayData inside Student class change values of id name in that method & also print the changed
values in same method. Call displayData method from main method and see the output. Observe displayData can
only be called by creating object of Student

2.Create getId() method in Student class. call getId() methodfrom displayData method so that you know that one
method can be called from another method. Return id from getId() method and set that id to the instance
variable in displayData method.

3.create another method in Student class setCustomData(int customId, String customName) These 2 variables are local
variables. Call setCustomData from main method using Student object and assign any values to customId,
customName from main method. Observe your values are overwritten in id and name instance variables. Then print
id and name in main method.


*/
namespace Assesment.AssignmentsOnMethods
{
    class Student
    {
        private int id;
        private string name;

        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;

            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
        }

        public void setCustomData(int customId, String customName)
        {
            id = customId;
            name = customName;

        }
        public void display()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
        }

        public int getId()
        { 
            return id;
        }

        public void displayData(int newId, string newName)
        { 

            this.id=getId();

           this.id=newId;
            this.name=newName;

            Console.WriteLine("Changed id: "+id);
            Console.WriteLine("Chanded name: "+name);
        }
    }
    public class Test
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Rina");

            s.displayData(2, "Ritu");
            s.setCustomData(3, "Priti");
            s.display();
        }
    }
}
