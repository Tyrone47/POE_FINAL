
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
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(845, 480);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(101, 41);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Move Right";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(634, 489);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(101, 41);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Move Left";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(738, 442);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(101, 41);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "Move Up";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(738, 533);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(101, 41);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "Move Down";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // txtDisplayGame
            // 
            this.txtDisplayGame.Location = new System.Drawing.Point(12, 12);
            this.txtDisplayGame.Multiline = true;
            this.txtDisplayGame.Name = "txtDisplayGame";
            this.txtDisplayGame.Size = new System.Drawing.Size(548, 574);
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
            this.txtEnemyStats.Size = new System.Drawing.Size(416, 163);
            this.txtEnemyStats.TabIndex = 9;
            // 
            // btnPlayerAttack
            // 
            this.btnPlayerAttack.Location = new System.Drawing.Point(741, 492);
            this.btnPlayerAttack.Name = "btnPlayerAttack";
            this.btnPlayerAttack.Size = new System.Drawing.Size(94, 29);
            this.btnPlayerAttack.TabIndex = 10;
            this.btnPlayerAttack.Text = "Attack";
            this.btnPlayerAttack.UseVisualStyleBackColor = true;
            this.btnPlayerAttack.Click += new System.EventHandler(this.btnPlayerAttack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1094, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 41);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(1094, 533);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(94, 41);
            this.btnLoadGame.TabIndex = 12;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 662);
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
    }
}

