using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.WAP to print all negative elements in an array and also count total number of negative 
 * elements in an array.*/
namespace Assesment.ArrayAssignments
{
    public class NegativeElementsCount
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, 2, 6, -4, 3, -1, -8 };

            int count = 0;
            Console.WriteLine("Negative elements in the array:");
            foreach (int i in arr)
            {
                if (i < 0)
                { 
                Console.WriteLine(i);
                    count++;
                }
               
            }
            Console.WriteLine($"Total number of negative elements: {count}");


        }
    }
}
