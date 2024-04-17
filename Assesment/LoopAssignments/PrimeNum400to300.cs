using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.LoopAssignments
{
    // 9.Find all prime number between 400 to 300;
    public class PrimeNum400to300
    {
       static bool CheckPrime(int n)
        {
            Boolean status = true;

           
            for (int i = 2; i<n; i++)
            {
                if (n % i == 0)
                {
                    status = false;
                    break;
                }
            }
           return status;
        }
        static void Main(string[] args)
        {
            for (int i = 400; i >= 300; i--)
            {
                if (CheckPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
