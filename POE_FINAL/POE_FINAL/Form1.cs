using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_FINAL
{
    public partial class Form1 : Form
    {
        private GameEngine gameEngine;

        public Form1()
        {
            InitializeComponent();
           /* this.gameEngine = new GameEngine(20, 20, 20, 20, 3, 5);
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();*/
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.gameEngine = new GameEngine(20, 20, 20, 20, 3, 5 , 5);
            txtDisplayGame.Text = gameEngine.ToString();           
            this.DisplayCharacterStats();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
            this.gameEngine.MovePlayer(MovementEnum.UP);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString(); 
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.DOWN);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();

            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.LEFT);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.RIGHT);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        private void btnPlayerAttack_Click(object sender, EventArgs e)
        {
            Tile[] playerCharVision = this.gameEngine.GetMap().GetHero().GetCharacterVision();
            for (int i = 0; i < playerCharVision.Length; i++)
            {

                if (playerCharVision[i].Equals(new EmptyTile (playerCharVision[i].getX(), playerCharVision[i].getY())) ||
                    playerCharVision[i].Equals(new Obstacle(playerCharVision[i].getX(), playerCharVision[i].getY())) )
                {
                    continue;
                }
                this.gameEngine.GetMap().GetHero().Attack((Character)playerCharVision[i]);
                
            }
            this.gameEngine.EnemyAttack();
            this.DisplayCharacterStats();


        }

        private void DisplayCharacterStats()
        {
            txtPlayerStats.Text = "";
            txtPlayerStats.Text = txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
            txtEnemyStats.Text = "";
            for (int i = 0; i < this.gameEngine.GetMap().GetEnemyArray().Length; i++)
            {
                txtEnemyStats.Text += this.gameEngine.GetMap().GetEnemyArray()[i].ToString() + System.Environment.NewLine;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.gameEngine.Save();
            MessageBox.Show("Game sucessfully saved on file");
            txtDisplayGame.Clear();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            
            txtDisplayGame.Text = this.gameEngine.Load();
        }

        private void btnBuyWeapon_Click(object sender, EventArgs e)
        {

        }
    }
}
