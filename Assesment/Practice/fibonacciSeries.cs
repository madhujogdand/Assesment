using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Practice
{
    public class fibonacciSeries
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;

            Console.WriteLine("Enetr num");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series is: ");

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(n1);
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }


        }
    }
}
