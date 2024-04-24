using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList st = new SortedList();
            st.Add(91, "India");
            st.Add(1, "USA");
            st.Add(36, "AUS");
            st.Add(54, "Canada");
            st.Add(40, "AUT");
            st.Add(44, "BHS");

            foreach (DictionaryEntry s in st)
            {
                Console.WriteLine($"{s.Key}-->{s.Value}");
            }

        }
    }
}
