using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*14.WAP to replace all negative value with its immediate left elements square. 
 * Means arr[] = [12,3,-19,29,5, -61,44,7, -9] Output array will be [12,3,9,29,5,25,44,7,49].*/
namespace Assesment.ArrayAssignments
{
    public class ReplaceNegatives
    {
        static void ReplaceNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && i > 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1]; // Square of immediate left element
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            ReplaceNegative(arr);

            Console.WriteLine("Modified array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
