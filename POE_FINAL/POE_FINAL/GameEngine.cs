using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace POE_FINAL
{
    [Serializable]
    public class GameEngine 
    {
        private Map map;


        private Shop shop;

        public Map GetMap()
        {
            return this.map;
        }

        public  GameEngine(int minWidth, int maxWidth, int minHeight, int maxHeight, int numOfEnemies, int goldDrops , int weaponDrops)
        {
            this.map = new Map(minWidth, maxWidth, minHeight, maxHeight, numOfEnemies, goldDrops , weaponDrops);
             
        }

        public bool MovePlayer (MovementEnum direction)
        {
            Hero hero = this.map.GetHero();

               
            MovementEnum move = this.map.GetHero().ReturnMove(direction);
            if (move == MovementEnum.UP )
            {
                int currentX = hero.getX();
                int currentY= hero.getY();
                
               
                if (hero.GetCharacterVision()[0].Equals(new Gold(currentX, currentY + 1)))
                {
                    Gold tempGold = (Gold)hero.GetCharacterVision()[0];
                    hero.IncrementGoldAmmount(tempGold.GetGoldAmmount());

                }
                hero.setY(currentY + 1);
                this.map.placeTileOnMap(hero);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
                return true;
            }
            else if(move == MovementEnum.DOWN)
            {
                int currentX = hero.getX();
                int currentY = hero.getY();

                if (hero.GetCharacterVision()[1].Equals(new Gold(currentX,currentY - 1)))
                {
                    Gold tempGold = (Gold)hero.GetCharacterVision()[1];
                    hero.IncrementGoldAmmount(tempGold.GetGoldAmmount());
                }
                hero.setY(currentY - 1);
                this.map.placeTileOnMap(hero);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
                return true;
            }
            else if (move == MovementEnum.LEFT)
            {
                int currentX = hero.getX();
                int currentY = hero.getY();

                if (hero.GetCharacterVision()[2].Equals(new Gold(currentX - 1, currentY)))
                {
                    Gold tempGold = (Gold)hero.GetCharacterVision()[2];
                    hero.IncrementGoldAmmount(tempGold.GetGoldAmmount());
                }
                hero.setX(currentX - 1);
                this.map.placeTileOnMap(hero);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
                return true;
            }
            else if (move == MovementEnum.RIGHT)
            {
                int currentX = hero.getX();
                int currentY = hero.getY();

                if(hero.GetCharacterVision()[3].Equals(new Gold(currentX + 1, currentY )))
                {
                    Gold tempGold = (Gold)hero.GetCharacterVision()[3];
                    hero.IncrementGoldAmmount(tempGold.GetGoldAmmount());
                }
                hero.setX(currentX + 1);
                this.map.placeTileOnMap(hero);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            
            return this.map.ToString(); 
        }
        private void MoveEnemy(Enemy enemy , MovementEnum move)
        {
            
            if (move == MovementEnum.UP)
            {
                int currentX = enemy.getX();
                int currentY = enemy.getY();
                enemy.setY(currentY + 1);
                this.map.placeTileOnMap(enemy);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
            }
            else if (move == MovementEnum.DOWN)
            {
                int currentX = enemy.getX();
                int currentY = enemy.getY();
                enemy.setY(currentY - 1);
                this.map.placeTileOnMap(enemy);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();
            }
            else if (move == MovementEnum.LEFT)
            {
                int currentX = enemy.getX();
                int currentY = enemy.getY();           
                enemy.setX(currentX - 1);
                this.map.placeTileOnMap(enemy);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();   
            }
            else if (move == MovementEnum.RIGHT)
            {
                int currentX = enemy.getX();
                int currentY = enemy.getY();
                enemy.setX(currentX + 1);
                this.map.placeTileOnMap(enemy);
                EmptyTile emptyTile = new EmptyTile(currentX, currentY);
                this.map.placeTileOnMap(emptyTile);
                this.map.UpdateVision();      
            }    
        }

        public void MoveEnemies()
        {
            
            for (int i = 0; i < this.map.GetEnemyArray().Length; i++)
            {
                if (this.map.GetEnemyArray()[i].GetType() == typeof(Goblin))
                {
                    Random randomMove = new Random();
                    MovementEnum  direction = (MovementEnum)randomMove.Next(0, 5);
                    MovementEnum move = this.map.GetEnemyArray()[i].ReturnMove(direction);
                    this.MoveEnemy((Goblin)this.map.GetEnemyArray()[i], move);
                }
                else if (this.map.GetEnemyArray()[i].GetType() == typeof(Leader))
                {
                    
                    Leader leader = (Leader)this.map.GetEnemyArray()[i];
                    leader.SetleadTarget(this.map.GetHero());
                    MovementEnum move = this.map.GetEnemyArray()[i].ReturnMove();
                    this.MoveEnemy((Leader)this.map.GetEnemyArray()[i], move);

                }
            }
            this.EnemyAttack();
        }
        public void EnemyAttack()
        {

         
            for (int i = 0; i < this.map.GetEnemyArray().Length; i++)
            {
                Tile[] characterVision = this.map.GetEnemyArray()[i].GetCharacterVision();

                for (int j = 0; j < characterVision.Length; j++)
                {
                    if (characterVision[j].GetType() == typeof(EmptyTile) ||
                        characterVision[j].GetType() == typeof(Obstacle)  ||
                        characterVision[j].GetType() == typeof(Gold)      ||
                        characterVision[j].GetType() == typeof(MeleeWeapon)   ||
                        characterVision[j].GetType() == typeof(RangedWeapon))

                    {
                        continue;
                    }
                    Character target = (Character)characterVision[j];
                    this.map.GetEnemyArray()[i].Attack(target);
                }   
            }
        }

        public void Save()
        {
            string fileName = @"c:\users\tyrone the 4th\source\repos\poe_task2\poe_task_2\POE_Task_2\SaveGame.bin";
            using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(fileName, FileMode.OpenOrCreate)))
            {
                binaryWriter.Write(this.ToString());
            }      

        }

        public string Load()
        {
            string loadGame = "";
            string fileName = @"c:\users\tyrone the 4th\source\repos\poe_task2\poe_task_2\POE_Task_2\SaveGame.bin";
            if (File.Exists(fileName))
            {
                using (BinaryReader binaryReader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    loadGame = binaryReader.ReadString();
                }
            }
            return loadGame;
        }      
    }
}
