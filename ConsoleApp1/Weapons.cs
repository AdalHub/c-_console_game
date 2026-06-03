using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace ConsoleApp1
    {
        class Sword : Weapons
        {
            public string Name { get; set; }
            public bool Usable { get; set; }
            public float Condition { get; set; }
            public float Durability { get; set; }
            public float Damage { get; set; }
            public int PurchaseCost { get; set; }
            public int SellCost { get; set; }
            public float Accuracy { get; set; }

            public Sword(string name, float durability, float damage, int purchaseCost, int sellCost, float accuracy)
            {
                Condition = 100.0F;
                Usable = true;

                Name = name;
                Durability = durability;
                Damage = damage;
                PurchaseCost = purchaseCost;
                SellCost = sellCost;
                Accuracy = accuracy;
            }

            public float use()
            {
                if (!Usable)
                {
                    Console.WriteLine($"{Name} is broken!");
                    return 0f;
                }

                Condition -= 1 * Durability;

                Random rand = new Random();

                float totalDamage = Damage * (rand.Next(1, 100) * .001f);
                Console.WriteLine($"You took a jab! \n {totalDamage} was delt.");
                return totalDamage;
            }
        }

        class Gun : Weapons
        {
            public string Name { get; set; }
            public bool Usable { get; set; }
            public float Condition { get; set; }
            public float Durability { get; set; }
            public float Damage { get; set; }
            public int PurchaseCost { get; set; }
            public int SellCost { get; set; }
            public float Accuracy { get; set; }

            public Gun(string name, float durability, float damage, int purchaseCost, int sellCost, float accuracy)
            {
                Condition = 100.0F;
                Usable = true;

                Name = name;
                Durability = durability;
                Damage = damage;
                PurchaseCost = purchaseCost;
                SellCost = sellCost;
                Accuracy = accuracy;
            }

            public float use()
            {
                if (!Usable)
                {
                    Console.WriteLine($"{Name} is broken!");
                    return 0f;
                }
                Condition -= 1 * Durability;

                Random rand = new Random();

                if (rand.Next(1, 100) <= Accuracy)
                {
                    Console.WriteLine("Your shot landed!");
                    return Damage;
                }
                else
                {
                    Console.WriteLine("Your shot missed! \n 0 damage delt.");
                    return 0f;
                }
            }
        }
    }
}
