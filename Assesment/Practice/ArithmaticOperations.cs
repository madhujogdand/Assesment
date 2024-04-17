using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Practice
{
    public class ArithmaticOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition is: " + (a + b));
            Console.WriteLine("Subtraction is: " + (a - b));
            Console.WriteLine("Multiplication is: " + a * b);
            Console.WriteLine("Division is: " + a / b);
            Console.WriteLine("Modulus is: " + a % b);
        }
    }
}
