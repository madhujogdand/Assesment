using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"Factors of {n} are {i}");
                }
            }
        }
    }
}
