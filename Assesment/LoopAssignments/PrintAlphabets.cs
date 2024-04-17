using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Write a program to print all alphabets from a to z. - using  for loop
namespace Assesment.LoopAssignments
{
    public class PrintAlphabets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("alphabets from a to z");
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("alphabets from a to z using range");
            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine((char)i);
            }
           
        }
    }
}
