using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assesment.SirCodes
{
    public class StackGenericMethods
    {
        static void Main(string[] args)
        {
            Stack<String> st=new Stack<String>();

            //To add elements- Push()
            st.Push("Pradnya");
            st.Push("aashu");
            st.Push("priti");
            st.Push("Neha");
            st.Push("radha");
            Console.WriteLine("Push Method");
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }

            //Total elements
            Console.WriteLine($"Total elements: {st.Count}");

            //Top elements on stack
            Console.WriteLine($"Top element on stack:{st.Peek()}");

            //Contains method
            Console.WriteLine($"Contains: {st.Contains("aashu")}");

            //To remove-Pop()
            st.Pop();
            Console.WriteLine("Pop Method");
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }

            //To clear stack
            st.Clear();
            Console.WriteLine("clear method");
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }



        }
    }
}
