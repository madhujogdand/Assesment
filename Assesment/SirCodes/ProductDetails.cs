using Assesment.MamCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create an array of product class with 5 products. Display the details*/
namespace Assesment.SirCodes
{
    public class Products
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //public Products(int id, string name, int price)
        //{
        //    Id = id; Name = name;
        //    Price = price;
        //}

        //Using Method
        public void DisplayDetails()
        {
            Console.WriteLine("Product Details");
            Console.WriteLine("Id:"+Id);
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Price:"+Price);
        }

        public override string ToString()
        {
            return $"{Id}-{Name}-{Price}";
        }

    }


    public class ProductDetails
    {
        static void Main(string[] args)
        {
            Products[] pro=new Products[5];

            //pro[0] = new Products(101, "Laptop", 35000);
            //pro[1] = new Products(102, "Keyboard", 900);
            //pro[2] = new Products(103, "Mouse", 599);
            //pro[3] = new Products(104, "Headphones", 200); 
            //pro[4] = new Products(105, "Pendrive", 699);

            new Products {Id= 101,Name= "Laptop",Price= 35000 };
            new Products { Id = 102, Name = "Keyboard", Price = 999 };
            new Products { Id = 103, Name = "Mouse", Price = 399 };
            new Products { Id = 104, Name = "Headphones", Price = 299 };
            new Products { Id = 105, Name = "Pendrive", Price = 499 }; ;


            //Using for loop
            Console.WriteLine("Using for loop");
            for (int i = 0; i < pro.Length; i++)
            {
                Console.WriteLine("Product " + (i + 1) + " details:");
                pro[i].DisplayDetails();
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("-------------------------------");
            //Using For each loop
            Console.WriteLine("Using For each loop");
            Console.WriteLine("-------------------------------");
           
            foreach (Products p in pro)
            {
             
                p.DisplayDetails();
                Console.WriteLine("---------------------");
            }

            //print properties
            foreach (Products p in pro)
            {
                Console.WriteLine($"{p.Id},{p.Name},{p.Price}");
            }

            //use built in method called ToString()
            //base class object have virtual method called ToString()
            //ToString()--> define the object in string format

            foreach (Products p in pro)
            {
                Console.WriteLine(p);//we want to print object-initially it calles the tostring()
            }
        }
    }
}
