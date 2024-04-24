using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.WAP to find the maximum and minimum value in an array.*/
namespace Assesment.ArrayAssignments
{
    public class MaxMinInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 8, 5, 6, 0, 8, 2, 9 };

            int max = arr[0];
            int min = arr[1];

            for (int i = 1; i < arr.Length; i++) 
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }
                if (arr[i] < min)
                {
                    min = arr[i];

                }

            }
            Console.WriteLine($"Maximum value in the array: {max}");
            Console.WriteLine($"Minimum value in the array: {min}");
        }
    }
}
