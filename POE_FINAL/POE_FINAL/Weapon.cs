using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    public abstract class Weapon : Item
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected string weaponType;
        

        public void SetDamage(int damage)
        {
            this.damage = damage;
        }

        public int GetDamage()
        {
            return this.damage;
        }

        public virtual void SetRange(int range)
        {
            this.range = range;
        }

        public virtual int GetRange()
        {
            return this.range;
        }

        public void SetDurability(int durability)
        {
            this.durability = durability;
        }

        public int GetDurability()
        {
            return this.durability;
        }

        public void SetCost(int cost)
        {
            this.cost = cost;
        }

        public int GetCost()
        {
            return this.cost;
        }

        public void SetWeaponType(string weaponType)
        {
            this.weaponType = weaponType;
        }

        public string GetWeaponType()
        {
            return this.weaponType;
        }

        public Weapon(int x , int y , string symbol) : base(x,y)
        {
            this.symbol = symbol;
        }
    }
}
