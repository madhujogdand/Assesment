using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class ArrayListMethods
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int[] arr = new[] {1,2,3 };

            //Add method
            //list.Add(10);
            //list.Add(56.66);
            //list.Add("Hello");
            //list.Add('M') ;
            //list.Add(new Products { Id = 1, Name = "pen", Price = 10 });

            //foreach (var item in list) 
            //{
            //    Console.WriteLine("using Add method:"+item);
            //}

            //AddRange method
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.AddRange(arr);
            Console.WriteLine("AddRange method:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sort method
            list.Sort();
            Console.WriteLine("Sort method:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Reverse method
            list.Reverse();
            Console.WriteLine("Reverse method:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //count property
            Console.WriteLine($"Total elements in list={list.Count}");

            //RemoveAtMethod
            list.RemoveAt(2);
            Console.WriteLine("RemoveAt method:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Remove method
            list.Remove(20);
            Console.WriteLine("Remove method:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //RenoveRange method

            list.RemoveRange(1, 3);
            Console.WriteLine("RemoveRange method:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //clear method
            //list.Clear();
           // Console.WriteLine("clear  method:");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



        }
    }
}
