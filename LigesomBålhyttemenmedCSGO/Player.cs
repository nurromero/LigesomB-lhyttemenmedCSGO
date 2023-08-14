using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigesomBålhyttemenmedCSGO
{
    public class Player

    {
        private string teamSelected;

        public string TeamSelected
        {
            get { return teamSelected; }
            set { teamSelected = value; }
        }

        // Properties

        public int ID { get; }
        public string Nickname { get; }
        public int Health { get; }
        public int Kills { get; }
        public int Deaths { get; }


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
