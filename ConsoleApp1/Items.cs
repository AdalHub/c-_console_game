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
        public float accuracy;

        abstract public float use();
    }

    class Sword: Items {
        
        public Sword(string name, float durability, float damage, int purchaseCost, int sellCost, float accuracy)
        {
            condition = 100.0F;
            usable = true;

            Name = Name;
            this.durability = durability;
            this.damage = damage;
            this.purchaseCost = purchaseCost;
            this.sellCost = sellCost;
            this.accuracy= accuracy;


        }

        public override float use()
        {
            if (!usable) {
                Console.WriteLine($"{Name} is broken!");
                return 0f; 
            }

            condition -= 1 * durability;

            Random rand = new Random();

            // for swords they the damage delt depends on the effectiveness of the hit
            float totalDamage = damage * (rand.Next(1, 100) * .001f);
            Console.WriteLine($"You took a jab! \n {totalDamage} was delt.");
            return totalDamage;
        }

    }

    class Gun : Items
    {

        public Gun(string name, float durability, float damage, int purchaseCost, int sellCost, float accuracy)
        {
            condition = 100.0F;
            usable = true;

            Name = Name;
            this.durability = durability;
            this.damage = damage;
            this.purchaseCost = purchaseCost;
            this.sellCost = sellCost;
            this.accuracy= accuracy;

        }

        public override float use()
        {
            if (!usable)
            {
                Console.WriteLine($"{Name} is broken!");
                return 0f;
            }
            condition -= 1 * durability;

            Random rand = new Random();
            
            //For guns if the random number is within the accuracy range it will be successful
            if(rand.Next(1, 100) <= accuracy)
            {
                Console.WriteLine("Your shot landed!");
                return damage;
            }
            else
            {
                Console.WriteLine("Your shot missed! \n 0 damage delt.");
                return 0f;
            }
            
            
        }

    }

}
