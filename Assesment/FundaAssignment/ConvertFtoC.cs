using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
namespace Assesment.FundaAssignment
{
    public class ConvertFtoc
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double c = (f-32)*5/9;

            Console.WriteLine($"Temperature in  Celsius:{c}");
        }
    }
}
