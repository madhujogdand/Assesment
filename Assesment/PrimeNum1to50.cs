using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    // prime no. between 1 tp 50
    internal class PrimeNum1to50
    {
       static bool CheckPrime(int n)
        {
            Boolean status = true;

            if (n <= 1)
            { 
               status= false;
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
            for (int i = 0; i <= 50; i++)
            {
                if (CheckPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
