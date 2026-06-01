using System;
using ConsoleApp1;

class Program
{

    static void Main(string[] args)
    {

        Player myPlayer = new Player();
        Console.WriteLine("Enter name");
        myPlayer.name = Console.ReadLine();
        
        Console.WriteLine($"Welcome to console game, {myPlayer.name}");
        
        
        Goblin goblin1 = new Goblin("grichard", 100, 10);
        Console.WriteLine("Will you attack? \n For attack enter: A");
        string userInput = Console.ReadLine();
        if (userInput == "A")
        {
            Console.WriteLine($"You just did {myPlayer.attackDamage} damage");
            goblin1.recieveDamage(myPlayer.attack());

        }
        else
        {
            myPlayer.recieveDamage(goblin1.Damage);

            Console.WriteLine("You missed!\n");
            myPlayer.playerStats();
        }
    }
}