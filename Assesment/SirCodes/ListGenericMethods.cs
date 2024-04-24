using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class ListGenericMethods
    {
        static void Main(string[] args)
        {
            List<int> ilist= new List<int>();

            //To Add elements- Add()
            ilist.Add(100);
            ilist.Add(420);
            ilist.Add(30);
            Console.WriteLine("Add method:");
            foreach (int i in ilist) 
            {
                Console.WriteLine(i);
            }

            //To count elements
            Console.WriteLine($"Total elements:{ilist.Count}");

            //Contains method
            Console.WriteLine($"Contains method:{ilist.Contains(100)}");

            //To insert element
            ilist.Insert(2, 380);
            Console.WriteLine("insert method:");
            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            //To sort elements
            ilist.Sort();
            Console.WriteLine("Sort method:");
            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            //To Reverse elements
            ilist.Reverse();
            Console.WriteLine("Reverse method:");
            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            //To remove element in range
            ilist.RemoveRange(1,2);
            Console.WriteLine("RemoveRange method:");
            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            //To remove element
            ilist.Remove(30);
            Console.WriteLine("Remove method:");
            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            //To remove element from index
            ilist.RemoveAt(0);
            Console.WriteLine("RemoveAt method:");
            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            //To clear the list
            ilist.Clear();
            Console.WriteLine("clear method:");
            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

        }
       
    }
}
