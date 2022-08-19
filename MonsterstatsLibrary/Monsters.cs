using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{       
    public class Monsters : Stats
    {
        public string Type { get; set; }
        public int Block { get; set; }
        public bool IsEnraged { get; set; }

        public bool Frightened { get; set; }

        public bool Undead { get; set; }
        
        public bool Manic { get; set; }

        public bool Venomous { get; set; }

        public Monsters(string name, string type, int attack, int defense, int block, int health, int magic, int speed)
        {
            Type = type;
            Block = block;
            IsEnraged = false; //Doubles attack/magic if below certain health on some monsters.
            Frightened = false; //Quadruples defense for some monsters. (will make more sense with Karma system)
            Undead = false; //Monsters with this type take increased magic damage and less physical damage.
            Manic = false; //Monsters with this have unpredictability. May flee from battle, Enrage, or Frightened.
            Venomous = false; //Monsters inflict Venom damage when a physical attack lands.


        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static Monsters SpawnMonster() //Monsters || beings with no magic DO NOT USE IT.
        {
            Monsters m1 = new Monsters("Little Girl", "Abused", 0, 200, 80, 20, 60, 2000); //Fire user.
            Monsters m2 = new Monsters("Small Mouse holding a clock", "Anxiety", 10, 100, 20, 150, 0, 150);
            Monsters m3 = new Monsters("Faceless One", "BPD", 70, 60, 80, 80, 0, 1100); //Room 1
            Monsters m4 = new Monsters("Duality", "Bi-Polar", 80, 5, 60, 600, 0, 900);

            Monsters[] monster = { m1, m2, m3, m4 };

            Random rand = new Random();
            Monsters monsters = monster[rand.Next(monster.Length)];
            return monsters;
        }
        // Name, Type of monster, Attack, Defense, Health, Magic, and Speed. All integers are "random" as
        // of currently until I figure out how combat will function and operate. Monsters are to be assigned to a specific room eventually, but as of now they are randomly selected like rooms.
        //More monsters WILL be added.
        






    }
}
