using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoncrawler
{
    public class Playerstats
    {
        private string _name;
        private int _attack;
        private int _block;
        private int _health;
        private int _magic;
        


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }


        public int Magic
        {
            get { return _magic; }
            set { _magic = value; }
        }

        public Playerstats(string name, int attack, int block, int health, int magic)
        {
            Name = name;
            Attack = attack;
            Block = block;
            Health = health;
            Magic = magic;


        }
        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}\n\n" +
                $"{Attack}\n\n" +
                $"{Health}\n\n" +
                $"{Block}\n\n" +
                $"{Magic}\n\n";
        }
        public static Playerstats GetStats()
        {
            Playerstats p1 = new Playerstats("Paladin", 5, 50, 150, 0);
            Playerstats p2 = new Playerstats("Rogue", 20, 5, 50, 0);
            return p1;



        }
        public enum Weapons
        {
            Broadsword,
                GiantAxe,
                Shield,
                Knife,
                Staff
        }
        public enum Races
        {
            Orc,

        }


    }

}
        






        /*public class WeaponLibrary
        {
            private string _weaponName;
            private int _weaponDamageMax;
            private int _weaponDamageMin;
            private int _bonusHitChance;

            public string WeaponName
            {
                get { return _weaponName; }
                set { _weaponName = value; }
            }
            public int WeaponDamageMax
            {
                get { return _weaponDamageMax; }
                set { _weaponDamageMax = value; }
            }
            public int WeaponDamageMin
            {
                get { return _weaponDamageMin; }
                set { _weaponDamageMin = value; }
            }
            public int BonusHitChance
            {
                get { return _bonusHitChance; }
                set { _bonusHitChance = value; }
        */

            

        
    

