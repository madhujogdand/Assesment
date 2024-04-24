using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.Create class Student, with roll no , name , percentage auto implemented properties.
 * Use property initialize syntax to assign the values. Print the student details*/
namespace Assesment.Classes_Objects
{
    public class student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public double Percentage { get; set; }
    }
    public class StudentDetails
    {
        static void Main(string[] args)
        {
            // property initialize syntax

            student s=new student();
            s.RollNo = 101;
            s.Name = "Shivansh";
            s.Percentage = 90.89 ;

            Console.WriteLine($"Student details: \nRoll No:{s.RollNo},\nName:{s.Name},\nPercentage:{s.Percentage}%");
        }
    }
}
