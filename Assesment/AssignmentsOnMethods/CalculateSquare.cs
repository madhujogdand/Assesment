using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.write a program to calculate square for given number using no return type ,with return type,
with parameter passing, with parameter and return type.
*/
namespace Assesment.AssignmentsOnMethods
{
    public class CalSquare
    { 
       public void SquareCal()
        {
            int a = 6;
            int square = a * a;
            Console.WriteLine($"Square of {a} is: "+square);
        }

        public int SquareCalWithReturnType()
        {
            int a = 6;
            return a * a;
           
        }

        public void SquareCalWithParameters(int a)
        {
            int square = a * a;
            Console.WriteLine("Square is:"+square);
        }

        public int SquareCalWithParameterReturntype(int a)
        {
            return a * a;
           
        }

    }
    public class CalculateSquare
    {
        static void Main(string[] args)
        {
            CalSquare cs = new CalSquare();
           
            cs.SquareCal();
            
            int square=cs.SquareCalWithReturnType();
            Console.WriteLine($"Square is: " + square);
           
            cs.SquareCalWithParameters(8);
            
            Console.WriteLine("Square is: "+cs.SquareCalWithParameterReturntype(7));
        }
    }
}
