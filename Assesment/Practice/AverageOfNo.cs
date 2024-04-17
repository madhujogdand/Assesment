using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Practice
{
    public class AverageOfNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr num1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enetr num2");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enetr num3");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = (a + b + c) / 3;

            Console.WriteLine($"Average of 3 no. is {d}");
        }
    }
}
