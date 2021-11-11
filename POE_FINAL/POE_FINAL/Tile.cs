using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    public enum TileType //TileEnum
    {
        Hero,
        Enemy,
        Gold,
        Weapon,
        Goblin,
        Mage
    }

    /// <summary>
    /// An abstract class that g
    /// </summary>
    public abstract class Tile 
    {
        protected int x ;
        /// <summary>
        /// Returns the x Position of a Tile
        /// </summary>
        /// <returns></returns>
        public int getX()
        {
            return this.x;
            
        }

        public void setX(int x)
        {
            this.x = x;
        }


        protected int y;

        public int getY()
        { 
            return this.y;
        }

        public void setY(int y)
        {
            this.y = y;
        }


        protected string symbol;

        public string GetSymbol()
        {
            return this.symbol;
        }
        public void SetSymbol(string symbol)
        {
            this.symbol = symbol;
        }

        public Tile(int xAxis, int yAxis)
        {
            this.x = xAxis;
            this.y = yAxis;          
            
        }
        public override bool Equals(Object obj)
        {
            Tile tile = obj as Tile;
            return this.x == tile.x && this.y == tile.y && this.symbol == tile.symbol;
        }
    }
}
