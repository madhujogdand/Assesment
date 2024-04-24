using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.WAP to search for a given number in an array and accordingly print the index if exists*/
namespace Assesment.ArrayAssignments
{
    public class SearchElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            int searchElement = 6;

            bool found= false;

            for (int i = 0;i<arr.Length;i++)
            {
                if (arr[i] == searchElement)
                {
                    Console.WriteLine($"The number {searchElement} is found at index {i}.");
                    found = true;
                    break;
                }
               
            }
            if(!found)
            {
                Console.WriteLine($"The number {searchElement} is not present in the array .");
            }
        }
    }
}
