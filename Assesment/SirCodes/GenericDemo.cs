using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class MyGeneric<T>
    {
        private T data;

        public void Add(T data)
        { 
           this.data = data;
        }

        public T Print()
        { 
        return this.data;
        }


    }
    public class GenericDemo
    {
        static void Main(string[] args)
        {
            MyGeneric<int> demo = new MyGeneric<int>();
            demo.Add(100);
            Console.WriteLine(demo.Print());

            MyGeneric<Products> demo1 = new MyGeneric<Products>();
            demo1.Add(new Products { Id = 1, Name = "Pen", Price = 399 });
            Console.WriteLine(demo1.Print());

            MyGeneric<string> demo3 = new MyGeneric<string>();
            demo3.Add("Hello");
            Console.WriteLine(demo.Print());
        }
    }
}
