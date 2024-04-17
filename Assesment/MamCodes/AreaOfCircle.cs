using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to calculate area of circle
namespace Assesment.MamCodes
{
    public class AreaOfCircle
    {
        static void Main(string[] args)
        {

            double a, pi = 3.14, r;

            Console.WriteLine("Enter radius");
            r = Convert.ToDouble(Console.ReadLine());

            a = pi * r * r;

            Console.WriteLine($"Area of circle is {a}");

        }
    }
}
