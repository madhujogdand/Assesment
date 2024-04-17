using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    1
    2 3
    4 5 6
    7 8 9 10
    11 12 13 14 15
    16 17 18 19 20 21
    22 23 24 25 26 27 28
 
 */

namespace Assesment.LoopAssignments
{
    public class Pattern8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of rows");
            int n=Convert.ToInt32(Console.ReadLine());

            int count = 1;
            for (int i = 1; i <= n; i++)
            {
               
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count+" ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
