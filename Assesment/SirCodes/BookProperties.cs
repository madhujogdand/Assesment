using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class Book
    {
        public int Bookid { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
    public class BookProperties
    {
        static void Main(string[] args)
        {
            //Property initializer 

            Book b = new Book();
            b.Bookid = 1;
            b.Name = "Java";
            b.Price = 999;

            Console.WriteLine($"Book id={b.Bookid}, Name={b.Name}, Price={b.Price}");

            //Object Initializer 

            Book b1 = new Book { Bookid = 2, Name = "C#", Price = 989 };
            Console.WriteLine($"Book id={b1.Bookid}, Name={b1.Name}, Price={b1.Price}");

        }
    }
}
