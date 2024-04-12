using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class FirstProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"Addition is {c}");
        }
    }
}
