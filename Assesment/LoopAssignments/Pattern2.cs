﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
               *
             * *
           * * *
         * * * *
       * * * * *
     * * * * * *
 
 */
namespace Assesment.LoopAssignments
{
    public class Pattern2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //for spaces
                for (int j = 1; j <=(n-i); j++)
                {
                    Console.Write("  ");

                }
                //for numbers
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();

            }
        }
    }
}