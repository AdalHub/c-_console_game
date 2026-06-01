using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Player
    {
        public string name = "playa";
        int health = 100;
        public int attackDamage = 10;
        public void attack()
        {
            Console.WriteLine($"You just attacked {attackDamage}");
        }

    }

}
