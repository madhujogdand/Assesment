using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*10) Write  Program for arithmetic  operation for each operation write separate Method using parameter 
 * Passing and return type*/
namespace Assesment.AssignmentsOnMethods
{

    public class Operations
    {
       

        public int Addition(int a, int b)
        { 
          return a+b;
          
        }

        public int Subtraction(int a, int b)
        {
           return a - b;
          
        }

        public int Multiplication(int a, int b)
        {
           return a * b;
         
        }

        public double Division(int a, int b)
        {
            return a /b;
         
        }
        public int Modulus(int a, int b)
        {
           return a % b;
            
        }
    }
    public class ArithmeticOperationRV
    {
        static void Main(string[] args)
        {
            Operations ao = new Operations();
           int add=ao.Addition(8,8);
            Console.WriteLine("Addition of is:"+add);
            int sub=ao.Subtraction(9,5);
            Console.WriteLine("Subtraction is:" + sub);
            int multiply=ao.Multiplication(4,6);
            Console.WriteLine("Multiplication is:" + multiply);
            double div=ao.Division(45,8);
            Console.WriteLine("Division is:" + div);
            int mod=ao.Modulus(7,9);
            Console.WriteLine("Modulus is:" + mod);
        }
    }
}
