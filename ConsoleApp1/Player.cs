using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Player
    {
        public string name = "playa";
        int health = 100;
        private int Health { get { return health; } set { health = value; } }
        public int attackDamage = 10;
        public int attack()
        {
            Console.WriteLine($"You just attacked {attackDamage}");
            return attackDamage;
        }

        public void playerStats()
        {
            Console.WriteLine($"NAME: {name}, HEALTH: {health}, ATTACK DMG: {attackDamage}");
        }
        public void recieveDamage(int dmg)
        {
            Health-= dmg;
        }

    }

}
