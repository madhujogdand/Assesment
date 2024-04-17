using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class Date
    {
        private int day;
        private string month;
        private int year;

        public Date()
         {
            day = 13;
            month = "April";
            year = 2024;
         }

        public Date(int day, string month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string GetDate()
        {
            return $"Date is= {day}-{month}-{year}";
        }

    }
    public class DateDetails
    {
        static void Main(string[] args)
        {
            Date d=new Date();
            Console.WriteLine(d.GetDate());

            Date d1 = new Date(12,"April",2024);
            Console.WriteLine(d1.GetDate());


        }
    }
}
