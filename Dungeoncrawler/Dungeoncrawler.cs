using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using CharacterStats;
using RoomLibrary;
using CharacterInformation;
using Dungeoncrawler;
using WeaponLibrary;
using PlayerToon;


namespace Block1
{
    internal class Dungeoncrawler
    {
        public static Races PlayerRace { get; private set; }

        static void Main(string[] args)
        {
            bool alive = true;
            bool dungeon = true;
            bool mainmenu = true;
            int exp = 0;


            //DONT FORGET TO ENABLE MUSIC ON LIVE. CURRENTLY OFF TO NOT DRIVE ME CRAZY WHILE TESTING

            //SoundPlayer musicPlayer = new SoundPlayer();
            //musicPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "./ES_Drone Spooky Sweeper - SFX Producer.wav";//put the .wav in the same directory as the class running this code.

            //musicPlayer.PlayLooping();

            Console.Title = "The Edge of Insanity";


            //TODO Figure out how to asign music to different rooms / different monsters.

            #region Pentagram
            string pentagram = @"
            ._                                            ,
             (`)..                                    ,.-')
              (',.)-..                            ,.-(..`)         
               (,.' ,.)-..                    ,.-(. `.. )                    
                (,.' ..' .)-..            ,.-( `.. `.. )                     
                 (,.' ,.'  ..')-.     ,.-( `. `.. `.. )                      
                  (,.'  ,.' ,.'  )-.-('   `. `.. `.. )                       
                   ( ,.' ,.'    _== ==_     `.. `.. )                        
                    ( ,.'   _==' ~  ~  `==_    `.. )                     
                     \  _=='   ----..----  `==_   )                     
                  ,.-:    ,----___.  .___----.    -..                        
              ,.-'   (   _--====_  \/  _====--_   )  `-..                 
          ,.-'   .__.'`.  `-_I0_-'    `-_0I_-'  .'`.__.  `-..     
      ,.-'.'   .'      (          |  |          )      `.   `.-..  
  ,.-'    :    `___--- '`.__.    / __ \    .__.' `---___'    :   `-..      
-'_________`-____________'__ \  (O)  (O)  / __`____________-'________`-     
                            \ . _  __  _ . /                               
                             \ `V-'  `-V' |                                 
                              | \ \ | /  /                                 
                               V \ ~| ~/V                                   
                                |  \  /|             The Edge of Insanity                      
                                 \~ | V             'Sometimes, the Realm of Hell is closer than you think.'                     
                                  \  |                                        
                                   VV
        ";
            Console.WriteLine(pentagram);
            Console.WriteLine("***DISCLAIMER, THIS GAME TOUCHES SUBJECTS SUCH AS ABUSE, MENTAL ILLNESS, AND HARDSHIPS OF HUMANS. PLAY AT YOUR OWN RISK.***");
            Console.WriteLine("Before we begin, what is your name?");
            string username = Console.ReadLine();



            #endregion
            Console.Clear();

            Console.WriteLine("Welcome, mortal. Inside await the horrors of which no mortal dares to see. Are you sure you want to continue?\n\n");
            Console.WriteLine("Press 'Enter' when you are ready to begin.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("Please select a race from the list below.\n\n");

            var races = Enum.GetValues(typeof(Races));
            int index = 0;
            foreach (var race in races)
            {
                Console.WriteLine(index + ") " + race);
                index++;
            }


            int userInput = int.Parse(Console.ReadLine());
            Races userrace = (Races)userInput;



            Console.Clear();

            Console.WriteLine("Please pick a weapon!");


            var weapons = Enum.GetValues(typeof(Weapons));
            int index2 = 0;
            foreach (var weapon in weapons)
            {
                Console.WriteLine(index2 + ") " + weapon);
                index2++;
            }
            int userInput2 = int.Parse(Console.ReadLine());
            Weapons userweap = (Weapons)userInput2;

            Weapon weapon1 = new Weapon(userweap);

            Console.Clear();

            Console.WriteLine("So, your name is " + username + " , you are carrying a " + userweap + ", and you are a " + userrace + ". Is this information correct? Please type 'Yes' or 'No' ");
            string useranswer = Console.ReadLine();
            switch (useranswer)
            {
                case "Yes":
                    break;
                case "No":
                    alive = false;
                    break;
            }





            Player playercharacter = new Player(username, userrace, weapon1);


            //TODO Create more options for character creation
            //TODO Figure out how to assign specific classes IE Rogue, Paladin.
            //Create a loot system of coins after defeating a monster.k




            Console.Clear();

            Console.WriteLine("Here is where your adventure begins.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("In this world, you will experience things thought obscure and obscene." + "\n Some people are fortunate to never experience these things." + "\n\nHowever, there are many of us that do. For some, these things are a walk in the park." + "\nFor others, these things can cripple." + "\n\nSometimes, they can even kill." + "\n\n" + username + ", the things you experience here may change your outlook on life.\n\n");
            Console.WriteLine("Press 'enter' to continue.");
            Console.ReadKey(true);


            Console.Clear();





            Console.WriteLine();
            Console.WriteLine();




            do
            {
                Room room = Room.GetRoom();
                Monsters monster = Monsters.SpawnMonsters();

                Console.WriteLine($"{room.Floor}");



                bool innerloop = true;
                do
                {


                    Console.WriteLine("\n\n1) Attack" +
                        "\n\n2) Run away" +
                        "\n\n3) Your information" +
                        "\n\n4) Monster's information" +
                        "\n\n5) Exit the Program");
                    string command = Console.ReadLine();
                    Console.Clear();

                    switch (command)
                    {
                        case "attack":
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Attacking!");
                            Combat.DoBattle(playercharacter, monster);
                            if (monster.Health <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\n You killed {monster.Name}!");
                                Console.Beep(700, 500);
                                Console.ResetColor();
                                innerloop = false;
                            }



                            break;

                        case "Run":
                        case "2":
                            Console.Clear();
                            Console.WriteLine($"You decide to swiftly sprint in the opposite direction.\n However, as you turn, {monster.Name} attacks you as you flee! ");
                            Combat.DoAttack(monster, playercharacter);
                            Console.WriteLine("Press 'enter' to continue..");
                            Console.ReadKey();
                            innerloop = false;
                            break;

                        case "3":
                        case "your info":
                            Console.WriteLine("Here's your info!");
                            Console.WriteLine(playercharacter);
                            break;


                        case "4":
                        case "Monster info":
                            Console.WriteLine("Here's the monsters info!");
                            Console.WriteLine(monster);
                            break;



                        case "Exit":
                        case "5":
                            Console.WriteLine("See ya later!");
                            dungeon = false;
                            break;




                    }
                } while (innerloop && dungeon);


            } while (dungeon == true);


















            #region Terminator
            Console.WriteLine("\n\n\nPress any key to exit the application...");
            Console.ReadKey(true);
            #endregion














        }
    }
}
