using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public delegate int MyDelegate(int x, int y);
    public delegate string MyDelegateStr(string name);
    public class Name
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string AcceptName(string name)
        {
            return name.ToUpper();
        }
    }
    public class SinglecastDelegateDemo
    {
        static void Main(string[] args)
        {
            Name nm=new Name();

            MyDelegate mydelegate = new MyDelegate(nm.Add);
            int res = mydelegate.Invoke(20, 30);
            Console.WriteLine(res);

            MyDelegateStr strdel = new MyDelegateStr(nm.AcceptName);
           string result = strdel.Invoke("Madhu");
           Console.WriteLine(result);

        }
    }
}
