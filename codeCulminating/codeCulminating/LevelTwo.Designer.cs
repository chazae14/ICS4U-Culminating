﻿namespace codeCulminating
{
    partial class LevelTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelTwo));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.lblTextBox = new System.Windows.Forms.Label();
            this.picGirlInteract = new System.Windows.Forms.PictureBox();
            this.lblTransparent = new System.Windows.Forms.Label();
            this.picBarista = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarista)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // lblTextBox
            // 
            this.lblTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lblTextBox.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lblTextBox.Image = ((System.Drawing.Image)(resources.GetObject("lblTextBox.Image")));
            this.lblTextBox.Location = new System.Drawing.Point(238, 430);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(975, 298);
            this.lblTextBox.TabIndex = 6;
            // 
            // picGirlInteract
            // 
            this.picGirlInteract.BackColor = System.Drawing.Color.Transparent;
            this.picGirlInteract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGirlInteract.BackgroundImage")));
            this.picGirlInteract.Image = ((System.Drawing.Image)(resources.GetObject("picGirlInteract.Image")));
            this.picGirlInteract.Location = new System.Drawing.Point(12, -35);
            this.picGirlInteract.Name = "picGirlInteract";
            this.picGirlInteract.Size = new System.Drawing.Size(495, 800);
            this.picGirlInteract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGirlInteract.TabIndex = 7;
            this.picGirlInteract.TabStop = false;
            // 
            // lblTransparent
            // 
            this.lblTransparent.BackColor = System.Drawing.Color.Transparent;
            this.lblTransparent.Image = ((System.Drawing.Image)(resources.GetObject("lblTransparent.Image")));
            this.lblTransparent.Location = new System.Drawing.Point(-4, -10);
            this.lblTransparent.Name = "lblTransparent";
            this.lblTransparent.Size = new System.Drawing.Size(1414, 800);
            this.lblTransparent.TabIndex = 8;
            this.lblTransparent.Click += new System.EventHandler(this.lblTransparent_Click);
            // 
            // picBarista
            // 
            this.picBarista.BackColor = System.Drawing.Color.Transparent;
            this.picBarista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBarista.BackgroundImage")));
            this.picBarista.Image = ((System.Drawing.Image)(resources.GetObject("picBarista.Image")));
            this.picBarista.Location = new System.Drawing.Point(939, -35);
            this.picBarista.Name = "picBarista";
            this.picBarista.Size = new System.Drawing.Size(495, 800);
            this.picBarista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBarista.TabIndex = 9;
            this.picBarista.TabStop = false;
            this.picBarista.Visible = false;
            // 
            // LevelTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.picBarista);
            this.Controls.Add(this.picGirlInteract);
            this.Controls.Add(this.lblTransparent);
            this.DoubleBuffered = true;
            this.Name = "LevelTwo";
            this.Text = "LevelTwo";
            this.Load += new System.EventHandler(this.LevelTwo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LevelTwo_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LevelTwo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.PictureBox picGirlInteract;
        private System.Windows.Forms.Label lblTransparent;
        private System.Windows.Forms.PictureBox picBarista;
    }
}