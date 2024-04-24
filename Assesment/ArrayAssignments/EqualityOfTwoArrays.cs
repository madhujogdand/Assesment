using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*13.Write a  program to test the equality of two arrays. Means e.g arr1[] = [12,22,32,42,52,62] 
 * and arr2[] = [52, 22, 62, 12, 42, 22] Here both arrays are equal.*/
namespace Assesment.ArrayAssignments
{
    public class EqualityOfTwoArrays
    {
        static bool CheckEquality(int[] arr1, int[] arr2)
        {
            
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

           
            Array.Sort(arr1);
            Array.Sort(arr2);

          
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }

       
        static void Main(string[] args)
        {
           
            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 22 };

          
            bool isEqual = CheckEquality(arr1, arr2);

           
            if (isEqual)
            {
                Console.WriteLine("Both arrays are equal.");
            }
            else
            {
                Console.WriteLine("Arrays are not equal.");
            }
        }
    }
}
