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
        private int _maxlife;

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
            set {
                _health = value <= MaxLife ? value : MaxLife;
            } }
        
        public int MaxLife{ get; set; }


       



        public Stats() { }


        public Stats(string name, int attack, int defense, int maxLife,  int health)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            MaxLife = maxLife;
            Health = health;
           
        }
           
            
            

        public override string ToString()
        {
            return string.Format("-=-=- {0} -=-=-\n" +
                "Health: {1} of {2}\nDefense: {3}\nAttack: {4}\n",
                Name, MaxLife, Health, Defense, Attack);
        }
        public virtual int Block()
        {
            return Defense;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }
    }  
 }      

            
            
            
        
        
    

