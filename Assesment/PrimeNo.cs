using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    // single prime no
    public class PrimeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int n=Convert.ToInt32(Console.ReadLine());

            Boolean status = true;

            if (n <= 1)
            {
                status= false;
            }

            else
            {
               
                    if (n % 2 == 0)
                    {
                        status = false;
                        
                    }
                
            }

            if (status == true)
            {
                Console.WriteLine($"{n} is prime no");
            }
            else
            {
                Console.WriteLine($"{n} is not prime no");
            }
        }
    }
}
