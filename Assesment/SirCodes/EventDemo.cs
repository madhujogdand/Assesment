using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public delegate void MyBankDelegate();

    public class Bank
    { 
        public event MyBankDelegate LowBalance;

        private double balance;

        public Bank()
        {
            
            balance = 5000;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                LowBalance();// call or raise an event
            }
            else
            {
                balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Your balance is {balance}";
        }

    }

    public class MyMessage
    {
        public void BalanceMsg()
        {
            Console.WriteLine("You have low balance");
        }
    }
    public class EventDemo
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            MyMessage msg = new MyMessage();

            b.LowBalance += new MyBankDelegate(msg.BalanceMsg);

            Console.WriteLine("Initial Balance");
            Console.WriteLine(b);

            b.Withdraw(1000);
            Console.WriteLine("Balance after withdraw 1000");
            Console.WriteLine(b);

            b.Withdraw(6000);
            Console.WriteLine("Balance after withdraw 6000");
            Console.WriteLine(b);

        }
    }
}
