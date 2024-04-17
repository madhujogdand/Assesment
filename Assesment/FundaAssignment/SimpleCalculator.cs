using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Write a Java program to create Simple Calculator  
namespace Assesment.FundaAssignment
{
    public class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num1");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a num2");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose Operation");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Modulus");

            Console.WriteLine("Enter a choice");
            int choice=Convert.ToInt32(Console.ReadLine());

            int res;
            switch (choice)
            { 
              case 1:
                     res = a + b;
                    Console.WriteLine($"Addition is {res}");
                    break;

                case 2:
                    res = a - b;
                    Console.WriteLine($"Subtraction is {res}");
                    break;

                case 3:
                    res= a * b;
                    Console.WriteLine($"Multiplication is {res}");
                    break;

                case 4:
                    res = a / b;
                    Console.WriteLine($"Division is {res}");
                    break;

                case 5:
                    res = a % b;
                    Console.WriteLine($"Modulus is {res}");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
    }
}
