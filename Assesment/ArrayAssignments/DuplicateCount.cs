using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.WAP to find and count total number of duplicate elements in an array.*/
namespace Assesment.ArrayAssignments
{
    public class DuplicateCount
    {
        static void Main(string[] args)
        {
            int[] arr = {2,4,1,6,2,4,2};

            int count = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                bool isDuplicate = false;
                for (int j = i+1;j<arr.Length;j++)
                { 
                   if (arr[j] == arr[i])
                    { 
                        isDuplicate = true;
                        break;
                      
                    }
                  
                }
                if (isDuplicate)
                {
                   count++;
                }
                
            }
            Console.WriteLine($"Total number of duplicate elements in the array: {count}");
        }
    }
}
