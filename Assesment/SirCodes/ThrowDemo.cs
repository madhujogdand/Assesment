using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Accept name from user(i.e constructor) check if name is null or empty
 * raise an exception "Name is required"*/
namespace Assesment.SirCodes
{
    public class NameException : Exception
    { 
       public NameException(string error):base(error)
       {
        
       }
    }
    public class Person
    {
        private string name;

        public void AcceptName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Name is required");
               

            }
            else {
                this.name = name;
                Console.WriteLine(name);

            }
        }
    }
    public class ThrowDemo
    {
        static void Main(string[] args)
        {
            Person p= new Person();
            try
            {
                p.AcceptName("");
            }
            catch(NameException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
