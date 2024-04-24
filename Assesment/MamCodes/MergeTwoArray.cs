using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to merge two array into the third array
namespace Assesment.MamCodes
{
    public class MergeTwoArray
    {
        static int[] MergeArray(int[] arr1, int[] arr2)
        {
            int[] newArray = new int[arr1.Length+arr2.Length];
            int index = 0;

            foreach (int item in arr1) 
            {
                newArray[index] = item;
                index++;
            }
            foreach (int item in arr2)
            {
                newArray[index] = item;
                index++;
            }

            return newArray;
        }
        static void Main(string[] args)
        {
            int[] arr1 = {10,20,30,40 };
            int[] arr2 = { 11, 22, 33 };

            int[] Merge=MergeArray(arr1, arr2);

            Console.WriteLine("After merge two array:");
            foreach (int item in Merge)
            {
                Console.WriteLine(item+ " " );
            }

        }
    }
}
