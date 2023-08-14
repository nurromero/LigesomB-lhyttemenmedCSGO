using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LigesomBålhyttemenmedCSGO
{
    public class Armoury
    {
        private static Armoury instance;
        private Dictionary<string, Dictionary<int, Weapon>> armoury;

        private Armoury()
        {
            // Initialize weapons in the dictionary
            armoury = new Dictionary<string, Dictionary<int, Weapon>>();
        }

        public static Armoury Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Armoury();
                }
                return instance;
            }
        }

        // Method
        public Weapon BuyWeapon(string team, int id, Player player)
        {
            Weapon weapon = null;

            if (player.Team.Equals("CT"))
            {
                weapon = armoury[team][id];
            }
            else if (player.Team.Equals("T"))
            {
                weapon = armoury[team][id];
            }

            return weapon;
        }

        public void AddWeapon(string team, int id, Weapon weapon)
        {
            //armoury[id] = weapon;
        }

        //public bool TryGetWeapon(int id, out Weapon weapon)
        //{
        //    return armoury.TryGetValue(id, out weapon);
        //}

        // CRUD METHODS
        public void Create(string team, int id, Weapon weapon)
        {
            if (!armoury.ContainsKey(team))
            {
                armoury[team] = new Dictionary<int, Weapon>();
            }

            armoury[team].Add(id, weapon);
        }

        public Weapon Read(string team, int id)
        {
            return armoury[team][id];
        }

        public void Update(string team, int id, Weapon updatedWeapon)
        {
            armoury[team][id] = updatedWeapon;
        }

        public void Delete(string team, int id)
        {
            armoury[team].Remove(id);
        }

    }
}

