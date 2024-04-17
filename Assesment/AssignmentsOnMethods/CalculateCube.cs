using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 12) write a program to calculate cube for given number using no return type ,with return type,
with parameter passing, with parameter and return type.

*/
namespace Assesment.AssignmentsOnMethods
{
    public class CalCube
    { 
       public void CubeCal()
        {
            int a = 6;
            int cube = a*a*a;
            Console.WriteLine($"Cube of {a} is: "+cube);
        }

        public int CubeCalWithReturnType()
        {
            int a = 6;
            return a * a*a;
           
        }

        public void CubeCalWithParameters(int a)
        {
            int cube = a * a * a;
            Console.WriteLine("Cube is:"+cube);
        }

        public int CubeCalWithParameterReturntype(int a)
        {
            return a * a*a;
           
        }

    }
    public class CalculateCube
    {
        static void Main(string[] args)
        {
            CalCube cb = new CalCube();
           
            cb.CubeCal();
            
            int cube=cb.CubeCalWithReturnType();
            Console.WriteLine($"Cube is: " + cube);
           
            cb.CubeCalWithParameters(8);
            
            Console.WriteLine("Cube is: "+cb.CubeCalWithParameterReturntype(7));
        }
    }
}
