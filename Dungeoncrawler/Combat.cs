using CharacterInformation;
using CharacterStats;
namespace Dungeoncrawler;

public class Combat
{
    //This class will not have any fields, properties, or constructors. It is just a method warehouse for combat functionality.

    public static void DoAttack(Stats attacker, Stats defender)
    {
        //get a random number from 1 to 100 as our dice roll.
        Random rand = new Random();
        int diceroll = rand.Next(1, 101);
        Thread.Sleep(300); //1000 is one second. This slowes down the game!
        if (diceroll <= (attacker.Block() - defender.Block()))
        {
            //we hit!
            // calculate damage and save it to a variable.
            int damageDealt = attacker.CalcDamage();
            defender.Health -= damageDealt;
            //write result to screen
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine($"{attacker.Name} missed!");
        }
    }




    public static void DoBattle(Stats player, Stats monster)
    {
        //player attacks first
        DoAttack(player, monster);
        if (monster.Health > 0)
        {
            DoAttack(monster, player);
        }

    }
}