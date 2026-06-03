using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Items
    {
        string Name { get; set; }
        bool Usable { get; set; }
    }

    interface Weapons : Items
    {
        float Condition { get; set; }
        float Durability { get; set; }
        float Damage { get; set; }
        int PurchaseCost { get; set; }
        int SellCost { get; set; }
        float Accuracy { get; set; }

        float use();

    }

    interface Potion : Items
    {
        float Quantity { get; set; }
        int PurchaseCost { get; set; }
        int SellCost { get; set; }
        Qualities Quality { get; set; }
    }

    enum Qualities
    {
        Low,
        Medium,
        High,
        STier
    }


}