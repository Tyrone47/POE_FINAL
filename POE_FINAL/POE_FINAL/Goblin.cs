using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x, y , 10 , 1 ,"G")
        {
            
            this.random = new Random();
            this.weapon = new MeleeWeapon(Type.Dagger, "D");
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {

            MovementEnum movement = MovementEnum.NOMOVEMENT;//Initialised Movement to be NOMOVEMENT by default
            EmptyTile empty = new EmptyTile(0, 0);

            bool notFoundMovement = true;

            do
            {
                movement = (MovementEnum)random.Next(0, 5);
                if (movement == MovementEnum.UP && this.characterVision[0].Equals( new EmptyTile(this.x,this.y + 1)) )
                {
                    notFoundMovement = false;
                    
                    
                }
                else if (movement == MovementEnum.DOWN && this.characterVision[1].Equals(new EmptyTile(this.x, this.y - 1)))
                {
                    notFoundMovement = false;
                    

                }
                else if (movement == MovementEnum.LEFT && this.characterVision[2].Equals(new EmptyTile(this.x - 1, this.y)))
                {
                    notFoundMovement = false;
                    

                }
                else if (movement == MovementEnum.RIGHT && this.characterVision[3].Equals(new EmptyTile(this.x + 1, this.y )))
                {
                    notFoundMovement = false;
                    
                }
            } while (notFoundMovement);
           

            return movement;
             
        }
        public override void Attack(Character target)
        {
            if (this.CheckRange(target))
            {
                target.SetHP(target.GetHP() - 1);
            }
        }

        public override string ToString()
        {
            string goblinStats = "";
            // return typeof(Goblin).Name + " at[ " + this.x + "," + this.y + "] (Amount DMG = " + this.damage + ") (Current HP = " + this.GetHP() + ")";
            if (this.GetWeapon() == null)
            {
                goblinStats += "Barehanded: " + typeof(Goblin).Name + "(" + this.HP + "/" + this.maxHP + "HP) at[ " + this.x + "," + this.y + "] (" + this.damage + ")";
            }
            else
            {
                goblinStats += "Equipped: " + typeof(Goblin).Name + "(" + this.HP + "/" + this.maxHP + "HP) at[ " + this.x + "," + this.y + "] with "
                           + this.GetWeapon().GetWeaponType() + " (" + this.GetWeapon().GetDurability() + "x" + this.GetWeapon().GetDamage() + ")";
            }
            return goblinStats;
        }
    }
}
