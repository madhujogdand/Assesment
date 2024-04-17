using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6) Create a class Account containing following methods :insert() to insert account data,
display() to display account information, deposit() to deposit amount, withdraw() to withdraw amount,
checkbalance() to check balance
e.g.
class Account{
int acc_no;
String name;
float amount;
}
*/
namespace Assesment.AssignmentsOnMethods
{

    public class Account
    {
        int accno;
        string name;
        float amount;

        public void Insert( int accno, string name, float amount)
        { 
           this.accno = accno;
            this.name = name;
            this.amount = amount;
        }

        public void Display()
        {
            Console.WriteLine("Account No: "+accno);
            Console.WriteLine("Name: " + name) ;
            Console.WriteLine("Amount: "+amount);
        }

        public void Deposit(float depositamt)
        {
            amount = amount + depositamt;
            Console.WriteLine("Amount deposited successfully");
            Console.WriteLine("After deposit amount is: "+amount);
        }

        public void Withdraw(float withdrawamt)
        {
            if (withdrawamt > amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else {
                amount = amount - withdrawamt;
                Console.WriteLine("amount withdrawn successfully");
                Console.WriteLine("After withdraw amount is: " + amount);
            }
            
        }

        public void Checkbalance()
        {
            Console.WriteLine("Current balance is: "+amount);
        }

    }
    public class AccountInfo
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.Insert(121, "Madhu", 5000.50F);
            acc.Display();
            acc.Deposit(1000.50F);
            acc.Withdraw(6510);
            acc.Checkbalance();
        }
    }
}
