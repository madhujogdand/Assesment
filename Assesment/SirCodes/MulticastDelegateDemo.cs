using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public delegate int MyDelegates(int x, int y);
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
    public class MulticastDelegateDemo
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            MyDelegates mydelegates = new MyDelegates(c.Add);
            mydelegates += new MyDelegates(c.Sub);
            mydelegates += new MyDelegates(c.Mul);

            mydelegates -= new MyDelegates(c.Sub);

            Delegate[] list=mydelegates.GetInvocationList();

            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(45,34));
            }
        }
    }
}
