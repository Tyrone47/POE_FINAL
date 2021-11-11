using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    public enum Type
    { 
        Dagger,
        Longsword

    }
        

    class MeleeWeapon : Weapon
    {
        public override int GetRange()
        {
            return this.range = 1;
        }

        

        public MeleeWeapon(Type weaponType,int x , int y , string symbol ) : base(x,y,symbol)
        {
            if(weaponType == Type.Dagger)
            {
                this.weaponType = "Dagger";
                this.durability = 10;
                this.damage = 3;
                this.cost = 3;
            }
            else if (weaponType == Type.Longsword)
            {
                this.weaponType = "Longsword";
                this.durability = 6;
                this.damage = 4;
                this.cost = 5;
            }

        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
