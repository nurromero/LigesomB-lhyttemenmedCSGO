using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigesomBålhyttemenmedCSGO
{
    public class Player
    {
        // Properties

        public int ID { get; set; }
        public string Nickname { get; set; }
        public int Health { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }


        public override string ToString()
        {
            return $"Player ID: " + ID + "\nNickname:" + Nickname + "\nHealth: " + Health + "\nKills: " + Kills + "\nDeaths: " + Deaths;
        }

    }

    
}
