using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoncrawler
{
    public class PlayerLibrary
    {
        private string _name;
        private int _attack;
        private int _block;
        private int _health;
        private int _maxLife;
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
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Magic
        {
            get { return _magic; }
            set { _magic = value; }
        }

        public PlayerLibrary(string name, int attack, int block, int health, int maxLife, int magic)
        {
            Name = name;
            Attack = attack;
            Block = block;
            Health = health;
            MaxLife = maxLife;
            Magic = magic;

        }
        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}\n\n" +
                $"{Attack}\n\n" +
                $"{MaxLife}\n\n" +
                $"{Magic}\n\n";
        }

        public class WeaponLibrary
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


            }

        }
    }
}
