using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{

    public class Student
    {
        private int rollid;
        private string name;

        public Student()
        {
            rollid = 1;
            name = "Mina";
        }

        public Student(int rollid, string name)
        {
           this.rollid = rollid;    
            this.name = name;
        }

        public string Display()
        {
            return $"Roll id:{rollid}, Name: {name}";
        }


    }
    public class StudentDetails
    {
        static void Main(string[] args)
        {
            Student stud=new Student();
            string result=stud.Display();
            Console.WriteLine(result);

            Student s1= new Student(2,"Nina");
            Console.WriteLine( s1.Display());

        }
    }
}
