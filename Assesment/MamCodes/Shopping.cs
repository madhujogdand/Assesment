using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to create a shopping class which contain product id, name, price and quantity. 1st method to accept
 * product details, 2nd method to calculate total bill if quanity is greater than 0 otherwise show error message,
 * 3rd method to show all shopping details total bill */
namespace Assesment.MamCodes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public void AcceptDetails(int id, string name, int price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double CalBill()
        {
            if (Quantity > 0)
            {
                return Price * Quantity;
            }
            else
            {
                Console.WriteLine("Quantity should be greater than 0");
                return 0;
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Product id:"+Id);
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Price:"+Price);
            Console.WriteLine("Quantity:"+Quantity);
            Console.WriteLine("Total Bill:"+CalBill());
        }

    }
    public class Shopping
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.AcceptDetails(101, "Mouse", 399, 2);
            p.DisplayDetails();
            p.AcceptDetails(101, "Keboard", 499, 0);
            p.DisplayDetails();
        }
    }
}
