using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9.Write a Java program print total number of days in a month 
namespace Assesment.FundaAssignment
{
    public class DaysInMonth
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a month");
            int month=Convert.ToInt32(Console.ReadLine());  

            if(month<1 || month>12)
                Console.WriteLine("Invalid month");
            if(month==1 || month==3 || month==5 || month==7 || month==8 || month==10 || month==12)
                Console.WriteLine("Month having 31 days");
            else if(month==4 || month==6 || month==9 || month==11)
                Console.WriteLine("Month having 30 days");
            else
                Console.WriteLine("Month having 28 days");

        }
    }
}
