using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to find out the no is positive, negative or 0 using ternary operator
namespace Assesment.MamCodes
{
    public class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entyer nunmber");
            int num = Convert.ToInt32(Console.ReadLine());

            string res = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";

            Console.WriteLine($" The number {num} is {res}.");
        }
    }
}
