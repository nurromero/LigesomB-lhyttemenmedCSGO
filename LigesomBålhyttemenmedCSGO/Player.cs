using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigesomBålhyttemenmedCSGO
{
    public class Player

    {
        private string _team;

        private string teamSelected 
        {
            get { return _team; }
        }

        // Properties
        public int ID { get; }
        public string Nickname { get; }
        public int Health { get; }
        public int Kills { get; }
        public int Deaths { get; }
        public string Team
        {
            get { return _team; }
        }


        // Constructor
        public Player(int id, string nickname, string team, int health, int kills, int deaths)
        {
            ID = id;
            Nickname = nickname;
            _team = team;
            Health = health;
            Kills = kills;
            Deaths = deaths;
        }

        public override string ToString()
        {
            return $"Player ID: " + ID + "\nNickname: " + Nickname + "\nTeam: " + _team + "\nHealth: " + Health + "\nKills: " + Kills + "\nDeaths: " + Deaths;
        }

    }

    
}
