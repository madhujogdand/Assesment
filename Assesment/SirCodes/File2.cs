using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public partial class Calcy
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }

        public void Multiply(int a, int b)
        {
            int res = a * b;
            Print(res);
        }

        partial void Print(int c)
        {
            Console.WriteLine($"Result={c}");
        }
    }

    public class PartialDemo
    {
        static void Main(string[] args)
        {
            Calcy c1 = new Calcy();

            Console.WriteLine(c1.Add(80,20));
            Console.WriteLine(c1.Sub(30,20));
            c1.Multiply(8, 5);
            c1.Div(10, 5);
        }
    }
}
