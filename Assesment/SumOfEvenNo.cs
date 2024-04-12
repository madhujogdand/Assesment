using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SumOfEvenNo
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
             
                if (i % 2 == 0)
                { 
                   sum += i;
                }
              
            }
            Console.WriteLine($"Sum of even no is {sum}");
        }
    }
}
