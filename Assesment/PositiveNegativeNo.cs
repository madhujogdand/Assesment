using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PositiveNegativeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int num=Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else {
                Console.WriteLine($"{num} is negative");
            }
        }
    }
}
