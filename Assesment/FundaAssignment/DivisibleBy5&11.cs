﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write a Java program to check whether a number is divisible by 5 and 11 or not 
namespace Assesment.FundaAssignment
{
    public class DivisibleBy5_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no.");
            int n=Convert.ToInt32(Console.ReadLine());  

            if(n%5==0 && n%11==0)
                Console.WriteLine($"{n} is divisible by 5 and 11");
            else
                Console.WriteLine($"{n} is not divisible by 5 & 11");
        }
    }
}
