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


        // Constructor

        public Player(int id, string nickname, int health, int kills, int deaths)
        {
            ID = id;
            Nickname = nickname;
            Health = health;
            Kills = kills;
            Deaths = deaths;
        }

        public override string ToString()
        {
            return $"Player ID: " + ID + "\nNickname: " + Nickname + "\nHealth: " + Health + "\nKills: " + Kills + "\nDeaths: " + Deaths;
        }

    }

    
}
