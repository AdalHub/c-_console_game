using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class HealthPotion:Potion
    {
        public string Name { get; set; }
        public bool Usable { get; set; }
        public float Quantity { get; set; }
        public int PurchaseCost { get; set; }
        public int SellCost { get; set; }
        public Qualities Quality { get; set; }

        public HealthPotion(string name, bool usable, float quantity, int purchaseCost, int sellCost, Qualities quality)
        {
            Name= name;
            Usable = usable;
            Quantity = quantity;
            PurchaseCost = purchaseCost;
            SellCost = sellCost;
            Quality = quality;
        }
    }
}
