﻿namespace codeCulminating
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
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // frmLevelOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.DoubleBuffered = true;
            this.Name = "frmLevelOne";
            this.Text = "Level_1";
            this.Load += new System.EventHandler(this.Level_1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level_1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level_1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
    }
}