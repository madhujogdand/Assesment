using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class Users
    {
        private string name;
        private string city;
        private string country;
        private bool isCustomer;

        //user as admin/customer

        public void Accept(string name, string city, bool isCustomer = true, string country = "IND")
        { 
          this.name = name;
            this.city = city;   
            this.country = country;
            this.isCustomer = isCustomer;

        }
    }
    public class OptionalDefaultDemo
    {
        static void Main(string[] args)
        {
            Users u1= new Users();
            u1.Accept("Amol", "Pune");

            Users u2 = new Users();
            u2.Accept("Nita", "Pune",false);

           
            u2.Accept("Radha", "Hyderabad",true,"UK");

            u2.Accept("Radha", "Hyderabad");

        }
    }
}
