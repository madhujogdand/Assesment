using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class Player
    {
        private string name;
        private int runs;

        public Player(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public override string ToString()
        {
            return $"Name:{name}, runs:{runs}";
        }

       
    }

    public class Team : IEnumerable
    {
        private Player[] player;

        public Team()
        {
            player = new Player[3];
            player[0] = new Player("virat", 3000);
            player[1] = new Player("Rohit", 2000);
            player[2] = new Player("dhoni", 2800);
        }

        public IEnumerator GetEnumerator()
        { 
          return player.GetEnumerator();
        }
    }
    public class IEnumerableDemo
    {
        static void Main(string[] args)
        {
            Team ind= new Team();

            foreach (Player p in ind)
            {
                Console.WriteLine(p);
            }
        }
    }
}
