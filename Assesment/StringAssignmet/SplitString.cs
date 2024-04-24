using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.WAP to split string into 2 tokens where string is “HELLO$WORLD”*/

namespace Assesment.StringAssignmet
{
    public class SplitString
    {
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";

            string[] splitstr = str.Split('$');

          
            if (splitstr.Length == 2)
            {
                Console.WriteLine("First Token: " + splitstr[0]);
                Console.WriteLine("Second Token: " + splitstr[1]);
            }
            else
            {
                Console.WriteLine("Invalid input format. Expected exactly one '$' delimiter.");
            }
        }


    }
}
