using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to search an element into the array*/
namespace Assesment.MamCodes
{
    public class SearchElementInArray
    {
        static int Search(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==key)
                    return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = {2,7,3,8,5,9,4,0,5,1};


            int searchElement = 8;

          int index= Search(arr, searchElement);

            if (index != -1)
            {
                Console.WriteLine($"Element {searchElement} found at index {index}");
            }
            else
            {
                Console.WriteLine($"Element {searchElement} not found in the array");
            }



        }
    }
}
