using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    class Mage : Enemy
    {

        public Mage(int x, int y) : base(x, y, 5, 5, "M")
        {
            this.SetGoldPurse(3);
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            return MovementEnum.NOMOVEMENT;
        }

        public override bool CheckRange(Character target)
        {
            //M : denote Mage
            /**
             *  M : Denote Mage
             *  E : Denote Enemy
             *  
             *  M (x,y)  ------> Top/North E    (x , y + 1)      Distance is 1
             *           ------> Bottom/South E (x , y -1)       Distance is 1
             *           ------> Right/East E   (x + 1 , y)      Distance is 1
             *           ------> Left/West E    (x - 1, y)       Distance is 1
             *           ------> North East E   (x + 1 , y + 1)  Distance is 2
             *           ------> South East E   (x + 1 , y -1 )  Distance is 2
             *           ------> North West E  (x - 1 , y + 1)   Distance is 2
             *           ------> South West E  (x - 1 , y - 1)   Distance is 2
             **/


            if (target.GetType() == typeof(Goblin) ||
                target.GetType() == typeof(Mage)   ||
                target.GetType() == typeof(Leader) ||
                target.GetType() == typeof(Hero))
            {
                int distance = this.DistanceTo(target);
                if (distance == 1 || distance == 2)
                {
                    return true;
                }
            }
            return false;
        }
        public override void Attack(Character target)
        {
            if (!target.IsDead() && this.CheckRange(target))
            {
                target.SetHP(target.GetHP() - 5);
            }
        }

        public override void Loot(Character target)
        {
            if (target.IsDead())
            {
                //Loot Gold.
                this.SetGoldPurse(this.GetGoldPurse() + target.GetGoldPurse());
                target.SetGoldPurse(0);
            }

        }

        public override string ToString()
        {
            string mageStats = "";
            if (this.GetWeapon() == null)
            {
                mageStats += "Barehanded: " + typeof(Mage).Name + "(" + this.HP + "/" + this.maxHP + "HP) at[ " + this.x + "," + this.y + "] (" + this.damage + ")"
                          + this.GetGoldPurse() + ")";
            }
            else
            {
                mageStats += "Equipped: " + typeof(Mage).Name + "(" + this.HP + "/" + this.maxHP + "HP) at[ " + this.x + "," + this.y + "] with "
                           + this.GetWeapon().GetWeaponType() + " (" + this.GetWeapon().GetDurability() + "x" + this.GetWeapon().GetDamage() + ") Gold( "
                           + this.GetGoldPurse() + ")";
            }
            return mageStats;
        }
    }
}
