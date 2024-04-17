using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class Product1
    {
        public int Code { get; set; }
        public string Name{ get; set; }
        public double Price { get; set; }



    }

    public class ProductProperties1
    {
        static void Main(string[] args)
        {
            //property initializer syntax
            Product1 p=new Product1();
            p.Code = 101;
            p.Name = "Mouse";
            p.Price = 999;

            Console.WriteLine($"Product Code:{p.Code}, Nmae:{p.Name},Price: {p.Price}");


            //Object initializer syntax

            Product1 p2 = new Product1 {Code=102, Name="Keyboard", Price=399};
            Console.WriteLine($"Product Code:{p2.Code}, Nmae:{p2.Name},Price: {p2.Price}");

        }
    }
}
