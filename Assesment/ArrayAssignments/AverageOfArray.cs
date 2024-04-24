using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.Write two methods that return the average of an array with following headers.
i.	public static int average(int[] array)
ii.	public static double average(double[] array).
iii.	Write main and invoke the 2 methods.
*/
namespace Assesment.ArrayAssignments
{
    public class AverageOfArray
    {
        public static int Average(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum/array.Length;
        }

        public static double Average(double[] array)
        {
            double sum = 0;
            foreach (double d in array)
            {
                sum += d;
            }
            return sum / array.Length;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Average of int array: "+Average(arr));

            double[] arr2 = { 10.50, 20.30, 30.40, 40, 50, 50, 60 };
            Console.WriteLine($"Average of double array: " + Average(arr2));
        }
    }
}
