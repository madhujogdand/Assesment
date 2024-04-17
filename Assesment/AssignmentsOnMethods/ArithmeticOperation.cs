using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8)Write  Program for arithmetic  operation for each operation write separate Method.*/
namespace Assesment.AssignmentsOnMethods
{

    public class ArithmeticOperations
    {
        int a = 20;
        int b = 10;

        public void Addition()
        { 
          int add=a+b;
            Console.WriteLine("Addition is: "+add);
        }

        public void Subtraction()
        {
            int sub= a - b;
            Console.WriteLine("Subtraction is: " + sub);
        }

        public void Multiplication()
        {
            int multiply = a * b;
            Console.WriteLine("Multiplication is: " + multiply);
        }

        public void Division()
        {
            int div= a /b;
            Console.WriteLine("Division is: " + div);
        }
        public void Modulus()
        {
            int mod = a % b;
            Console.WriteLine("Modulus is: " + mod);
        }
    }
    public class ArithmeticOperation
    {
        static void Main(string[] args)
        {
            ArithmeticOperations ao = new ArithmeticOperations();
            ao.Addition();
            ao.Subtraction();
            ao.Multiplication();
            ao.Division();
            ao.Modulus();
        }
    }
}
