using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    internal class JaggedArrayDemo
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[] { 1, 2, 3, 4, 5 };
            arr[1] = new int[] { 11, 33, 44 };
            arr[2] = new int[] { 10, 20};
            arr[3] = new int[] { 100 };

            //Using for loop
            Console.WriteLine("---Using For Loop---");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i] [j] }");
                }
                Console.WriteLine();
            }

            //using foreach loop
            Console.WriteLine("---Using Foreach---");
            foreach (int[] item in arr)
            {
                foreach (int i in item)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }


        }
    }
}
