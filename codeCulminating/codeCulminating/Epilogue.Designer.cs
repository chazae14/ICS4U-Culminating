namespace codeCulminating
{
    partial class Epilogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Epilogue));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.lblTransparent = new System.Windows.Forms.Label();
            this.picGirlInteract = new System.Windows.Forms.PictureBox();
            this.lblTextBox = new System.Windows.Forms.Label();
            this.picFriend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFriend)).BeginInit();
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
            this.lblTransparent.TabIndex = 4;
            this.lblTransparent.Click += new System.EventHandler(this.lblTransparent_Click);
            // 
            // picGirlInteract
            // 
            this.picGirlInteract.BackColor = System.Drawing.Color.Transparent;
            this.picGirlInteract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGirlInteract.BackgroundImage")));
            this.picGirlInteract.Image = ((System.Drawing.Image)(resources.GetObject("picGirlInteract.Image")));
            this.picGirlInteract.Location = new System.Drawing.Point(12, -29);
            this.picGirlInteract.Name = "picGirlInteract";
            this.picGirlInteract.Size = new System.Drawing.Size(495, 800);
            this.picGirlInteract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGirlInteract.TabIndex = 8;
            this.picGirlInteract.TabStop = false;
            // 
            // lblTextBox
            // 
            this.lblTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lblTextBox.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lblTextBox.Image = ((System.Drawing.Image)(resources.GetObject("lblTextBox.Image")));
            this.lblTextBox.Location = new System.Drawing.Point(214, 434);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(975, 298);
            this.lblTextBox.TabIndex = 9;
            // 
            // picFriend
            // 
            this.picFriend.BackColor = System.Drawing.Color.Transparent;
            this.picFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFriend.BackgroundImage")));
            this.picFriend.Image = ((System.Drawing.Image)(resources.GetObject("picFriend.Image")));
            this.picFriend.Location = new System.Drawing.Point(941, -25);
            this.picFriend.Name = "picFriend";
            this.picFriend.Size = new System.Drawing.Size(392, 800);
            this.picFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFriend.TabIndex = 10;
            this.picFriend.TabStop = false;
            // 
            // Epilogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.picFriend);
            this.Controls.Add(this.picGirlInteract);
            this.Controls.Add(this.lblTransparent);
            this.Name = "Epilogue";
            this.Text = "Epilogue";
            this.Load += new System.EventHandler(this.Epilogue_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Epilogue_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Epilogue_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label lblTransparent;
        private System.Windows.Forms.PictureBox picGirlInteract;
        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.PictureBox picFriend;
    }
}