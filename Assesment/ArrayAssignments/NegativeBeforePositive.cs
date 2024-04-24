using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*15.WAP to arrange the elements of an given array of integers where all negative integers 
 * appear before all the positive integers.*/
namespace Assesment.ArrayAssignments
{
    public class NegativeBeforePositive
    {
        static void LeftShift(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                // Move left pointer until it finds a positive integer
                while (left < right && arr[left] < 0)
                {
                    left++;
                }

                // Move right pointer until it finds a negative integer
                while (left < right && arr[right] >= 0)
                {
                    right--;
                }

                // Swap the elements at left and right pointers
                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, -3, 19, -29, 5, -61, 44, -7, 9 };

           
            LeftShift(arr);

            
            Console.WriteLine("Left shift negatives in array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
