using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.Create class Product. Add fields like id, name and price. Create properties for each field.
 * Use object initializer syntax initialize the object. Print product details using ToString()
 3.	Use above Product class, create Discount method & accept the discount percentage. 
Give discount to the price & Display actual price & discounted price*/
namespace Assesment.Classes_Objects
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"Product ID: {Id}\nName: {Name}\nPrice: {Price}";
        }

        public void Discount(double discountPercentage)
        {
            double discountAmount = Price * (discountPercentage / 100);
            double discountedPrice = Price - discountAmount;
            Console.WriteLine($"Actual Price: {Price}");
            Console.WriteLine($"Discounted Price ({discountPercentage}% off): {discountedPrice}");
        }
    }
    public class ProductDetails
    {
        static void Main(string[] args)
        {
            //Object Initializer syntax
            Product p=new Product { Id = 1001, Name = "Smartphone", Price = 499.99 };

            Console.WriteLine(p.ToString());

            p.Discount(20);
        }
    }
}
