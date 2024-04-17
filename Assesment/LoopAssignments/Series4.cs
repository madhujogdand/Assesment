using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Print Series 2 -4 6 -8………n terms
namespace Assesment.LoopAssignments
{
    public class Series4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int n=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //int res = i % 2 == 0 ? i : -i;
                int res = i * (i % 2 == 0 ? -1 : 1) * 2;
                Console.Write(res+" ");
            }
            Console.WriteLine();
        }
    }
}
