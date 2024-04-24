using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*12.WAP to reverse the array itself, don’t print array in reverse – I want current array 
 * reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be 
 * [78, 37, 29, 45, 90, 3] without using temporary array.*/
namespace Assesment.ArrayAssignments
{
    public class ReverseArray
    {
            
        static void RevArray(int[] arr)
        { 
          int n=arr.Length;

            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                // Swap elements
                arr[start] = arr[start] + arr[end];
                arr[end] = arr[start] - arr[end];
                arr[start] = arr[start] - arr[end];
                start++;
                end--;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };

            RevArray(arr);

            Console.WriteLine("Reversed array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
