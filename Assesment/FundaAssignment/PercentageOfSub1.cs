using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write a program to enter marks of five subjects and calculate total, average and percentage
namespace Assesment.FundaAssignment
{
    public class PercentageOfSub1
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
            Console.WriteLine($"Total of 5 subjects is {total}");
            double average = total / 5;
            Console.WriteLine($"Average of 5 subjects is {average}");
            double percentage = total/5;
            Console.WriteLine($"Percentage of 5 subects is {percentage}%");

        }
    }
}
