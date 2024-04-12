using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class GreaterNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater");

            }
            else if (num2>num1) {
                Console.WriteLine($"{num2} is greater");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }
        }
    }
}
