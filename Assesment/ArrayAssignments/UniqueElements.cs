using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.WAP to print all unique elements in the array.*/
namespace Assesment.ArrayAssignments
{
    public class UniqueElements
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 2, 4, 1, 5 };

            bool isDuplicate;
            Console.WriteLine("Unique elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                isDuplicate = false;


                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {

                        isDuplicate = true;
                        break;
                    }
                }
            
                if (!isDuplicate)
                {
                Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
