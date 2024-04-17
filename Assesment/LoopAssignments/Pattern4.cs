using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*   * * * * * * *
     * * * * * *
     * * * * *
     * * * *
     * * *
     * *
     * 
 */



namespace Assesment.LoopAssignments
{
    public class Pattern4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int n=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
