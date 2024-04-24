using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.MamCodes
{
    public interface IAddition
    {
        public int B { get; set; }
    }

    abstract public class Addition
    {
        protected int a;

        public abstract void Display();
    }

    public class AdditionInChild : Addition, IAddition
    {
        public int B { get; set; }

        public AdditionInChild(int num)
        {
            a = num;
        }

        public override void Display()
        {
            Console.WriteLine($"First Number:{a}");
        }

        public int PerformAddition()
        {
            return a + B;
        }
    }
        public class AbstractInterfaceDemo
        {
            static void Main(string[] args)
            {
                AdditionInChild child=new AdditionInChild(20);
                child.B = 10;
                child.Display();

                int result=child.PerformAddition();
                Console.WriteLine($"Addition is:{result}");


            }
        }
    
}
