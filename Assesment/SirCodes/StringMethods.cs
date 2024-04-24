using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class StringMethods
    {
        static void Main(string[] args)
        {
            string str = "Hello to all";
            Console.WriteLine(str);

           
            //need to conver string to char[]
            char[] ch = str.ToCharArray();

            Console.WriteLine("TocharArray:");
            foreach (char c in ch) 
            {
              Console.WriteLine(c);
            }

            //Split method
            string[] result = str.Split(' ');
            Console.WriteLine("Split method:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //IsEmptyOrNull()
            string str1 = string.Empty;
            // string str1 =" ";
            //string str1 =null;

            Console.WriteLine("IsEmptyOrNull method");
            if (string.IsNullOrEmpty(str1))
            {
                Console.WriteLine("String is empty or null");
            }
            else
            {
                Console.WriteLine(str1);

            }


           //Length property
           int length = str.Length;
            Console.WriteLine($"Length of the string is:{length}");
            Console.WriteLine("Length of the string is:" + str.Length);

            //ToUpper Method
            Console.WriteLine("Uppercase string:"+str.ToUpper());

            //ToLower Method
            Console.WriteLine("Lowercase string:" + str.ToLower());

            //Substring Method
            Console.WriteLine("Substring from index:"+str.Substring(2));
            Console.WriteLine("Substring from index and length:" + str.Substring(3,7));

            //IndexOf method
            Console.WriteLine("Index of:" + str.IndexOf('t'));

            //contains method
            Console.WriteLine("Contains method:"+str.Contains("all"));

            //Replace method
            Console.WriteLine("Replace method:"+str.Replace("all","everyone"));

            //concat method
            string name = "Madhu";
            string lastname = "Gore";
            string fullname = string.Concat(name," ", lastname);
            Console.WriteLine($"concat name:{fullname}");

            //Trim method
            string strr = "   Hello, Madhu   ";
            Console.WriteLine("Trim example: "+strr.Trim());

            //LastIndexOf method
            Console.WriteLine("Last index of:"+str.LastIndexOf(' '));
        }
    }
}
