using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
/*
    A
    A B
    A B C
    A B C D
    A B C D E
    A B C D E F
    A B C D E F G
    A B C D E F G H
    A B C D E F G H I
 
 */
namespace Assesment.LoopAssignments
{
    public class Pattern10
    {
        static void Main(string[] args)
        {
            
            for (char ch = 'A'; ch <= 'I'; ch++)
            {
                for (char j = 'A'; j <= ch; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
           
        }
    }
}
