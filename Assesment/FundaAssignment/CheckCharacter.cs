using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7.Write a Java program to input any character and check whether it is alphabet, digit or special character 
namespace Assesment.FundaAssignment
{
    public class CheckCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());

            if((ch>='a' && ch<='z') || (ch>='A' && ch<='Z'))
                Console.WriteLine($"{ch} is alphabet");
            else if(ch>='0' && ch<='9')
                Console.WriteLine($"{ch} is digit");
            else
                Console.WriteLine($"{ch} is special character ");
        }
    }
}
