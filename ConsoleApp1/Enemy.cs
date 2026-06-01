using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Enemy
    {
        protected string Name { get; set; }
        protected int Health { get; set; }
        protected int Damage { get; set; }
        
        public void recieveDamage(int dmg)
        {
            Health -= dmg;
        }
        public int attack()
        {
            return Damage;
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
            Console.WriteLine($"A {enemyType} has appeared named {Name}\n");
        }
        public int attack()
        {
            Console.WriteLine($"Goblin {Name} attacks!");
            return Damage;
        }
            
    }
}
