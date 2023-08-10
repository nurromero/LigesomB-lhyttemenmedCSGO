using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigesomBålhyttemenmedCSGO
{
    public class Weapon
    {

        // Properties
        
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Ammo { get; set; }
        public int ReloadTime { get; set; }


        // Constructor

        public Weapon(string name, int damage, int ammo, int reloadTime)
        {
            Name = name;
            Damage = damage;
            Ammo = ammo;
            ReloadTime = reloadTime;
        }

        public override string ToString()
        {
            return $"Name: " + Name + "\nDamage: " + Damage + "\nAmmo: " + Ammo + "\nReload Time: " + ReloadTime;
        }

    }
}
