using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            //To add element Enqueue()
            q.Enqueue("Hello");
            q.Enqueue("Good MOrning");
            q.Enqueue("Bye");

            //To Remove-Deque() it will remove first element
            //q.Dequeue();

            //select first element-Peek()
            Console.WriteLine($"First element in the Queue {q.Peek()}");

            //to get total elements
            Console.WriteLine($"Total elements in the Queue {q.Count}");


            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            

        }
    }
}
