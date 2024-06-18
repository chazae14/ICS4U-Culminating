namespace codeCulminating
{
    partial class GoodEnding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodEnding));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.picRealLetter = new System.Windows.Forms.PictureBox();
            this.lblTransparent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRealLetter)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // picRealLetter
            // 
            this.picRealLetter.BackColor = System.Drawing.Color.Transparent;
            this.picRealLetter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRealLetter.BackgroundImage")));
            this.picRealLetter.Image = ((System.Drawing.Image)(resources.GetObject("picRealLetter.Image")));
            this.picRealLetter.Location = new System.Drawing.Point(243, 94);
            this.picRealLetter.Name = "picRealLetter";
            this.picRealLetter.Size = new System.Drawing.Size(829, 572);
            this.picRealLetter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRealLetter.TabIndex = 0;
            this.picRealLetter.TabStop = false;
            this.picRealLetter.Click += new System.EventHandler(this.picRealLetter_Click);
            // 
            // lblTransparent
            // 
            this.lblTransparent.BackColor = System.Drawing.Color.Transparent;
            this.lblTransparent.Image = ((System.Drawing.Image)(resources.GetObject("lblTransparent.Image")));
            this.lblTransparent.Location = new System.Drawing.Point(-4, -10);
            this.lblTransparent.Name = "lblTransparent";
            this.lblTransparent.Size = new System.Drawing.Size(1407, 781);
            this.lblTransparent.TabIndex = 5;
            // 
            // GoodEnding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.picRealLetter);
            this.Controls.Add(this.lblTransparent);
            this.DoubleBuffered = true;
            this.Name = "GoodEnding";
            this.Text = "GoodEnding";
            this.Load += new System.EventHandler(this.GoodEnding_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GoodEnding_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoodEnding_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picRealLetter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.PictureBox picRealLetter;
        private System.Windows.Forms.Label lblTransparent;
    }
}