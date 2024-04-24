using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.WAP sort array elements in ascending order.*/
namespace Assesment.ArrayAssignments
{
    public class SortInAscendingOrder
    {
        static void SortArray(int[] arr)
        { 
           int n=arr.Length;

            for (int i=0; i<n-1; i++) 
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (arr[i] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 9, 6, 1, 8, 5, 2,9 };

            SortArray(arr);

            Console.WriteLine("Sorted array in ascending order:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
