namespace codeCulminating
{
    partial class frmLevelOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelOne));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.lblTransparent = new System.Windows.Forms.Label();
            this.picGirlInteract = new System.Windows.Forms.PictureBox();
            this.lblTextBox = new System.Windows.Forms.Label();
            this.picObjectives = new System.Windows.Forms.PictureBox();
            this.lblObjectives = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectives)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // lblTransparent
            // 
            this.lblTransparent.BackColor = System.Drawing.Color.Transparent;
            this.lblTransparent.Image = ((System.Drawing.Image)(resources.GetObject("lblTransparent.Image")));
            this.lblTransparent.Location = new System.Drawing.Point(-4, -10);
            this.lblTransparent.Name = "lblTransparent";
            this.lblTransparent.Size = new System.Drawing.Size(1407, 781);
            this.lblTransparent.TabIndex = 3;
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
            this.picGirlInteract.TabIndex = 4;
            this.picGirlInteract.TabStop = false;
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
            this.lblTextBox.TabIndex = 5;
            this.lblTextBox.Click += new System.EventHandler(this.lblTextBox_Click);
            // 
            // picObjectives
            // 
            this.picObjectives.Image = ((System.Drawing.Image)(resources.GetObject("picObjectives.Image")));
            this.picObjectives.Location = new System.Drawing.Point(1069, 122);
            this.picObjectives.Name = "picObjectives";
            this.picObjectives.Size = new System.Drawing.Size(300, 300);
            this.picObjectives.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObjectives.TabIndex = 6;
            this.picObjectives.TabStop = false;
            // 
            // lblObjectives
            // 
            this.lblObjectives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(124)))));
            this.lblObjectives.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectives.Location = new System.Drawing.Point(1100, 201);
            this.lblObjectives.Name = "lblObjectives";
            this.lblObjectives.Size = new System.Drawing.Size(238, 154);
            this.lblObjectives.TabIndex = 7;
            this.lblObjectives.Text = "- Get clothing from dresser\r\n- Get money for the cafe ";
            // 
            // frmLevelOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.lblObjectives);
            this.Controls.Add(this.picObjectives);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.picGirlInteract);
            this.Controls.Add(this.lblTransparent);
            this.DoubleBuffered = true;
            this.Name = "frmLevelOne";
            this.Text = "Level_1";
            this.Load += new System.EventHandler(this.Level_1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level_1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level_1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label lblTransparent;
        private System.Windows.Forms.PictureBox picGirlInteract;
        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.PictureBox picObjectives;
        private System.Windows.Forms.Label lblObjectives;
    }
}