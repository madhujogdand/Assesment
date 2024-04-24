using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();

            ht.Add(91, "India");
            ht.Add(1, "USA");
            ht.Add(36, "AUS");
            ht.Add(54, "Canada");
            ht.Add(40, "AUT");
            ht.Add(44, "BHS");

            foreach (DictionaryEntry s in ht) 
            {
                Console.WriteLine($"{s.Key}-->{s.Value}");
            }


        }
    }
}
