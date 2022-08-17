using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
            int playerattack = 0;
            int monsterattack = 0;
            int monsterhealth = 0;

            //SoundPlayer musicPlayer = new SoundPlayer();
            //musicPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "./ES_Drone Spooky Sweeper - SFX Producer.wav";//put the .wav in the same directory as the class running this code.

            //musicPlayer.PlayLooping();
            
            Console.Title = "The Edge of Insanity";

            

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
            
            #endregion
            Console.Clear();
            do
            {
                Console.WriteLine("Welcome, mortal. Inside await the horrors of which no mortal dares to see. Are you sure you want to continue?\n\n Enter 'Ready' when you are ready to begin.");

                string usermainmenuanswer = Console.ReadLine();

                //TODO Create more options for character creation
                switch (usermainmenuanswer)
                {
                    case "ready":

                        break;
                    case "Ready":

                        break;

                }

                Console.Clear();
                Console.WriteLine("Here is where your adventure begins.");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                
                
                Console.WriteLine("In this world, you will experience things thought obscure and obscene." + "\n Some people are fortunate to never experience these things." + "\n\nHowever, there are many of us that do. For some, these things are a walk in the park." + "\nFor others, these things can cripple." + "\n\nSometimes, they can even kill." + "\n\n" + username + ", the things you experience here may change your outlook on life.");


                //TODO 1 create a monster
                //TODO 2 create a room for said monster
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("I can see that smug look on your face. You're probably thinking 'How can this possibly be that bad?" + "\n\nSo there's a monster right there, in front of you. What are you going to do?");
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

                        //case "Your Information"

                        //case "Monster Information"

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
