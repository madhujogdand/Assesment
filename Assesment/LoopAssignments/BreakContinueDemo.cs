﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.WAP to show the use of break statement ( in for loop)
namespace Assesment.LoopAssignments
{
    public class BreakContinueDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break Demo");
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("Continue Demo");
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
