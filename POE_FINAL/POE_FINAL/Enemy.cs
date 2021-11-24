using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    public abstract class Enemy : Character
    {
        protected Random random;

        public Enemy(int x , int y , int damage, int maxHP , string symbol) : base(x, y, symbol )
        {
            this.damage = damage;
            this.maxHP = maxHP;
            this.HP = maxHP;
        }
        public override string ToString()
        {
            string enemyStats = "";

            if (this.GetWeapon() == null)
            {
                enemyStats += "Barehanded: " + typeof(Enemy).Name + this.HP + "/" + this.maxHP + " at[ " + this.x + "," + this.y + "] (" + this.damage + ")";
            }
            else
            {
                enemyStats += "Equipped: " + typeof(Enemy).Name + this.HP + "/" + this.maxHP + " at[ " + this.x + "," + this.y + "] with "
                           + this.GetWeapon().GetWeaponType() + " (" + this.GetWeapon().GetDurability() + "x" + this.GetWeapon().GetDamage();
            }
            //enemyStats += typeof(Enemy).Name + " at[ " + this.x + "," + this.y + "] (Amount DMG = " + this.damage + ")";
            // enemyStats += Mage at[ 4,13] (Amount DMG = 5)   (Current HP = 5)
            return enemyStats;
        }
    }
}
