using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    class Obstacle : Tile
    {
        public Obstacle(int x , int y) : base(x, y) 
        {
            this.symbol = "X";
        }
        
    }
}
