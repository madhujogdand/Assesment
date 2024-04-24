using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.WAP to put even and odd elements of array in two separate arrays.*/
namespace Assesment.ArrayAssignments
{
    public  class EvenOddInSeparateArrays
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] evenArr=new int[num.Length];
            int[] oddArr = new int[num.Length];

            int evenIndex = 0;
            int oddIndex = 0;

            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    evenArr[evenIndex] = i;
                    evenIndex++;
                }
                else {
                    oddArr[oddIndex] = i;
                    oddIndex++;
                }
            }

            Array.Resize(ref evenArr, evenIndex);
            Array.Resize(ref oddArr, oddIndex);

            Console.WriteLine("Even elements:");
            foreach (int i in evenArr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Odd elements:");
            foreach (int i in oddArr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
