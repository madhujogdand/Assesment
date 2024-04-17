using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Write a program to calculate area of an equilateral triangle.
namespace Assesment.FundaAssignment
{
    public class AreaOfTriangle
    {
        static double CalculateArea(double s)
        {
            double area = (Math.Sqrt(3) / 4) * Math.Pow(s, 2);
            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a side");
            double side=Convert.ToDouble(Console.ReadLine());

            double area=CalculateArea(side);
            Console.WriteLine("Area of equilateral triangle is: "+area);
        }
    }
}
