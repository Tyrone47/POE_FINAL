using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    public class Hero : Character
    {
        
        public Hero(int x, int y, int hP, string symbol) : base(x, y,symbol )
        {
            this.HP = hP;
            this.maxHP = hP;
            this.damage = 2;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            //0 in the character vision represents  ------> UP,
            //1 in the character visionRepresents ------> DOWN,
            //2 in the character visionRepresents ------> LEFT
            //3 in the character visionRepresemts ------> RIGHT

            if (move == MovementEnum.UP && (this.characterVision[0].Equals(new EmptyTile(this.x, this.y + 1))
                || this.characterVision[0].Equals(new Gold(this.x, this.y + 1)))) 
            {

                return move;

            }
            else if (move == MovementEnum.DOWN && (this.characterVision[1].Equals(new EmptyTile(this.x, this.y - 1))
                || this.characterVision[1].Equals(new Gold(this.x, this.y - 1))))
            {
                return move;

            }
            else if (move == MovementEnum.LEFT && (this.characterVision[2].Equals(new EmptyTile(this.x - 1, this.y ))
                || this.characterVision[2].Equals(new Gold(this.x - 1, this.y))))

            {

                return move;
            }
            else if (move == MovementEnum.RIGHT && (this.characterVision[3].Equals(new EmptyTile(this.x + 1, this.y))
                || this.characterVision[3].Equals(new Gold(this.x + 1, this.y))))
            {

                return move;
            }
            return MovementEnum.NOMOVEMENT;
        
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
            string playerStats = "";
            playerStats += " Player Stats: " + System.Environment.NewLine;
            playerStats += " HP: " + this.HP + "/" + this.maxHP + System.Environment.NewLine;
            playerStats += "Damage: " + this.damage + System.Environment.NewLine;
            playerStats += "[" + this.x + ", " + this.y + "]" + System.Environment.NewLine;
            playerStats += "Gold Ammount " + this.GetGoldPurse();

            return playerStats;               
        }

    }
}
