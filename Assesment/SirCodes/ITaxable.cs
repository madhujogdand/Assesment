using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public interface ITaxable
    {
        double PayTax();
    }
    public class Job : ITaxable
    {
        private double salary;
        private double taxamt;
        public Job()
        {
            salary = 10000;
        }
        public double PayTax()
        {
             taxamt = salary * 0.20;
            return taxamt;
        }
    }
    public class Business : ITaxable
    {
        private double salary;
        private double taxamt;
        public Business()
        {
            salary = 10000;
        }
        public double PayTax()
        {
            taxamt = salary * 0.30;
            return taxamt;
        }
    }
    public class CalculateTax
    {
        static void Main(string[] args)
        {
            Job j1 = new Job();
            Console.WriteLine(j1.PayTax());

            Business b1 = new Business();
            Console.WriteLine(b1.PayTax());
        }
    }
}
