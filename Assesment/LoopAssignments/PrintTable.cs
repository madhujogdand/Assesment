using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.WAP to print table of given no
namespace Assesment.LoopAssignments
{
    public class PrintTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no to print table");
            int n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Table on {n} is: ");
            for (int i = 1; i <= 10; i++)
            {
                int table = n * i;
                Console.WriteLine($"{n}*{i}={table}");
            }
        }
    }
}
