using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class HashSetGenericMethods
    {
        static void Main(string[] args)
        {
            HashSet<int> hs= new HashSet<int>();

            hs.Add(1);
            hs.Add(1);
            hs.Add(2);
            hs.Add(3);
            hs.Add(1);
            hs.Add(4);
            Console.WriteLine("Add method:");
            foreach (int i in hs)
            {
                Console.WriteLine(i);
            }

            //Total elements
            Console.WriteLine($"Total elements: {hs.Count}");

           

            //Contains method
            Console.WriteLine($"Contains: {hs.Contains(2)}");

           

            //Remove elements
            hs.Remove(4);
            Console.WriteLine("To Remove elements");
            foreach (int i in hs)
            {
                Console.WriteLine(i);
            }

            
            //Clear elements
            hs.Clear();
            Console.WriteLine("To Clear elements");
            foreach (int i in hs)
            {
                Console.WriteLine(i);
            }
        }
    }
}
