using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class StringBuildrDemo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb);
            Console.WriteLine($"Address of sb {sb.GetHashCode()}");

            Console.WriteLine("---After changed value---");
            sb.Append(" Hello to all");
            Console.WriteLine(sb);
            Console.WriteLine($"Address of sb {sb.GetHashCode()}");

        }
    }
}
