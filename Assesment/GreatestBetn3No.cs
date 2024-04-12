using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to find out the greatest no no. between three no using ternary operator
namespace Assesment
{
    public class GreatestBetn3No
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First no");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second no");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third no");
            int c = Convert.ToInt32(Console.ReadLine());

            int greatest = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

            Console.WriteLine($"The greatest no is: {greatest}");

        }
    }
}
