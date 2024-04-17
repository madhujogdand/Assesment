using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class ArrayMethods
    {
        static void Main(string[] args)
        {
            int[] arr=new int[] {80,45,12,78,1 };
            //print as it is
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            //sort the elements
            Array.Sort(arr);
            Console.WriteLine("----After sort----");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            //Print in reverse order
            Array.Reverse(arr);
            Console.WriteLine("----After Reverse----");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            //copy 3 elements 45,12, 1 in nw array
            int[] arr1 = new int[3];

            Array.Copy(arr, 2, arr1, 0, 3);
            Console.WriteLine("----After Copying elements----");
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }

            //Clear elements

            Array.Clear(arr,0,3);
            Console.WriteLine("----After Clear----");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            string[] names = { "Rina", "Meena", "Sita", "Geeta", "Ritu" };
            //print as it is
            Console.WriteLine("---print names---");
            foreach (string n in names)
            { 
                Console.WriteLine(n);
            }

            //sort the elements
            Array.Sort(names);
            Console.WriteLine("----After sort----");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            //Print in reverse order
            Array.Reverse(names);
            Console.WriteLine("----After Reverse----");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            //copy 3 elements 45,12, 1 in nw array
            string[] names1 = new string[3];

            Array.Copy(names, 1, names1, 0, 2);
            Console.WriteLine("----After Copying elements----");
            foreach (string n in names1)
            {
                Console.WriteLine(n);
            }

            //Clear elements

            Array.Clear(names, 0, 3);
            Console.WriteLine("----After Clear----");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

        }
    }
}
