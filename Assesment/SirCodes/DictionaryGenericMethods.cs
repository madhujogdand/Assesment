using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class DictionaryGenericMethods
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(4,"Radha");
            keyValuePairs.Add(2, "Neha");
            keyValuePairs.Add(1, "Ashu");
            keyValuePairs.Add(3, "Priti");
            Console.WriteLine("Add elements:");
            foreach (KeyValuePair<int,string> item in keyValuePairs)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            
            //to remove elements
            keyValuePairs.Remove(3);
            Console.WriteLine("Reverse elements:");
            foreach (KeyValuePair<int, string> item in keyValuePairs)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            
            //Contains key
            Console.WriteLine($"Key contaimns:{keyValuePairs.ContainsKey(4)}");

            //Contains value
            Console.WriteLine($"Key contaimns:{keyValuePairs.ContainsValue("priti")}");


            //to clear dictionary
            keyValuePairs.Clear();
            Console.WriteLine("Clear elements:");
            foreach (KeyValuePair<int, string> item in keyValuePairs)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}
