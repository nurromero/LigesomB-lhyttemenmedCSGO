using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigesomBålhyttemenmedCSGO
{
    public class Weapon
    {

        // Instance fields
        private int _price;
        private string _team;


        // Properties

        public string Name { get; }
        public int Damage { get; }
        public int Ammo { get; }
        public int ReloadTime { get; }


        // Constructor

        public Weapon(string name, int damage, int ammo, int reloadTime, int price, string team)
        {
            Name = name;
            Damage = damage;
            Ammo = ammo;
            ReloadTime = reloadTime;
            _price = price;
            _team = team;
        }

        public override string ToString()
        {
            return $"Name: " + Name + "\nDamage: " + Damage + "\nAmmo: " + Ammo + "\nReload Time: " + ReloadTime;
        }

    }
}
