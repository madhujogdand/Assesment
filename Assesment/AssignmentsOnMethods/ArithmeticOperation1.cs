using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*9) Write Program for arithmetic  operation for each operation write separate Method using parameter Passing*/
namespace Assesment.AssignmentsOnMethods
{

    public class ArithmeticOper
    {
       

        public void Addition(int a, int b)
        { 
          int add=a+b;
            Console.WriteLine("Addition is: "+add);
        }

        public void Subtraction(int a, int b)
        {
            int sub= a - b;
            Console.WriteLine("Subtraction is: " + sub);
        }

        public void Multiplication(int a, int b)
        {
            int multiply = a * b;
            Console.WriteLine("Multiplication is: " + multiply);
        }

        public void Division(int a, int b)
        {
            int div= a /b;
            Console.WriteLine("Division is: " + div);
        }
        public void Modulus(int a, int b)
        {
            int mod = a % b;
            Console.WriteLine("Modulus is: " + mod);
        }
    }
    public class ArithmeticOperation1
    {
        static void Main(string[] args)
        {
            ArithmeticOper ao = new ArithmeticOper();
            ao.Addition(8,8);
            ao.Subtraction(9,5);
            ao.Multiplication(4,6);
            ao.Division(45,8);
            ao.Modulus(7,9);
        }
    }
}
