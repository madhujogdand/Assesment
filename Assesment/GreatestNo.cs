using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to find out the greatest number between three no
namespace Assesment
{
    public class GreatestNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First no");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second no");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third no");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>=b && a>=c)
                Console.WriteLine($"{a} is greater");
            else if(b>=a && b>=c)
                Console.WriteLine($"{b} is greater");
            else
                Console.WriteLine($"{c} is greater");
        }
    }
}
