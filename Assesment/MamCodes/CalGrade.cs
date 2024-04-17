using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to calculate the 5 sub percentage & as per the percentage display grade
namespace Assesment.MamCodes
{
    public class CalGrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of sub1");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of sub2");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of sub3");
            double s3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of sub4");
            double s4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of sub5");
            double s5 = Convert.ToDouble(Console.ReadLine());

            double total = s1 + s2 + s3 + s4 + s5;
            double percentage = total / 5;

            Console.WriteLine($"Percentage of 5 sub is {percentage}%");

            if (percentage >= 90)
                Console.WriteLine($"Grade id A+");
            else if (percentage >= 75)
                Console.WriteLine($"Grade id A");
            else if (percentage >= 60)
                Console.WriteLine($"Grade id B");
            else if (percentage >= 45)
                Console.WriteLine($"Grade id C");
            else if (percentage > 35)
                Console.WriteLine($"Grade id D");
            else
                Console.WriteLine("Fail");
        }
    }
}
