using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class QueueGenericMethods
    {
        static void Main(string[] args)
        {
            Queue<string> q= new Queue<string>();

            //to add elements
            q.Enqueue("Pune");
            q.Enqueue("Mumbai");
            q.Enqueue("Delhi");
            q.Enqueue("Nanded");

            Console.WriteLine("Add elements Enqueue method");
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
            

            //Total elements
            Console.WriteLine($"Total elements: {q.Count}");

            //Top elements on stack
            Console.WriteLine($"Top element on stack:{q.Peek()}");

            //Contains method
            Console.WriteLine($"Contains: {q.Contains("aashu")}");

            //Remove elements Dequeue method
            q.Dequeue();
            Console.WriteLine("Dequeue method:");
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }

            //Clear method
            q.Clear();
            Console.WriteLine("Clear method:");
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }

        }
    }
}
