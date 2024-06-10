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
            this.audPlayerLvl1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.picText1 = new System.Windows.Forms.PictureBox();
            this.picPhoneBuzz = new System.Windows.Forms.PictureBox();
            this.picPhone = new System.Windows.Forms.PictureBox();
            this.lblTextBox = new System.Windows.Forms.Label();
            this.picGirlInteract = new System.Windows.Forms.PictureBox();
            this.lblTransparent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.audPlayerLvl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoneBuzz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // audPlayerLvl1
            // 
            this.audPlayerLvl1.Enabled = true;
            this.audPlayerLvl1.Location = new System.Drawing.Point(646, 84);
            this.audPlayerLvl1.Name = "audPlayerLvl1";
            this.audPlayerLvl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("audPlayerLvl1.OcxState")));
            this.audPlayerLvl1.Size = new System.Drawing.Size(160, 84);
            this.audPlayerLvl1.TabIndex = 6;
            // 
            // picText1
            // 
            this.picText1.BackColor = System.Drawing.Color.Transparent;
            this.picText1.Image = global::codeCulminating.Properties.Resources.Phone_1;
            this.picText1.Location = new System.Drawing.Point(373, 12);
            this.picText1.Name = "picText1";
            this.picText1.Size = new System.Drawing.Size(676, 644);
            this.picText1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picText1.TabIndex = 9;
            this.picText1.TabStop = false;
            this.picText1.Visible = false;
            // 
            // picPhoneBuzz
            // 
            this.picPhoneBuzz.BackColor = System.Drawing.Color.Transparent;
            this.picPhoneBuzz.Image = global::codeCulminating.Properties.Resources.phone_1__1_;
            this.picPhoneBuzz.Location = new System.Drawing.Point(863, 282);
            this.picPhoneBuzz.Name = "picPhoneBuzz";
            this.picPhoneBuzz.Size = new System.Drawing.Size(51, 48);
            this.picPhoneBuzz.TabIndex = 8;
            this.picPhoneBuzz.TabStop = false;
            this.picPhoneBuzz.Visible = false;
            // 
            // picPhone
            // 
            this.picPhone.BackColor = System.Drawing.Color.Transparent;
            this.picPhone.Image = global::codeCulminating.Properties.Resources.phone;
            this.picPhone.Location = new System.Drawing.Point(863, 282);
            this.picPhone.Name = "picPhone";
            this.picPhone.Size = new System.Drawing.Size(51, 48);
            this.picPhone.TabIndex = 7;
            this.picPhone.TabStop = false;
            // 
            // lblTextBox
            // 
            this.lblTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lblTextBox.Image = ((System.Drawing.Image)(resources.GetObject("lblTextBox.Image")));
            this.lblTextBox.Location = new System.Drawing.Point(223, 454);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(975, 298);
            this.lblTextBox.TabIndex = 5;
            this.lblTextBox.Click += new System.EventHandler(this.lblTextBox_Click);
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
            // frmLevelOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.picText1);
            this.Controls.Add(this.picPhoneBuzz);
            this.Controls.Add(this.picPhone);
            this.Controls.Add(this.audPlayerLvl1);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.picGirlInteract);
            this.Controls.Add(this.lblTransparent);
            this.DoubleBuffered = true;
            this.Name = "frmLevelOne";
            this.Text = "Level_1";
            this.Load += new System.EventHandler(this.Level_1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level_1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level_1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.audPlayerLvl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoneBuzz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label lblTransparent;
        private System.Windows.Forms.PictureBox picGirlInteract;
        private System.Windows.Forms.Label lblTextBox;
        private AxWMPLib.AxWindowsMediaPlayer audPlayerLvl1;
        private System.Windows.Forms.PictureBox picPhone;
        private System.Windows.Forms.PictureBox picPhoneBuzz;
        private System.Windows.Forms.PictureBox picText1;
    }
}