using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    class Leader : Enemy
    {
        
        private Tile leaderTarget;

        public Tile GetleadTarget()
        {
            return this.leaderTarget;
          
        }

        public void SetleadTarget(Tile target)
        {
            this.leaderTarget = target;
        }

        public Leader(int x, int y ) : base(x, y, 2, 20, "L")
        {
            this.weapon = new MeleeWeapon(Type.Longsword, "Ls");
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NOMOVEMENT)
        {
            int x = this.leaderTarget.getX();
            int y = this.leaderTarget.getY();
            bool isValidMove = false;
            //if target is UP, leader should move up

            if (y > this.y )
            {
                if (this.characterVision[0].Equals(new EmptyTile(this.x, this.y + 1)))
                {
                    return MovementEnum.UP;
                }
                this.random = new Random();
                int randMove = this.random.Next(2, 5);
                isValidMove = false;
                while (!isValidMove)
                {
                    MovementEnum moves = (MovementEnum)randMove;
                    if ((moves == MovementEnum.DOWN && this.characterVision[1].Equals(new EmptyTile(this.x, this.y - 1))) 
                       || (moves == MovementEnum.LEFT && this.characterVision[2].Equals(new EmptyTile(this.x-1, this.y)))
                       || (moves == MovementEnum.RIGHT && this.characterVision[3].Equals(new EmptyTile(this.x+1, this.y))))
                    {
                        isValidMove = true;
                    }
                }
                if (isValidMove)
                {
                    return move;
                }
            }

            
            //target is down
            if(y < this.y )
            {
                if (this.characterVision[1].Equals(new EmptyTile(this.x, this.y - 1)))
                {
                    return MovementEnum.DOWN;
                }
                this.random = new Random();
                int randMove = this.random.Next(1, 5);

                while (randMove == 2)//1,3,4
                {
                    randMove = this.random.Next(1, 5);
                } 

                isValidMove = false;
                while (!isValidMove)
                {
                    MovementEnum moves = (MovementEnum)randMove;
                    if ((moves == MovementEnum.UP && this.characterVision[0].Equals(new EmptyTile(this.x, this.y + 1)))
                       || (moves == MovementEnum.LEFT && this.characterVision[2].Equals(new EmptyTile(this.x - 1, this.y)))
                       || (moves == MovementEnum.RIGHT && this.characterVision[3].Equals(new EmptyTile(this.x + 1, this.y))))
                    {
                        isValidMove = true;
                    }
                }
                if (isValidMove)
                {
                    return move;
                }
            }
            //target is left
            if (x < this.x )
            {
                if (this.characterVision[2].Equals(new EmptyTile(this.x - 1, this.y)))
                {
                    return MovementEnum.LEFT;
                }
                this.random = new Random();
                int randMove = this.random.Next(1, 5);
               
                while (randMove == 3)
                {
                    randMove = this.random.Next(1, 5);
                }
                
                isValidMove = false;
                while (!isValidMove)
                {
                    MovementEnum moves = (MovementEnum)randMove;
                    if ((moves == MovementEnum.UP && this.characterVision[0].Equals(new EmptyTile(this.x, this.y + 1)))
                       || (moves == MovementEnum.DOWN && this.characterVision[1].Equals(new EmptyTile(this.x, this.y - 1)))
                       || (moves == MovementEnum.RIGHT && this.characterVision[3].Equals(new EmptyTile(this.x + 1, this.y))))
                    {
                        isValidMove = true;
                    }
                }
                if (isValidMove)
                {
                    return move;
                }
            }
            //target is right
            if (x > this.x )
            {
                if (this.characterVision[3].Equals(new EmptyTile(this.x + 1, this.y)))
                {
                    return MovementEnum.RIGHT;
                }
                this.random = new Random();
                int randMove = this.random.Next(1, 4);

                isValidMove = false;
                while (!isValidMove)
                {
                    MovementEnum moves = (MovementEnum)randMove;
                    if ((moves == MovementEnum.UP && this.characterVision[0].Equals(new EmptyTile(this.x, this.y + 1)))
                       || (moves == MovementEnum.DOWN && this.characterVision[1].Equals(new EmptyTile(this.x, this.y - 1)))
                       || (moves == MovementEnum.LEFT && this.characterVision[2].Equals(new EmptyTile(this.x + 1, this.y))))
                    {
                        isValidMove = true;
                    }
                }
                if (isValidMove)
                {
                    return move;
                }
            }
            return move;
        }

    }
}
