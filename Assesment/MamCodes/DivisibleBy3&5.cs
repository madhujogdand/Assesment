using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to display no between 1 to 50. if no divisible by 3 then display pune, if no divisible by 5 then display welcome
 if divisible by 3&5 then display welcome to pune*/
namespace Assesment.MamCodes
{
    public class DivisibleBy3_5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Welcome to Pune");
                else if (i % 3 == 0)
                    Console.WriteLine("Pune");
                else if (i % 5 == 0)
                    Console.WriteLine("Welcome");
                else
                    Console.WriteLine(i);

            }
        }
    }
}
