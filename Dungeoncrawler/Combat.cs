using CharacterInformation;
using PlayerToon;
using CharacterStats;
namespace Dungeoncrawler;

public class Combat
{
    //This class will not have any fields, properties, or constructors. It is just a method warehouse for combat functionality.

    public static void DoAttack(Stats playercharacter, Stats monster)
        
    {
        //get a random number from 1 to 100 as our dice roll.
        Random rand = new Random();
        int diceroll = rand.Next(1, 101);
        Thread.Sleep(300); //1000 is one second. This slowes down the game!
        if (diceroll <= (playercharacter.Attack - monster.Defense))
        {
            //we hit!
            // calculate damage and save it to a variable.
            int damageDealt = playercharacter.CalcDamage();
            playercharacter.Health -= damageDealt;
            //write result to screen
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{playercharacter.Name} hit {monster.Name} for {damageDealt} damage!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine($"{playercharacter.Name} missed!");
        }
    }




    public static void DoBattle(Stats playercharacter, Stats monster)
    {
        //player attacks first
        DoAttack(playercharacter, monster);
        if (monster.Health > 0)
        {
            DoAttack(monster, playercharacter);
        }

    }
}