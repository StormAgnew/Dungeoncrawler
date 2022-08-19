using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats

{
    public class Stats

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


        public Stats() { }


        public Stats(string name, int attack, int defense, int health, int magic)
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
       
       

            
            
            
        
        
    }
}
