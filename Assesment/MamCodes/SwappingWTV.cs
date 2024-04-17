using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to perform swapping of 2 no without using third variable
namespace Assesment.MamCodes
{
    public class SwappingWTV
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second num");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: ");
            Console.WriteLine("First num: " + num1);
            Console.WriteLine("Second num: " + num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After swapping: ");
            Console.WriteLine("First num: " + num1);
            Console.WriteLine("Second num: " + num2);
        }
    }
}
