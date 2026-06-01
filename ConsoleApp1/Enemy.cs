using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public int Damage { get; set; }
        
        public void recieveDamage(int dmg)
        {
            Health -= dmg;
        }

        
    }

    class Goblin: Enemy
    {
        string enemyType = "goblin";


        public Goblin(string name, int health, int damageOutput)
        {
            Name = name;
            Health = health;
            Damage = damageOutput;
            Console.WriteLine($"A {enemyType} has appeared named {Name}");
        }
            
    }
}
