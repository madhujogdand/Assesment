using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to findout sum of prime no from array*/
namespace Assesment.MamCodes
{
    public class SumOfPrimeNoInArray
    {
        static bool CheckPrime(int n)
        {
        
            if (n<=1)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                { 
                  return  false;
                    
                }
               
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arr = {3,8,7,5,8,11,4,19,6,23 };
            int sum = 0;
            foreach (int i in arr)
            {
                Console.WriteLine(i);
                if (CheckPrime(i))
                {
                    sum += i;
                }

            }
            Console.WriteLine("Sum of prime no in array:"+sum);
        }
    }
}
