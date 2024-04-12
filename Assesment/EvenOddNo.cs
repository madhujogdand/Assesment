using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class EvenOddNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no.");
            int num=Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even");
            }
            else
            {
                Console.WriteLine($"{num} is Odd");
            }
            
        }
    }
}
