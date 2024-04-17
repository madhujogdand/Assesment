using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
namespace Assesment.FundaAssignment
{
    public class ConvertCtoF
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 1.8) + 32;

            Console.WriteLine($"Temperature in Fahrenheit:{f}");
        }
    }
}
