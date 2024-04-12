using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Factorial
    {
        static void Main(string[] args)
        {
            long fact = 1;

            Console.WriteLine("Enter no");
            int n=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                fact *=i;
            }
            Console.WriteLine($"Factorial of {n} is {fact}");
        }
    }
}
