using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8.Write a Java program to check whether a number is even or odd  
namespace Assesment.FundaAssignment
{
    public class EvenOddNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no.");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even");
            }
            else
            {
                Console.WriteLine($"{num} is Odd");
            }

        }
    }
}
