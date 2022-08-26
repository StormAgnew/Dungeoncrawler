using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{       
    public class Monsters : Stats
    {
        private string _badguy;
        private int _health;
        private int _maxLife;
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        public int MaxLife { get; set; }

        public int Health
        {
            get { return _health; }
            set
            {
                _health = value <= MaxLife ? value : MaxLife;
            }
        }

        public string Badguy { get { return _badguy; } set { _badguy = value; } }
        public string Name { get; set; }
        public int Attack { get; set; }

        public int Defense { get; set; }
        public string Type { get; set; }
        
        public bool IsEnraged { get; set; }

        public bool Frightened { get; set; }

        public bool Undead { get; set; }
        
        public bool Manic { get; set; }

        public bool Venomous { get; set; }



        public Monsters(string name, string type, int attack, int defense, int maxLife, int health, int maxDamage, int minDamage) :base(name,attack,defense,maxLife,health)
        {
            Name = name;
            Type = type;
            
            IsEnraged = false; //Doubles attack/magic if below certain health on some monsters.
            Frightened = false; //Quadruples defense for some monsters. (will make more sense with Karma system)
            Undead = false; //Monsters with this type take increased magic damage and less physical damage.
            Manic = false; //Monsters with this have unpredictability. May flee from battle, Enrage, or Frightened.
            Venomous = false; //Monsters inflict Venom damage when a physical attack lands.


        }
        

        

    

       public override int CalcDamage()
       {
           return new Random().Next(MinDamage, MaxDamage + 1);
        }


        public static Monsters SpawnMonsters()
        {
            
            Monsters m1 = new Monsters("Little Girl", "Abused",1,1,20,20,10,5); //Fire user.
            Monsters m2 = new Monsters("Small Mouse holding a clock", "Anxiety",2,2,10,10,10,2);
            Monsters m3 = new Monsters("Faceless One", "BPD",50,20,50,50,50,20); //Room 1
            Monsters m4 = new Monsters("Duality", "Bi-Polar",100,100,50,50,50,25);

            Monsters[] monsters = {m1,m2,m3,m4};

            

            Random rand = new Random();
            Monsters monster = monsters[rand.Next(monsters.Length)];
            return monster;
        }
           public override string ToString()
        {
            return string.Format("-=-=- {0} -=-=-\n" + "Type: {1}\n" +
                "Health: {2} of {3}\nDefense: {4}\nAttack: {5}\n",
                Name, Type, Attack, Defense, MaxLife, Health);
        }
        // Name, Type of monster, Attack, Defense, Health, Magic, and Speed. All integers are "random" as
        // of currently until I figure out how combat will function and operate. Monsters are to be assigned to a specific room eventually, but as of now they are randomly selected like rooms.
        //More monsters WILL be added.

       







    }
}
