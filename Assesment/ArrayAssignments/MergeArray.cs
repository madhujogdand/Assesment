using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*10.WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.*/
namespace Assesment.ArrayAssignments
{
    public class MergeArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 6, 5 };
            int[] arr2 = { 2, 5, 7, 8, 3, 9 };

            int len1=arr.Length;
            int len2=arr2.Length;

            int lenMerged=len1+ len2;

            int[] mergedArray = new int[lenMerged];

            
            for (int i = 0; i < len1; i++)
            {
                mergedArray[i] = arr[i];
            }

            int mergedIndex = len1;
            for (int i = 0; i < len2; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < len1; j++)
                {
                    if (arr2[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    mergedArray[mergedIndex] = arr2[i];
                    mergedIndex++;
                }
            }

            // Print the merged array
            Console.WriteLine("Merged array with unique elements:");
            for (int i = 0; i < mergedIndex; i++)
            {
                Console.Write(mergedArray[i] + " ");
            }
        }
    }
}
