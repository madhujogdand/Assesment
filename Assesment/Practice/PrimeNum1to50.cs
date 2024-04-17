using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Practice
{
    // 9.Find all prime number between 1 to 50
    public class PrimeNum1to50
    {
        static bool checkPrime(int n)
        {
            bool status = true;

            if (n <= 1)
            {
                status = false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    status = false;
                    break;
                }
            }
            return status;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (checkPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
