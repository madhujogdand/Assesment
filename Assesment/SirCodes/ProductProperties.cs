using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class Product
    {
        private int code;
        private string name;
        private double price;

        //create constructor

        public Product()
        {
            code = 101;
        }

        //create property
        public int Code
        {
            set { code = value; }
            get { return code; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

    }

    public class ProductProperties
    {
        static void Main(string[] args)
        {
            Product p1=new Product();
            p1.Code = 101;
            p1.Name = "Mouse";
            p1.Price = 999;

            Console.WriteLine($"Product Code:{p1.Code}, Nmae:{p1.Name},Price: {p1.Price}");
        }
    }
}
