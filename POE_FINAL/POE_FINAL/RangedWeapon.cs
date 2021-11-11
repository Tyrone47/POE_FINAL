using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    public enum Types
    {
        Rifle,
        Longbow
    }
    class RangedWeapon : Weapon
    {
        public override int GetRange()
        {
            return base.range;
        }

        public RangedWeapon(Types weaponTypes, int x, int y, string symbol) : base(x, y, symbol)
        {
            if (weaponTypes == Types.Rifle)
            {
                this.weaponType = "Rifle";
                this.range = 3;
                this.durability = 3;
                this.damage = 5;
                this.cost = 7;
            }
            else if (weaponTypes == Types.Longbow)
            {
                this.weaponType = "Longbow";
                this.durability = 4;
                this.range = 2;
                this.damage = 4;
                this.cost = 6;
            }
        }

        public RangedWeapon(Types weaponTypes ,int x, int y, string symbol, int durability) : base(x, y, symbol)
        {
            if (weaponTypes == Types.Rifle)
            {
                this.weaponType = "Rifle";
                this.range = 3;
                this.durability = durability;
                this.damage = 5;
                this.cost = 7;
            }
            else if (weaponTypes == Types.Longbow)
            {
                this.weaponType = "Longbow";
                this.durability = durability;
                this.range = 2;
                this.damage = 4;
                this.cost = 6;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
