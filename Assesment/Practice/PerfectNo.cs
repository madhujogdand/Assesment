using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Practice
{
    public class PerfectNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine($"{n} is perfect no.");
            }

            else
            {
                Console.WriteLine($"{n} is not perfect no.");
            }




        }
    }
}
