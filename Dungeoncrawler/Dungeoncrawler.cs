using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using CharacterStats;
using RoomLibrary;


    namespace Block1
{
    internal class Dungeoncrawler
    {
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

            Console.WriteLine("***DISCLAIMER, THIS GAME TOUCHES SUBJECTS SUCH AS ABUSE, MENTAL ILLNESS, AND HARDSHIPS OF HUMANS. PLAY AT YOUR OWN RISK.***");
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
            Console.WriteLine("Before we begin, what is your name?");
            string username = Console.ReadLine();
            //Ask for character info "Race, Class, Name"
            #endregion
            Console.Clear();
            do
            {
                Console.WriteLine("Welcome, mortal. Inside await the horrors of which no mortal dares to see. Are you sure you want to continue?\n\n");
                Console.WriteLine("Press 'Enter' when you are ready to begin.");
                Console.ReadKey(true);

                //TODO Create more options for character creation
               //TODO Figure out how to assign specific classes IE Rogue, Paladin.

                Console.Clear();
                Console.WriteLine("Here is where your adventure begins.");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                
                
                Console.WriteLine("In this world, you will experience things thought obscure and obscene." + "\n Some people are fortunate to never experience these things." + "\n\nHowever, there are many of us that do. For some, these things are a walk in the park." + "\nFor others, these things can cripple." + "\n\nSometimes, they can even kill." + "\n\n" + username + ", the things you experience here may change your outlook on life.\n\n");
                Console.WriteLine("Press 'enter' to continue.");
                Console.ReadKey(true);

                ///TODO Create RNG Room generator (use tips from Zach to create it)
                Console.Clear();
                Room room = Room.GetRoom();

                Console.WriteLine(room.Floor);
                
              
                Console.WriteLine();
                Console.WriteLine();

                

               
                do
                {
                    



                    Console.WriteLine("\n\n1) Attack" +
                        "\n\n2) Run away" +
                        "\n\n3) Your information" +
                        "\n\n4) Monster's information" +
                        "\n\n5) Exit the Program");
                    string command = Console.ReadLine();

                    switch (command)
                    {
                        case "attack":
                        case "1":
                            Console.Clear();
                            Console.WriteLine("*You violently start flailing your arms, as you have no weapon yet. The monster looks at you inquisitively and slugs a giant scaley arm towards you. You fly off in a completely different direction.");
                            Console.WriteLine("*You slam into a wall, your body completely disentegrates into nothingness. Pretty sure you're dead.");
                            dungeon = false;
                            break;

                        case "Run":
                        case "2":
                            Console.Clear();
                            Console.WriteLine("*You decide to swiftly sprint in the opposite direction. Probably one of the better desisions you've ever had.");
                            dungeon = false;
                            break;

                        case "3":
                        case "your info":
                            break;
                            

                        case "4":
                        case "Monster info":
                            break;

                            

                        case "Exit":
                        case "5":
                            dungeon = false;
                            alive = false;
                            break;



                    }



                } while (dungeon);







            } while (alive);










            #region Terminator
            Console.WriteLine("\n\n\nPress any key to exit the application...");
            Console.ReadKey(true);
            #endregion














        }
    }
}
