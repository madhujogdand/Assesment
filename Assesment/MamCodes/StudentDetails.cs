using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to create student class student contains id, name, 3 sub marks, create 1st method to accept the student 
 details, 2nd method to calculate percentage for 3 sub marks, 3rd method to display all student details 
including percentage*/
namespace Assesment.MamCodes
{
    public class Student
    {
        public int Id { get;set; }
        public string Name { get; set; }

        public int Sub1 { get; set; }
        public int Sub2 { get; set; }
        
        public int Sub3 { get; set; }

        public void AcceptDetails(int id, string name, int sub1, int sub2, int sub3)
        {
            Id = id;
            Name = name;
            Sub1 = sub1;
            Sub2 = sub2;
            Sub3 = sub3;
        }

        public int CalPercentage()
        {
            int total = Sub1 + Sub2 + Sub3;
            int percentage=total / 3;
            return percentage;
        }

        public void DisplayDetails()
        {
            int percentage = CalPercentage();
            Console.WriteLine("Student Id:"+Id);
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Subject1 Marks:"+Sub1);
            Console.WriteLine("Subject2 Marks:" + Sub2);
            Console.WriteLine("Subject3 Marks:" + Sub3);
            Console.WriteLine("Percentage:"+percentage+"%");
        }

    }
    public class StudentDetails
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.AcceptDetails(1, "Nita", 78, 89, 90);
            stud.DisplayDetails();

        }
    }
}
