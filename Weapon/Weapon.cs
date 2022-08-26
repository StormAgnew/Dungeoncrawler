using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterStats;

namespace WeaponLibrary
{


    public class Weapon 
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

        public Weapons WeaponType { get; set; }



        public Weapon(
            Weapons weaponType) 
        {
           WeaponType = weaponType;
            switch(weaponType)
            {
                case Weapons.Sword: MinDamage = 5; MaxDamage = 10;
                    break;
                case Weapons.Polearm: MinDamage = 2; MaxDamage = 15;
                    break;
                case Weapons.GreatAxe: MinDamage = 7; MaxDamage = 20;
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
                WeaponType,
                MinDamage,
                MaxDamage);
                
        }  
    }
}
