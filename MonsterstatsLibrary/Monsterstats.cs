using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Monsterstats
    {
        private string _name;
        private int _attack;
        private int _defense;
        private int _health;
        private int _magic;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Attack 
        { get { return _attack; } 
            set { _attack = value; } }
        public int Defense 
        { get { return _defense; }
            set { _defense = value; } }
        public int Health
        { get { return _health; } 
            set { _health = value; } }
        public int Magic 
        { get { return _magic; } 
            set { _magic = value; } }
                
        public Monsterstats(string name, int attack, int defense, int health, int magic)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            Health = health;
            Magic = magic;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Name: {Name}\n" +
                $"Attack: {Attack}\n" +
                $"Defense: {Defense}\n" +
                $"Life: {Health}\n" +
                $"Magic: {Magic}\n";
        }
       
        public static Monsterstats GetMonster()
        {
            Monsterstats m1 = new Monsterstats("Dragon Whelp", 10, 10, 50, 50);
            return m1;
        }
        public static Monsterstats GetMonster2()
        {
            Monsterstats m2 = new Monsterstats("Thicc Baby Butt", 1, 2, 3, 4);
            return m2;
        }

            
            
            
        
        
    }
}
