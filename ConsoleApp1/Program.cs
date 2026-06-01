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
        
        Console.WriteLine("For attack enter: A");
        string userInput = Console.ReadLine();
        if(userInput == "A")
        {
            Console.WriteLine($"You just did {myPlayer.attackDamage} damage");
        }
    }
}