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


        public override string ToString()
        {
            return $"Name: " + Name + "\nDamage: " + Damage + "\nAmmo: " + Ammo + "\nReload Time: " + ReloadTime;
        }

    }
}
