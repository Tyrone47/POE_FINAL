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

            this.gameEngine = new GameEngine(20, 20, 20, 20, 5, 5 , 5);
            txtDisplayGame.Text = gameEngine.ToString();           
            this.DisplayCharacterStats();
            Shop shop = this.gameEngine.GetShop();
            btnWeapon1.Text = shop.DisplayWeapon(0);
            btnWeapon2.Text = shop.DisplayWeapon(1);
            btnWeapon3.Text = shop.DisplayWeapon(2);
            btnWeapon4.Text = shop.DisplayWeapon(3);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
            this.gameEngine.MovePlayer(MovementEnum.UP);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
            this.CanPlayerBuyWeapon();
            if(this.gameEngine.GetMap().GetHero().IsDead())
            {
                MessageBox.Show("Game Over! You Died.");
                Application.Exit();
            }
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.DOWN);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
            this.CanPlayerBuyWeapon();
            if (this.gameEngine.GetMap().GetHero().IsDead())
            {
                MessageBox.Show("Game Over! You Died.");
                Application.Exit();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.LEFT);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
            this.CanPlayerBuyWeapon();
            if (this.gameEngine.GetMap().GetHero().IsDead())
            {
                MessageBox.Show("Game Over! You Died.");
                Application.Exit();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.RIGHT);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
            this.CanPlayerBuyWeapon();
            if (this.gameEngine.GetMap().GetHero().IsDead())
            {
                MessageBox.Show("Game Over! You Died.");
                Application.Exit();
            }
        }

        private void btnPlayerAttack_Click(object sender, EventArgs e)
        {
            Tile[] playerCharVision = this.gameEngine.GetMap().GetHero().GetCharacterVision();
            for (int i = 0; i < playerCharVision.Length; i++)
            {

                if (playerCharVision[i].Equals(new EmptyTile (playerCharVision[i].getX(), playerCharVision[i].getY())) ||
                    playerCharVision[i].Equals(new Obstacle(playerCharVision[i].getX(), playerCharVision[i].getY())))
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
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
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

        private void CanPlayerBuyWeapon()
        {
            Hero hero = this.gameEngine.GetMap().GetHero();
            Weapon[] weapon = this.gameEngine.GetShop().GetWeapon();
            btnWeapon1.Enabled = false;
            btnWeapon2.Enabled = false;
            btnWeapon3.Enabled = false;
            btnWeapon4.Enabled = false;

            if (hero.GetGoldPurse() >= weapon[0].GetCost())
            {
                btnWeapon1.Enabled = true;
            }
            if (hero.GetGoldPurse() >= weapon[1].GetCost())
            {
                btnWeapon2.Enabled = true;
            }
            if(hero.GetGoldPurse() >= weapon[2].GetCost())
            {
                btnWeapon3.Enabled = true;
            }
            if (hero.GetGoldPurse() >= weapon[3].GetCost())
            {
                btnWeapon4.Enabled = true;
            }

        }
 

        private void btnWeapon1_Click(object sender, EventArgs e)
        {
            this.gameEngine.GetShop().Buy(0);
            this.CanPlayerBuyWeapon();
            txtPlayerStats.Text = "";
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();

        }

        private void btnWeapon2_Click(object sender, EventArgs e)
        {
            this.gameEngine.GetShop().Buy(1);
            this.CanPlayerBuyWeapon();
            txtPlayerStats.Text = "";
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        private void btnWeapon3_Click(object sender, EventArgs e)
        {
            this.gameEngine.GetShop().Buy(2);
            this.CanPlayerBuyWeapon();
            txtPlayerStats.Text = "";
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        private void btnWeapon4_Click(object sender, EventArgs e)
        {
            this.gameEngine.GetShop().Buy(3);
            this.CanPlayerBuyWeapon();
            txtPlayerStats.Text = "";
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

    }
}
