using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to calculate area of triangle
namespace Assesment
{
    public class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            double a;

            Console.WriteLine("Enter base");
            double b=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height");
            double h = Convert.ToDouble(Console.ReadLine());

            a = 0.5 * b * h;

            Console.WriteLine($"Area of Triangle is {a}");

        }
    }
}
