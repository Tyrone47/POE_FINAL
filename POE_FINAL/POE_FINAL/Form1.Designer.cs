
namespace POE_FINAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.txtDisplayGame = new System.Windows.Forms.TextBox();
            this.txtPlayerStats = new System.Windows.Forms.TextBox();
            this.txtEnemyStats = new System.Windows.Forms.TextBox();
            this.btnPlayerAttack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.grpShop = new System.Windows.Forms.GroupBox();
            this.btnWeapon3 = new System.Windows.Forms.Button();
            this.btnWeapon4 = new System.Windows.Forms.Button();
            this.btnWeapon1 = new System.Windows.Forms.Button();
            this.btnWeapon2 = new System.Windows.Forms.Button();
            this.grpShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(894, 544);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(65, 45);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = ">";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(702, 544);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(57, 45);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "<";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(798, 476);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(65, 45);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "^";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(798, 612);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(65, 45);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "v";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // txtDisplayGame
            // 
            this.txtDisplayGame.Location = new System.Drawing.Point(12, 12);
            this.txtDisplayGame.Multiline = true;
            this.txtDisplayGame.Name = "txtDisplayGame";
            this.txtDisplayGame.Size = new System.Drawing.Size(329, 446);
            this.txtDisplayGame.TabIndex = 7;
            // 
            // txtPlayerStats
            // 
            this.txtPlayerStats.Location = new System.Drawing.Point(566, 12);
            this.txtPlayerStats.Multiline = true;
            this.txtPlayerStats.Name = "txtPlayerStats";
            this.txtPlayerStats.Size = new System.Drawing.Size(194, 163);
            this.txtPlayerStats.TabIndex = 8;
            // 
            // txtEnemyStats
            // 
            this.txtEnemyStats.Location = new System.Drawing.Point(785, 12);
            this.txtEnemyStats.Multiline = true;
            this.txtEnemyStats.Name = "txtEnemyStats";
            this.txtEnemyStats.Size = new System.Drawing.Size(416, 213);
            this.txtEnemyStats.TabIndex = 9;
            // 
            // btnPlayerAttack
            // 
            this.btnPlayerAttack.BackColor = System.Drawing.Color.Red;
            this.btnPlayerAttack.Location = new System.Drawing.Point(765, 527);
            this.btnPlayerAttack.Name = "btnPlayerAttack";
            this.btnPlayerAttack.Size = new System.Drawing.Size(123, 79);
            this.btnPlayerAttack.TabIndex = 10;
            this.btnPlayerAttack.Text = "Attack";
            this.btnPlayerAttack.UseVisualStyleBackColor = false;
            this.btnPlayerAttack.Click += new System.EventHandler(this.btnPlayerAttack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1107, 545);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 41);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(1107, 604);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(94, 41);
            this.btnLoadGame.TabIndex = 12;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // grpShop
            // 
            this.grpShop.Controls.Add(this.btnWeapon3);
            this.grpShop.Controls.Add(this.btnWeapon4);
            this.grpShop.Controls.Add(this.btnWeapon1);
            this.grpShop.Controls.Add(this.btnWeapon2);
            this.grpShop.Location = new System.Drawing.Point(566, 231);
            this.grpShop.Name = "grpShop";
            this.grpShop.Size = new System.Drawing.Size(581, 208);
            this.grpShop.TabIndex = 14;
            this.grpShop.TabStop = false;
            this.grpShop.Text = "Shop";
            this.grpShop.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnWeapon3
            // 
            this.btnWeapon3.BackColor = System.Drawing.Color.YellowGreen;
            this.btnWeapon3.Enabled = false;
            this.btnWeapon3.Location = new System.Drawing.Point(6, 127);
            this.btnWeapon3.Name = "btnWeapon3";
            this.btnWeapon3.Size = new System.Drawing.Size(276, 72);
            this.btnWeapon3.TabIndex = 17;
            this.btnWeapon3.Text = "Weapon Not Available";
            this.btnWeapon3.UseVisualStyleBackColor = false;
            this.btnWeapon3.Click += new System.EventHandler(this.btnWeapon3_Click);
            // 
            // btnWeapon4
            // 
            this.btnWeapon4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnWeapon4.Enabled = false;
            this.btnWeapon4.Location = new System.Drawing.Point(299, 127);
            this.btnWeapon4.Name = "btnWeapon4";
            this.btnWeapon4.Size = new System.Drawing.Size(276, 72);
            this.btnWeapon4.TabIndex = 16;
            this.btnWeapon4.Text = "Weapon Not Available";
            this.btnWeapon4.UseVisualStyleBackColor = false;
            this.btnWeapon4.Click += new System.EventHandler(this.btnWeapon4_Click);
            // 
            // btnWeapon1
            // 
            this.btnWeapon1.BackColor = System.Drawing.Color.Pink;
            this.btnWeapon1.Enabled = false;
            this.btnWeapon1.Location = new System.Drawing.Point(6, 44);
            this.btnWeapon1.Name = "btnWeapon1";
            this.btnWeapon1.Size = new System.Drawing.Size(276, 77);
            this.btnWeapon1.TabIndex = 15;
            this.btnWeapon1.Text = "Weapon Not Available";
            this.btnWeapon1.UseVisualStyleBackColor = false;
            this.btnWeapon1.Click += new System.EventHandler(this.btnWeapon1_Click);
            // 
            // btnWeapon2
            // 
            this.btnWeapon2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnWeapon2.Enabled = false;
            this.btnWeapon2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnWeapon2.Location = new System.Drawing.Point(299, 44);
            this.btnWeapon2.Name = "btnWeapon2";
            this.btnWeapon2.Size = new System.Drawing.Size(276, 77);
            this.btnWeapon2.TabIndex = 14;
            this.btnWeapon2.Text = "Weapon Not Available";
            this.btnWeapon2.UseVisualStyleBackColor = false;
            this.btnWeapon2.Click += new System.EventHandler(this.btnWeapon2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 662);
            this.Controls.Add(this.grpShop);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPlayerAttack);
            this.Controls.Add(this.txtEnemyStats);
            this.Controls.Add(this.txtPlayerStats);
            this.Controls.Add(this.txtDisplayGame);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Name = "Form1";
            this.Text = "Treasure Hunt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpShop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox txtDisplayGame;
        private System.Windows.Forms.TextBox txtPlayerStats;
        private System.Windows.Forms.TextBox txtEnemyStats;
        private System.Windows.Forms.Button btnPlayerAttack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.GroupBox grpShop;
        private System.Windows.Forms.Button btnWeapon2;
        private System.Windows.Forms.Button btnWeapon3;
        private System.Windows.Forms.Button btnWeapon4;
        private System.Windows.Forms.Button btnWeapon1;
    }
}

