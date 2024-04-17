using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*         *
 *        * *
 *       * * *
 *      * * * *
 *     * * * * *
 *    * * * * * *
    
 */

namespace Assesment.LoopAssignments
{
    public class Pattern3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int n=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
