using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.Write a program that takes the quantity of milk and oil as input from user.
 * Milk is 40 rs. per liter and oil is 50 rs. per liter. 
 * Take the input from user till the total exceeds 500.
 * If total exceeds 500 display the quantity of milk and oil entered.*/
namespace Assesment.LoopAssignments
{
    public class MilkOil
    {
        static void Main(string[] args)
        {
            const int milkPrice = 40;
            const int oilPrice = 50;
            int total=0;
            while (total<=500)
            {
                Console.WriteLine("Enter quantity of milk (in ltr)");
                int milk=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter quantity of oil (in ltr)");
                int oil = int.Parse(Console.ReadLine());

                int cost = (milk * milkPrice) + (oil * oilPrice);

                if (total + cost > 500)
                {
                    break;
                }
                total += cost;
            }
        }
    }
}
