using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to addition of 3*3 matrix , accept data from user*/
namespace Assesment.SirCodes
{
    public class MatrixAddition
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] add = new int[3, 3];

            Console.WriteLine("First array");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write($"Enter element [{i + 1},{j + 1}]: ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Second array");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write($"Enter element [{i + 1},{j + 1}]: ");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Addition of 3*3 matrix is");
            for (int i = 0; i < add.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write($"[{i + 1},{j + 1}]: ");
                    add[i, j] = arr1[i, j] + arr2[i, j];
                    Console.WriteLine(add[i,j]+" ");
                }
            }
        }
    }
}
