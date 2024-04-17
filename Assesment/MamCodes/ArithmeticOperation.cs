using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to overload the static metohd to calculate all the arithmetic operations*/
namespace Assesment.MamCodes
{
    public class ArithmeticOperation
    {
        class Calculate
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static int Sub(int a, int b)
            {
                return a - b;
            }

            public static int Multiply(int a, int b)
            {
                return a * b;
            }

            public static double Div(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return double.NaN;
                }
                return a / b;
            }

        }
        static void Main(string[] args)
        {
            int add=Calculate.Add(5,7);
            Console.WriteLine("Addition: "+add);

            int sub = Calculate.Sub(10, 7);
            Console.WriteLine("Subtraction: " + sub);

            int multiply = Calculate.Multiply(5, 7);
            Console.WriteLine("Multiplication: " + multiply);

            double div = Calculate.Div(49, 7);
            Console.WriteLine("Division: " + div);

            double div1 = Calculate.Div(5, 0);
            Console.WriteLine("Division: " + div1);

        }
    }
}
