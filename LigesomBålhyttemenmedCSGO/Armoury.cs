using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigesomBålhyttemenmedCSGO
{
    public class Armoury
    {
        private static Armoury instance;
        private Dictionary<int, Weapon> armoury;

        private Armoury()
        {
            armoury = new Dictionary<int, Weapon>();
            // Initialize weapons in the dictionary
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

        public void AddWeapon(int id, Weapon weapon)
        {
            armoury[id] = weapon;
        }

        public bool TryGetWeapon(int id, out Weapon weapon)
        {
            return armoury.TryGetValue(id, out weapon);
        }
    }

}

