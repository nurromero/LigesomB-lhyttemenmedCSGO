using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigesomBålhyttemenmedCSGO
{
    public class BuyZone
    {
        // Properties

        public string Location { get; set; }

        // Implementing a list of available weapons in the buy zone
        public List<Weapon> Weapons { get; set; }


        // Implementing a constructor
        public BuyZone(string location)
        {
            Location = location;
            Weapons = new List<Weapon>();
        }

        // Implementing a menthod, printing deatails of weapons available in the buy zone.
        public void PrintBuyZoneWeapons()
        {
            Console.WriteLine($"Weapons available at {Location}");
            foreach (Weapon weapon in Weapons)
            {
                Console.WriteLine(weapon.ToString());
                Console.WriteLine();
            }

        }

    }

   
  
}
