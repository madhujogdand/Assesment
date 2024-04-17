using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Write a  program to find sum of all even numbers between 1 to n. 
namespace Assesment.LoopAssignments
{
    public class SumOfEvenNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine($"Sum of even numbers between 1 to {n} is {sum}");
        }
    }
}
