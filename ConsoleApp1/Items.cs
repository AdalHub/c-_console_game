using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Items
    {
        public string Name { get; set; }
        public float condition;
        public float durability;
        public float damage;
        public int purchaseCost;
        public int sellCost;
        public bool usable;

        abstract public float use();
    }

    class Sword: Items {
        
        public Sword(string name, float durability, float damage, int purchaseCost, int sellCost)
        {
            condition = 100.0F;
            usable = true;

            Name = Name;
            this.durability = durability;
            this.damage = damage;
            this.purchaseCost = purchaseCost;
            this.sellCost = sellCost;
            
        }

        public override float use()
        {
            if (!usable) {
                Console.WriteLine($"{Name} is broken!");
                return 0f; 
            }
            condition -= 1 * durability;
            return damage;
        }

    }

}
