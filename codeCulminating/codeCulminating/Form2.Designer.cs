﻿namespace codeCulminating
{
    partial class frmGraphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraphics));
            this.picWood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWood)).BeginInit();
            this.SuspendLayout();
            // 
            // picWood
            // 
            this.picWood.Image = ((System.Drawing.Image)(resources.GetObject("picWood.Image")));
            this.picWood.Location = new System.Drawing.Point(82, 125);
            this.picWood.Name = "picWood";
            this.picWood.Size = new System.Drawing.Size(57, 58);
            this.picWood.TabIndex = 0;
            this.picWood.TabStop = false;
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picWood);
            this.Name = "frmGraphics";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.picWood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picWood;
    }
}