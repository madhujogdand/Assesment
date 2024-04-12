using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class DivisibleBY7
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
               
                if (i % 7 == 0 )
                {
                   
                    Console.WriteLine(i);
                }
            }
        }
    }
}
