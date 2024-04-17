using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Write a Java program to input any alphabet and check whether it is vowel or consonant 
namespace Assesment.FundaAssignment
{
    public class VowelConsonent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a alphabet");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' || ch=='A' || ch=='E' || ch=='I'||ch=='O'||ch=='U')
                Console.WriteLine($"{ch} is vowel");
            else
                Console.WriteLine($"{ch} id Consonent");
        }
    }
}
