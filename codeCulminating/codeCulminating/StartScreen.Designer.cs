namespace codeCulminating
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.btnMazeGame = new System.Windows.Forms.Button();
            this.btnMemoryGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Location = new System.Drawing.Point(190, 113);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(363, 139);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHelp.Location = new System.Drawing.Point(190, 281);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(363, 139);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTitle.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGameTitle.Location = new System.Drawing.Point(283, 40);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(184, 45);
            this.lblGameTitle.TabIndex = 2;
            this.lblGameTitle.Text = "Game Title ";
            // 
            // btnMazeGame
            // 
            this.btnMazeGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMazeGame.Location = new System.Drawing.Point(51, 316);
            this.btnMazeGame.Name = "btnMazeGame";
            this.btnMazeGame.Size = new System.Drawing.Size(114, 38);
            this.btnMazeGame.TabIndex = 3;
            this.btnMazeGame.Text = "Maze";
            this.btnMazeGame.UseVisualStyleBackColor = false;
            this.btnMazeGame.Click += new System.EventHandler(this.btnMazeGame_Click);
            // 
            // btnMemoryGame
            // 
            this.btnMemoryGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMemoryGame.Location = new System.Drawing.Point(51, 272);
            this.btnMemoryGame.Name = "btnMemoryGame";
            this.btnMemoryGame.Size = new System.Drawing.Size(114, 38);
            this.btnMemoryGame.TabIndex = 4;
            this.btnMemoryGame.Text = "Memory Game";
            this.btnMemoryGame.UseVisualStyleBackColor = false;
            this.btnMemoryGame.Click += new System.EventHandler(this.btnMemoryGame_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.btnMemoryGame);
            this.Controls.Add(this.btnMazeGame);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnMazeGame;
        private System.Windows.Forms.Button btnMemoryGame;
    }
}