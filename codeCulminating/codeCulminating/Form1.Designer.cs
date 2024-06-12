namespace codeCulminating
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.timerIn = new System.Windows.Forms.Timer(this.components);
            this.lblTextBox = new System.Windows.Forms.Label();
            this.lblTransparent = new System.Windows.Forms.Label();
            this.picGirlInteract = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick_1);
            // 
            // timerIn
            // 
            this.timerIn.Tick += new System.EventHandler(this.timerIn_Tick_1);
            // 
            // lblTextBox
            // 
            this.lblTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lblTextBox.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lblTextBox.Image = ((System.Drawing.Image)(resources.GetObject("lblTextBox.Image")));
            this.lblTextBox.Location = new System.Drawing.Point(223, 454);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(975, 298);
            this.lblTextBox.TabIndex = 0;
            this.lblTextBox.Click += new System.EventHandler(this.lblTextBox_Click);
            // 
            // lblTransparent
            // 
            this.lblTransparent.BackColor = System.Drawing.Color.Transparent;
            this.lblTransparent.Image = ((System.Drawing.Image)(resources.GetObject("lblTransparent.Image")));
            this.lblTransparent.Location = new System.Drawing.Point(-1, -14);
            this.lblTransparent.Name = "lblTransparent";
            this.lblTransparent.Size = new System.Drawing.Size(1407, 781);
            this.lblTransparent.TabIndex = 2;
            this.lblTransparent.Click += new System.EventHandler(this.lblTransparent_Click);
            // 
            // picGirlInteract
            // 
            this.picGirlInteract.BackColor = System.Drawing.Color.Transparent;
            this.picGirlInteract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGirlInteract.BackgroundImage")));
            this.picGirlInteract.Image = ((System.Drawing.Image)(resources.GetObject("picGirlInteract.Image")));
            this.picGirlInteract.Location = new System.Drawing.Point(12, -14);
            this.picGirlInteract.Name = "picGirlInteract";
            this.picGirlInteract.Size = new System.Drawing.Size(495, 800);
            this.picGirlInteract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGirlInteract.TabIndex = 3;
            this.picGirlInteract.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.picGirlInteract);
            this.Controls.Add(this.lblTransparent);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Timer timerIn;
        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.Label lblTransparent;
        private System.Windows.Forms.PictureBox picGirlInteract;
    }
}

