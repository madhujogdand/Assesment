using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.MamCodes
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Producer { get; set; }

        public Movie(int id, string name, double price, string producer)
        {
            Id= id;
            Name= name;
            Price= price;
            Producer= producer;

        }
    }


}
