using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class GenericCollectionDemo
    {
        static void Main(string[] args)
        {
            List<int> ilist = new List<int>();
            ilist.Add(10);
            ilist.Add(20);

            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            List<string> slist = new List<string>();
            slist.Add("Pune");
            slist.Add("Mumbai");

            foreach (string s in slist)
            {
                Console.WriteLine(s);
            }

            List<Products> pro = new List<Products>();
            pro.Add(new Products { Id = 1, Name = "Pen", Price = 20 });
            pro.Add(new Products { Id = 2, Name = "Pencil", Price = 10 });
            pro.Add(new Products { Id = 3, Name = "Notebook", Price = 30});

            foreach (Products p in pro)
            {
                Console.WriteLine(p);
            }

            Stack <int> st= new Stack<int>();
            st.Push(10);

            foreach (int i in st)
            {
                Console.WriteLine(i);
            }


            Queue<string> q = new Queue<string>();
            q.Enqueue("Shivansh");
            q.Enqueue("Madhu");

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }

            Queue<Products> prod = new Queue<Products>();
            prod.Enqueue(new Products { Id = 1,Name="Book", Price=40});
            prod.Enqueue(new Products { Id = 2, Name = "pen", Price = 20});
            prod.Enqueue(new Products { Id = 3, Name = "Pencil", Price = 10 });

            foreach (Products p in prod)
            {
                Console.WriteLine(p);
            }

            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(1, "Pune");
            keyValuePairs.Add(2, "Mumbai");

            foreach (KeyValuePair<int,string> item in keyValuePairs)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            HashSet<int> hs=new HashSet<int>();
            hs.Add(1);
            hs.Add(2);
            hs.Add(3);
            hs.Add(1);
            hs.Add(4);

            foreach (int i in hs)
            {
                Console.WriteLine(i);
            }
        }
        
        
    }
}
