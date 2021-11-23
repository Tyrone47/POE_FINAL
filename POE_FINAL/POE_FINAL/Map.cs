using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace POE_FINAL
{
    public class Map
    {
        private Tile[,] tileMap;

        private Hero hero;

        private Enemy[] enemyArray;

        private Item[] items;

        private int width;

        private int height;

        private  Random random;

        public Enemy[] GetEnemyArray()
        {
            return this.enemyArray;
        }

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
      
        
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
       public Hero GetHero()
        {
            return this.hero;
        }

        public void placeTileOnMap(Tile tile)
        {
            this.tileMap[tile.getX(), tile.getY()] = tile;
        }
        


        public Map( int minWidth , int maxWidth, int minHeight , int maxHeight , int numOfEnemies , int goldDrops , int weaponDrops)
        {
            this.random = new Random();

            this.height = this.random.Next(minHeight, maxHeight + 1);
            this.width = this.random.Next(minWidth, maxWidth + 1);
            this.tileMap = new Tile[this.width,this.height];
            

            //This fills up the left side of the boarder Only.

            for (int j = 0; j < this.height; j++) 
            {
                Obstacle obstacle = new Obstacle(0, j);
                this.tileMap[0, j] = obstacle;
            }

            //This fills up the right side of the boarder only.
            //
            for (int j = 0; j < this.height; j++)
            {
                Obstacle obstacle = new Obstacle(this.width - 1, j);
                this.tileMap[this.width - 1, j] = obstacle;
            }

            //This fills up the bottom side of the boarder only.
            for (int i = 0; i < this.width; i++)
            {
                Obstacle obstacle = new Obstacle(i, 0);
                this.tileMap[i, 0] = obstacle;
            }

            //This fills up the top side of the boarder only.

            for (int i = 0; i < this.width; i++)
            {
                Obstacle obstacle = new Obstacle(i, this.height - 1);
                this.tileMap[i, this.height -1] = obstacle;
            }

            //This fills up the rest of the map with empty tiles
            for (int i = 1; i < this.width - 1; i++)
            {
                for (int j = 1; j < this.height - 1; j++)
                {
                    EmptyTile emptyTile = new EmptyTile(i, j);
                    this.tileMap[i, j] = emptyTile;              
                }
            }

            // Creates the hero in the tie class.
            this.hero = (Hero)this.Create(TileType.Hero);

            //Creates enemies in the class.
            
            this.enemyArray = new Enemy[numOfEnemies];
            
            for (int i = 0; i < numOfEnemies; i++)
            {
                int choice = this.random.Next(0, 3);// 0 = Goblin , 1 = Mage , 2 = Leader. 
                    //These represent the enemy types called at random
                if (choice == 0)
                {
                    this.enemyArray[i] = (Enemy)this.Create(TileType.Goblin);
                }
                else if(choice == 1) 
                {
                    this.enemyArray[i] = (Enemy)this.Create(TileType.Mage);
                }
                else
                {
                    this.enemyArray[i] = (Enemy)this.Create(TileType.Leader);
                }
                
            }
            //populets the Item array with the parameter
            this.items = new Item[goldDrops + weaponDrops];

            for (int i = 0; i < goldDrops; i++)
            {
                this.items[i] = (Gold)this.Create(TileType.Gold);
            }
            for (int i = goldDrops; i < this.items.Length; i++)
            {
                this.items[i] = (Weapon)this.Create(TileType.Weapon);
            }
            this.UpdateVision();
        }
        
        public void UpdateVision()
        {
            int xPos = this.hero.getX();
            int yPos = this.hero.getY();

            //update vision of hero
            //Up
            this.hero.SetCharacterVision(this.tileMap[xPos, yPos + 1], 0);
            //Down
            this.hero.SetCharacterVision(this.tileMap[xPos, yPos - 1], 1);
            //Left
            this.hero.SetCharacterVision(this.tileMap[xPos - 1, yPos], 2);
            //Right
            this.hero.SetCharacterVision(this.tileMap[xPos + 1, yPos], 3);

            //update enemy vision
            for (int i = 0; i < this.enemyArray.Length; i++)
            {
                 int enemyXPos = this.enemyArray[i].getX();
                 int enemyYPos = this.enemyArray[i].getY();

                //Up
                this.enemyArray[i].SetCharacterVision(this.tileMap[enemyXPos, enemyYPos + 1], 0);
                //Down
                this.enemyArray[i].SetCharacterVision(this.tileMap[enemyXPos, enemyYPos - 1], 1);
                //Left
                this.enemyArray[i].SetCharacterVision(this.tileMap[enemyXPos - 1, enemyYPos], 2);
                //Right
                this.enemyArray[i].SetCharacterVision(this.tileMap[enemyXPos + 1, enemyYPos], 3);
            }
            
        }

        private Tile Create(TileType tileType)// 
        {
            if (tileType == TileType.Hero)
            {
                bool isHeroAssigned = false;
                Hero tempHero = null;
                
                while (!isHeroAssigned )
                {
                    
                    int x = this.random.Next(1, this.width - 2);
                    int y = this.random.Next(1, this.height - 2);
                    if (this.tileMap[x, y].Equals (new EmptyTile(x, y)))
                    {
                        tempHero = new Hero(x, y, 10, "H");
                        this.tileMap[x, y] = tempHero;
                        isHeroAssigned = true;
                    }
                    
                    
                }
                
                return tempHero;
            }
            else if (tileType == TileType.Goblin)
            {
                bool isGoblinAssigned = false;
                Goblin tempGoblin = null;

                while (!isGoblinAssigned)
                {

                    int x = this.random.Next(1, this.width - 2);
                    int y = this.random.Next(1, this.height - 2);
                    if (this.tileMap[x, y].Equals(new EmptyTile(x, y)))
                    {
                        tempGoblin = new Goblin(x, y);
                        this.tileMap[x, y] = tempGoblin;
                        isGoblinAssigned = true;
                    }


                }

                return tempGoblin;

            }
            else if (tileType == TileType.Mage)
            {
                bool isMageAssigned = false;
                Mage tempMage = null;

                while (!isMageAssigned)
                {

                    int x = this.random.Next(1, this.width - 2);
                    int y = this.random.Next(1, this.height - 2);
                    if (this.tileMap[x, y].Equals(new EmptyTile(x, y)))
                    {
                        tempMage = new Mage(x, y);
                        this.tileMap[x, y] = tempMage;
                        isMageAssigned = true;
                    }


                }

                return tempMage;

            }
            else if (tileType == TileType.Leader)
            {
                bool isLeaderAssigned = false;
                Mage tempLeader = null;

                while (!isLeaderAssigned)
                {

                    int x = this.random.Next(1, this.width - 2);
                    int y = this.random.Next(1, this.height - 2);
                    if (this.tileMap[x, y].Equals(new EmptyTile(x, y)))
                    {
                        tempLeader = new Mage(x, y);
                        this.tileMap[x, y] = tempLeader;
                        isLeaderAssigned = true;
                    }


                }

                return tempLeader;
            }

            if (tileType == TileType.Gold)
            {

                bool isGoldAssigned = false;
                Gold tempGold = null;

                while (!isGoldAssigned)
                {

                    int x = this.random.Next(1, this.width - 2);
                    int y = this.random.Next(1, this.height - 2);
                    if (this.tileMap[x, y].Equals(new EmptyTile(x, y)))
                    {
                        tempGold = new Gold(x, y);
                        this.tileMap[x, y] = tempGold;
                        isGoldAssigned = true;
                    }


                }

                return tempGold;
                
            }
            else if(tileType == TileType.Weapon)
            {
                bool isWeaponAssigned = false;
                Weapon tempWeapon = null;

                while (!isWeaponAssigned)
                {

                    int x = this.random.Next(1, this.width - 2);
                    int y = this.random.Next(1, this.height - 2);
                    if (this.tileMap[x, y].Equals(new EmptyTile(x, y)))
                    {
                        tempWeapon = RandomWeapon();
                        tempWeapon.setX(x);
                        tempWeapon.setY(y);
                        this.tileMap[x, y] = tempWeapon;
                        isWeaponAssigned = true;
                    }


                }

                return tempWeapon;
            }
            return new EmptyTile(0,0);

            
        }
        private Weapon RandomWeapon()
        {
            int random = this.random.Next(1, 5);
            Weapon weapon = null;
            if (random == 1) // Creates a Dagger
            {
                weapon = new MeleeWeapon(Type.Dagger, "D");
            }
            else if (random == 2) // Creates a Longsword
            {
                weapon = new MeleeWeapon(Type.Longsword, "L");
            }
            else if (random == 3)  //Creates a Longbow
            {
                weapon = new RangedWeapon(Types.Longbow, "B");
            }
            else if (random == 4) // Creates a Rifle
            {
                weapon = new RangedWeapon(Types.Rifle, "R");
            }

            return weapon;

        }
        public override string ToString()
        {
            string mapView = "";

            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.height; j++)
                {                
                    mapView +=  " " +  this.tileMap[i, j].GetSymbol();

                }
                
                mapView += System.Environment.NewLine;

            }

            return mapView;


        }
        public Item GetItemAtPosition(int x, int y)
        {
            if (x < 0 || x >= this.width || y < 0 || y >= this.height)
            {
                throw new IndexOutOfRangeException("Trying to acess Tilemap out of range. Not accepted.");
            }
            Tile tile = this.tileMap[x, y];
            
            for (int i = 0; i < this.items.Length; i++)
            {
                if (tile.Equals(this.items[i]))
                {
                    return this.items[i];
                }
            }

            return null;
    }
    }
    
}
