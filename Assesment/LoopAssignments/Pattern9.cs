using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    101010101
    010101010
    101010101
    010101010
    101010101
    010101010
    101010101
    010101010
    101010101
    010101010
 */

namespace Assesment.LoopAssignments
{
    public class Pattern9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of rows");
            int n=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if ((i+j) % 2 == 0)
                    {
                        Console.Write("1");
                       
                    }
                    else
                    {
                        Console.Write("0");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
