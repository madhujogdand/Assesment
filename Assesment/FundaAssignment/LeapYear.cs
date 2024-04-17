using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Write a program to check whether a year is leap year or not 
namespace Assesment.FundaAssignment
{
    public class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year=Convert.ToInt32(Console.ReadLine());

            if((year%4==0 && year%100!=0)||year%400==0)
                Console.WriteLine($"{year} is aleap year");
            else
                Console.WriteLine($"{year} is not a leap year");
        }
    }
}
