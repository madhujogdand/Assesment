using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.WAP to find the second smallest element in an array.*/
namespace Assesment.ArrayAssignments
{
    public class SecondSmallest
    {
        static int FindSecondSmallest(int[] arr)
        {

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;


            foreach (int num in arr)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }


            return secondSmallest;
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 4, 8, 1, 15, 7, 3 };


            int secondSmallest = FindSecondSmallest(arr);


            Console.WriteLine("Second smallest element in the array: " + secondSmallest);
        }
    }
}
