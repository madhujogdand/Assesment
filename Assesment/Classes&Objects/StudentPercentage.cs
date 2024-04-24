using Assesment.FundaAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.Create Student class with roll no, name, accept 3 subjects marks from constructor. 
 * Calculate the total marks & percentage. Display student details using ToString()*/
namespace Assesment.Classes_Objects
{
    public class Student
    {
        private int rollno;
        private string name;
        private double sub1;
        private double sub2;
        private double sub3;
        private double totalMarks;
        private double percentage;

        public Student(int rollno, string name,double sub1,double sub2, double sub3)
        {
            this.rollno = rollno;
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;

            totalMarks = sub1 + sub2 + sub3;
            percentage = totalMarks / 3;

        }

        public override string ToString()
        {
            return $"RollNo:{rollno},\nName:{name},\nSub1 Marks:{sub1},\nSub2 Marks:{sub2},\nSub3 Marks:{sub3},\nTotal Marks:{totalMarks},\nPercentage:{percentage}%\n";
        }

    }
    public class StudentPercentage
    {
        static void Main(string[] args)
        {
            Student s = new Student(101, "Neha", 89, 90, 78.90);
            Console.WriteLine(s.ToString());
                
        }
    }
}
