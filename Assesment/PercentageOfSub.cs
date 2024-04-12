using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to calculate percentage of 5 sub marks
namespace Assesment
{
    public class PercentageOfSub
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of sub1");
            double s1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of sub2");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of sub3");
            double s3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of sub4");
            double s4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks of sub5");
            double s5 = Convert.ToDouble(Console.ReadLine());

            double total = s1 + s2 + s3 + s4 + s5;
            double percentage = (total/5.0)*100;

            Console.WriteLine($"Percentage of 5 sub is {percentage}%");

        }
    }
}
