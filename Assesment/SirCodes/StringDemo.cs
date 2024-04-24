using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class StringDemo
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str);
            Console.WriteLine($"Address of str {str.GetHashCode()}");

            str = "Hello Hi";
            Console.WriteLine("---After changed value---");
            Console.WriteLine(str);
            Console.WriteLine($"Address of str {str.GetHashCode()}");

            str = str + " good morning";
            Console.WriteLine("---After changed value---");
            Console.WriteLine(str);
            Console.WriteLine($"Address of str {str.GetHashCode()}");
        }
    }
}
