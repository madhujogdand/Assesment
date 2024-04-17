using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7) Create class student and write a meaningful program with 3 methods (1 with return type (calculating percentage), 1 without return
type (displaying student data), 1 with parameter list).
*/
namespace Assesment.AssignmentsOnMethods
{
    public class StudentInfo
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public int Sub1 { get; set; }
        public int Sub2 { get; set; }
        public int Sub3 { get; set; }

        public double CalPercentage()
        {
            double total = Sub1 + Sub2 + Sub3;
            double percentage = total / 3;
            return percentage;
        }

        public void DisplayData()
        {
            Console.WriteLine("Sudetnt Roll No:"+Rollno);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Marks of 3 subjects:");
            Console.WriteLine("Subject 1 marks: " + Sub1);
            Console.WriteLine("Subject 2 marks: " + Sub2);
            Console.WriteLine("Subject 3 marks: " + Sub3);
        }

        public void ModifyData(int id, string name, int sub1,int sub2, int sub3)
        {
            Rollno = id;
            Name = name;
            Sub1 = sub1;
            Sub2 = sub2;
            Sub3 = sub3;
        }
    }

    public class StudentDetails
    {
        static void Main(string[] args)
        {
            StudentInfo si=new StudentInfo();
            si.Rollno = 1;
            si.Name = "Madhu";
            si.Sub1 = 67;
            si.Sub2 = 90;
            si.Sub3 = 89;
            si.DisplayData();
            double per = si.CalPercentage();
            Console.WriteLine($"Percentage:{per}% ");

           

            si.ModifyData(2, "Rina", 56, 78, 89);
            si.DisplayData();
            double per2 = si.CalPercentage();
            Console.WriteLine($"Percentage:{per2}% ");


        }
    }
}
