using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1
{

    interface IshopNpc
    {
        string MerchantName { get; }
        int Health { get; }
        int AttackDammage { get; }
        bool Alive {  get; }
        int attack();

    }
    interface Ishops
    {
        string ShopName { get; set; }
        int Balance{ get; set; }
        string[] Inventory { get; set; }
        void sell();

        void purchase();
    }

    class WeaponDealer : Ishops, IshopNpc
    {
        public string MerchantName { get; set; }
        public int Health { get; set { Math.Max(0, value); } }
        public int AttackDammage { get; set; }
        public bool Alive { get; set; }

        public string ShopName { get; set; }
        public int Balance { get; set; }
        public string[] Inventory { get; set; }

        public WeaponDealer()
        {
            MerchantName = "Bob The Smoker";
            Health = 100;
            AttackDammage = 10;
            Alive = true;

            ShopName = "Weapon Dealer";
            Balance = 1000;
            string[] Inventory = { "sword" };
        }

        public int attack()
        {
            return AttackDammage;
        }

        public void sell( ) {
            
        }

        public void purchase()
        {

        }
    }
}
