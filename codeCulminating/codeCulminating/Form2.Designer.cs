namespace codeCulminating
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
            this.bmpWood = new System.Windows.Forms.PictureBox();
            this.picGirl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bmpWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGirl)).BeginInit();
            this.SuspendLayout();
            // 
            // bmpWood
            // 
            this.bmpWood.Image = ((System.Drawing.Image)(resources.GetObject("bmpWood.Image")));
            this.bmpWood.Location = new System.Drawing.Point(98, 128);
            this.bmpWood.Name = "bmpWood";
            this.bmpWood.Size = new System.Drawing.Size(50, 50);
            this.bmpWood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bmpWood.TabIndex = 0;
            this.bmpWood.TabStop = false;
            // 
            // picGirl
            // 
            this.picGirl.Image = ((System.Drawing.Image)(resources.GetObject("picGirl.Image")));
            this.picGirl.Location = new System.Drawing.Point(28, 28);
            this.picGirl.Name = "picGirl";
            this.picGirl.Size = new System.Drawing.Size(300, 50);
            this.picGirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGirl.TabIndex = 1;
            this.picGirl.TabStop = false;
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picGirl);
            this.Controls.Add(this.bmpWood);
            this.Name = "frmGraphics";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.bmpWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGirl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox bmpWood;
        public System.Windows.Forms.PictureBox picGirl;
    }
}