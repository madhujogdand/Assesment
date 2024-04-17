using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public interface ICustomer
    {
        string Print();
    }

    public interface IOrder
    {
        string Print();
    }

    public class Transaction : ICustomer, IOrder
    {
        string ICustomer.Print()
        {
            return "Customer details";
        }

        string IOrder.Print()
        {
            return "Order Details";
        }
    }

    public class TransactionDetails
    {
        static void Main(string[] args)
        {
            ICustomer c1 = new Transaction();
            Console.WriteLine(c1.Print());

            IOrder o1 = new Transaction();
            Console.WriteLine(o1.Print());
        }
    }
}
