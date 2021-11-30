using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    public class Shop 
    {
        private Weapon[] weaponsArray;

        private Random random;

        private Character buyer;

        public Shop(Character buyer)
        {
            this.buyer = buyer;
            this.weaponsArray = new Weapon[4];
            this.random = new Random();

            for (int i = 0; i < this.weaponsArray.Length; i++)
            {
                this.weaponsArray[i] = this.RandomWeapon();
            }


        }

        private Weapon RandomWeapon()
        {
            int random = this.random.Next(1,5);
            Weapon weapon = null;
            if (random == 1) // Creates a Dagger
            {
                 weapon = new MeleeWeapon(Type.Dagger, "D");
            }
            else if (random == 2) // Creates a Longsword
            {
                 weapon = new MeleeWeapon(Type.Longsword, "Ls");
            }
            else if (random == 3)  //Creates a Longbow
            {
                 weapon = new RangedWeapon(Types.Longbow, "B");
            }
            else if (random == 4) // Creates a Rifle
            {
                  weapon = new RangedWeapon(Types.Rifle, "R");
            }

            return weapon;
            
        }

        private bool CanBuy(int num)
        {

            int playerGold;
            int weaponCost;
            bool canBuy = false;

            if (num < 0 || num > this.weaponsArray.Length - 1)
            {
                throw new System.IndexOutOfRangeException("It is out of bounds. No weapon found in that position");
            }

             playerGold = this.buyer.GetGoldPurse();
             weaponCost = this.weaponsArray[num].GetCost();

            if (playerGold >= weaponCost )
            {
                canBuy = true;
            }
            
           return canBuy;
        }

        public void Buy(int num)
        {
            if (this.CanBuy(num))
            {
                this.buyer.SetGoldPurse(this.buyer.GetGoldPurse() - this.weaponsArray[num].GetCost());
                this.buyer.Pickup(this.weaponsArray[num]);
                this.weaponsArray[num] = this.RandomWeapon();
            }

        }

        public string DisplayWeapon(int num)
        {
            string weaponStats = "";

            if (num == 0)
            {
                weaponStats += "Buy " + weaponsArray[0].GetWeaponType() + " for " + weaponsArray[0].GetCost() + " Gold";
            }
            else if (num == 1)
            {
                weaponStats += "Buy " + weaponsArray[1].GetWeaponType() + " for " + weaponsArray[1].GetCost() + " Gold";
            }
            else if (num == 2)
            {
                weaponStats += "Buy " + weaponsArray[2].GetWeaponType() + " for" + weaponsArray[2].GetCost() + " Gold";
            }
            else if (num == 3)
            {
                weaponStats += "Buy " + weaponsArray[3].GetWeaponType() + " for" + weaponsArray[3].GetCost() + " Gold";
            }

            return weaponStats;
        }
    }
}
