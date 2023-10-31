using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_the_world
{
    internal class Player
    {
        public string name { get; }
        public int score { get; set; }
        public List<Record> playerRecord = new List<Record>(); 
        public Player(string name, int score) {
            this.name = name;
            this.score = score;
        }

    }
}
