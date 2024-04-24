using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class User
    {
        private string name, city;

        public User(string name, string city)
        {
            this.name = name;
            this.city = city;

        }
    }
    public class NamedArgumentDemo
    {
        static void Main(string[] args)
        {
            User u1 = new User("Amol", "Pune");

            //Named Argument

            User u2 = new User(city: "Mumbai", name: "Akshay");
            User u3 = new User(name: "Akshay", city:"Mumbai");

        }
    }
}
