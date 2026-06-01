using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Player
    {
  

        public string Name{ get; set; }
        private int Health { get; set; }
        private int Damage{ get; set; }


        public Player(string name="ADAL", int health= 100, int damage=10)
        {
            Name = name;
            Health = health;
            Damage= damage;

        }

        public int attack()
        {
            Console.WriteLine($"You just attacked {Damage}");
            return Damage;
        }

        public void recieveDamage(int dmg)
        {
            Health-= dmg;
        }

        public void playerStats()
        {
            Console.WriteLine($"NAME: {Name}, HEALTH: {Health}, ATTACK DMG: {Damage}");
        }


    }

}
