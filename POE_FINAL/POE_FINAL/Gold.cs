using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    public class Gold : Item
    {

        private int goldAmmount;
        private Random random;
   
        public int GetGoldAmmount()
        {
            return this.goldAmmount;
        }

        public void SetGoldAmmount( int goldAmmount)
        {
            this.goldAmmount = goldAmmount;
        }

       

        public Gold(int x , int y) : base(x, y) 
        {
            this.random = new Random();
            this.goldAmmount = this.random.Next(1, 6);
            this.symbol = "0";//Represents Gold in game
        
        }

        public Gold(int x, int y, int goldAmmount) : base(x,y)
        {
            this.random = new Random();
            this.goldAmmount = goldAmmount;
            this.symbol = "0";
        }

        public override string ToString()
        {
            return "Gold";
        }
    }
}
