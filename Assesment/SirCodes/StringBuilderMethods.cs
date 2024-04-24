using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class StringBuilderMethods
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            // Append method
            sb.Append("Hello");
            sb.Append(", ");
            sb.Append("Good Morning");
            Console.WriteLine($"StringBuilder after appending: {sb}");

            //Length method
            Console.WriteLine("StringBuilder length:"+sb.Length);

            //Capacity method
            StringBuilder sb2 = new StringBuilder(15);
            Console.WriteLine($"Capacity of string builder : {sb2.Capacity}");


            //Insert method
            Console.WriteLine("StringBuilder after inserting: "+sb.Insert(6," All"));

            //Remove method
            Console.WriteLine("StringBuilder after removing:"+sb.Remove(6,9));

            //Replace method
            Console.WriteLine("StringBuilder after replacing:"+sb.Replace("Morning","afternoon"));


            //clear method
           // Console.WriteLine("StringBuilder after clearing:"+sb.Clear());
        }
    }
}
