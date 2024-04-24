using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class SortedListGenericDemo
    {
        static void Main(string[] args)
        {
            SortedList<int,string> st= new SortedList<int,string>();
            st.Add(91, "India");
            st.Add(1, "USA");
            st.Add(36, "AUS");
            st.Add(54, "Canada");
            st.Add(40, "AUT");
            st.Add(44, "BHS");
            Console.WriteLine("To add elements");
            foreach (KeyValuePair<int, string> s in st)
            {
                Console.WriteLine($"{s.Key}-->{s.Value}");
            }

            //Remove elements
            st.Remove(40);
            Console.WriteLine("To Remove elements");
            foreach (KeyValuePair<int, string> s in st)
            {
                Console.WriteLine($"{s.Key}-->{s.Value}");
            }

            //RemoveAt method
            st.RemoveAt(1);
            Console.WriteLine("To RemoveAt method");
            foreach (KeyValuePair<int, string> s in st)
            {
                Console.WriteLine($"{s.Key}-->{s.Value}");
            }

            //Clear elements
            st.Clear();
            Console.WriteLine("To Clear elements");
            foreach (KeyValuePair<int, string> s in st)
            {
                Console.WriteLine($"{s.Key}-->{s.Value}");
            }

            
        }
    }
}
