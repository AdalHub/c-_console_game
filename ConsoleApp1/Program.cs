using System;
using ConsoleApp1;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Enter name");
        string playerName = Console.ReadLine();
        Player myPlayer = new Player(playerName);
        Console.WriteLine($"Welcome to console game, {myPlayer.Name}");
        
        
        Goblin goblin1 = new Goblin("grichard", 100, 10);
        Console.WriteLine("Will you attack? \n For attack enter: A");
        string userInput = Console.ReadLine();
        if (userInput == "A")
        {
            Console.WriteLine($"You just did {myPlayer.attack()} damage");
            goblin1.recieveDamage(myPlayer.attack());

        }
        else
        {
            myPlayer.recieveDamage(goblin1.attack());

            Console.WriteLine("You missed!\n");
            myPlayer.playerStats();
        }
    }
}