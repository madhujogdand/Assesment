using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Write a  program to enter P, T, R and calculate Compound Interest.
namespace Assesment.FundaAssignment
{
    public class CompoundInterest
    {
        static double CalCI(double p, double t, double r)
        {
            r /= 100;


            double compoundInterest = p * Math.Pow(1 + r, t) - p;

            return compoundInterest;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter principle amount");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter time in years");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rate of interest");
            double r = Convert.ToDouble(Console.ReadLine());



            double CI = CalCI(p, t, r);
            Console.WriteLine("Compound Interest is: " + CI);

        }
    }
}
