using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterStats;

namespace WeaponLibrary
{


    public class Weapon : Stats
    {
        private int _mindamage;
        private int _maxdamage;

         public int MaxDamage
        {
            get { return _maxdamage; }
            set { _maxdamage = value; }
        }

        public int MinDamage
        {
            get { return _mindamage; }
            set { _mindamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

       
        

        public Weapon(string name, int attack,
            Weapons equippedWeapon, int minDamage, int maxDamage) 
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            switch (equippedWeapon)
            {
                case Weapons.Sword: MinDamage = 50; MaxDamage = 100;
                    break;
                case Weapons.Polearm: MinDamage = 25; MaxDamage = 150;
                    break;
                case Weapons.GreatAxe: MinDamage = 75; MaxDamage = 200;
                    break;
                case Weapons.Dagger: MinDamage = 30; MaxDamage = 115;
                    break;
                case Weapons.Staff: MinDamage = 75; MaxDamage = 300;
                    break;
            }
        }
    
      public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n",
                Name,
                MinDamage,
                MaxDamage);
                
        }  
    }
}
