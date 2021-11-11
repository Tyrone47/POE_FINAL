using System;
using System.Collections.Generic;
using System.Text;

namespace POE_FINAL
{
    class Gold : Item
    {

        private int goldAmmount;
        private Random random;
        



        public int GetGoldAmmount()
        {
            return this.goldAmmount;
        }

       

        public Gold(int x , int y) : base(x, y) 
        {
            this.random = new Random();
            this.goldAmmount = this.random.Next(1, 6);
            this.symbol = "0";//Represents Gold in game
        
        }
        public override string ToString()
        {
            return "Gold";
        }
    }
}
