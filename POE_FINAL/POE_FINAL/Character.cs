using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    
    public enum MovementEnum
    {
        NOMOVEMENT,
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public enum Directions
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }
    public abstract class Character : Tile
    {
        private int goldPurse; 

        public int GetGoldPurse()
        {
            return this.goldPurse;
        }

        public void SetGoldPurse(int goldBag)
        {
            this.goldPurse = goldBag;
        }

        public void IncrementGoldAmmount(int goldAmmount)
        {
            this.goldPurse += goldAmmount;
        }

        protected int HP;
        protected int maxHP;
        protected int damage;

        public int GetHP()
        {
            return HP;

        }
        public void SetHP(int hP)
        {
            this.HP = hP;
        }
        public int GetMaxHP()
        {
            return HP;

        }

        public void SetMaxHP(int maxiHp)
        {
            this.maxHP = maxiHp;

        }
        public int GetDamage()
        {
            return damage;

        }
        public void SetDamage(int damage)
        {
            this.damage = damage;

        }


        protected Tile[] characterVision;
     
        public Tile[] GetCharacterVision() 
        {
            return this.characterVision;
        }

        public void  SetCharacterVision(Tile tile,int position)
        {
            //0 Represents ------> UP,
            //1 Represents ------> DOWN,
            //2 Represents ------> RIGHT
            //3 Represemts ------> LEFT
            if ( 0 <= position && position <= this.characterVision.Length - 1)
            {
                this.characterVision[position] = tile;
            }
           
        }

        public Character (int xPos , int yPos , string symbol) : base(xPos, yPos)
        {
            this.symbol = symbol;
            this.characterVision = new Tile[4];
            this.goldPurse = 0;
        }

        public virtual void Attack(Character target) { }
        

        public bool IsDead ()
        {
            if (HP == 0)
            {
                return this.HP == 0;
            }
            return false;
        }

        public virtual bool CheckRange(Character target)
        {
            int distance = this.DistanceTo(target);
            if (distance == 1)
            {
                return true;
            } 
            return false;

        }

        protected int DistanceTo(Character target)
        {
            return Math.Abs(this.x - target.x) + Math.Abs(this.y - target.y);//To implement
        }
        public void Move(MovementEnum move)
        {
            if (move == MovementEnum.UP)
            {
                this.y++;
            }
            else if(move == MovementEnum.DOWN)
            {
                this.y--;
            }
            else if(move == MovementEnum.LEFT)
            {
                this.y--;

            }
            else if(move == MovementEnum.RIGHT)
            {
                this.y++;
            }
            else
            {
                move = MovementEnum.NOMOVEMENT;
            }
            
        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0);
        
        public abstract override string ToString();

        public void Pickup (Item i)
        {
            if (i.GetType() == typeof(Gold))
            {
                Gold g = (Gold)i;
                this.IncrementGoldAmmount(g.GetGoldAmmount());
            }
        }

    }
}
