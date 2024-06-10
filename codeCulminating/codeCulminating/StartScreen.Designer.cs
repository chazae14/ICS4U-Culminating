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
            this.btnMazeGame = new System.Windows.Forms.Button();
            this.btnMemoryGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCombinationLock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(88, 437);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(409, 108);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(89, 565);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(409, 108);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // btnMazeGame
            // 
            this.btnMazeGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMazeGame.Location = new System.Drawing.Point(698, 123);
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
            this.btnMemoryGame.Location = new System.Drawing.Point(698, 79);
            this.btnMemoryGame.Name = "btnMemoryGame";
            this.btnMemoryGame.Size = new System.Drawing.Size(114, 38);
            this.btnMemoryGame.TabIndex = 4;
            this.btnMemoryGame.Text = "Memory Game";
            this.btnMemoryGame.UseVisualStyleBackColor = false;
            this.btnMemoryGame.Click += new System.EventHandler(this.btnMemoryGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(88, 695);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(409, 108);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCombinationLock
            // 
            this.btnCombinationLock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCombinationLock.Location = new System.Drawing.Point(698, 167);
            this.btnCombinationLock.Name = "btnCombinationLock";
            this.btnCombinationLock.Size = new System.Drawing.Size(114, 38);
            this.btnCombinationLock.TabIndex = 6;
            this.btnCombinationLock.Text = "Combination Lock";
            this.btnCombinationLock.UseVisualStyleBackColor = false;
            this.btnCombinationLock.Click += new System.EventHandler(this.btnCombinationLock_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.BackgroundImage = global::codeCulminating.Properties.Resources.StartMenuSketch_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btnCombinationLock);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMemoryGame);
            this.Controls.Add(this.btnMazeGame);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMazeGame;
        private System.Windows.Forms.Button btnMemoryGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCombinationLock;
    }
}