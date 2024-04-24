using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class StackMethods
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            //Push method
            Console.WriteLine("Push method:");
            st.Push(10);
            st.Push(20);
            st.Push(30);

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            //To show top element peek()

            Console.WriteLine($"Top element on stack:{st.Peek()}");

            //To show total count
            Console.WriteLine($"Total elements in stack: {st.Count}");

            //to remove top element pop()
            Console.WriteLine("Pop method:");
            st.Pop();
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

           
        }
    }
}
