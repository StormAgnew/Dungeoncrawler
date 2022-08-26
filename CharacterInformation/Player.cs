using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterStats;
using WeaponLibrary;
using CharacterInformation;

namespace PlayerToon
{
    public class Player : Stats
    {
        public Races PlayerRace { get; set; }

        public Weapon EquippedWeapon { get; set; }

        public Classes Playerclass { get; set; }


        public Player(string name, int attack, int defense, int maxLife, int magic, Races playerRace, Weapon equippedWeapon)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;


        }
        public Player()
        {

        }
        public Player(string name, Races playerRace, Weapon equippedWeapon)
        {
            Name = name;
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;


            switch (PlayerRace)
            {
                case Races.Orc:
                    Attack = 50; Defense = 10; MaxLife = 75; Health = 75;
                    break;
                case Races.Human:
                    Attack = 50; Defense = 20; MaxLife = 100; Health = 100;
                    break;
                case Races.Elf:
                    Attack = 50; Defense = 30; MaxLife = 100; Health = 100;
                    break;
                case Races.Dragonling:
                    Attack = 50; Defense = 50; MaxLife = 75; Health = 75;
                    break;
                case Races.Ravenir:
                    Attack = 50; Defense = 5; MaxLife = 100; Health = 100;
                    break;

            }
        }

        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage,EquippedWeapon.MaxDamage + 1);
        }
        
            
        



    }
}
