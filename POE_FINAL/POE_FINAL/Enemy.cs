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
            enemyStats += typeof(Enemy).Name + " at[ " + this.x + "," + this.y + "] (Amount DMG = " + this.damage + ")";

            return enemyStats
        }
    }
}
