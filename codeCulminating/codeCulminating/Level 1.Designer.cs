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
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.picDresserCheck = new System.Windows.Forms.PictureBox();
            this.picMoneyCheck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGirlInteract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDresserCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoneyCheck)).BeginInit();
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
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblYes.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.Location = new System.Drawing.Point(754, 688);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(58, 24);
            this.lblYes.TabIndex = 8;
            this.lblYes.Text = "Yes.";
            this.lblYes.Click += new System.EventHandler(this.lblYes_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNo.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(875, 688);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(46, 24);
            this.lblNo.TabIndex = 9;
            this.lblNo.Text = "No.";
            this.lblNo.Click += new System.EventHandler(this.lblNo_Click);
            // 
            // picDresserCheck
            // 
            this.picDresserCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.picDresserCheck.Image = ((System.Drawing.Image)(resources.GetObject("picDresserCheck.Image")));
            this.picDresserCheck.Location = new System.Drawing.Point(1104, 200);
            this.picDresserCheck.Name = "picDresserCheck";
            this.picDresserCheck.Size = new System.Drawing.Size(21, 22);
            this.picDresserCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDresserCheck.TabIndex = 10;
            this.picDresserCheck.TabStop = false;
            // 
            // picMoneyCheck
            // 
            this.picMoneyCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.picMoneyCheck.Image = ((System.Drawing.Image)(resources.GetObject("picMoneyCheck.Image")));
            this.picMoneyCheck.Location = new System.Drawing.Point(1104, 237);
            this.picMoneyCheck.Name = "picMoneyCheck";
            this.picMoneyCheck.Size = new System.Drawing.Size(21, 23);
            this.picMoneyCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMoneyCheck.TabIndex = 11;
            this.picMoneyCheck.TabStop = false;
            // 
            // frmLevelOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.picMoneyCheck);
            this.Controls.Add(this.picDresserCheck);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblYes);
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
            ((System.ComponentModel.ISupportInitialize)(this.picDresserCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoneyCheck)).EndInit();
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
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.PictureBox picDresserCheck;
        private System.Windows.Forms.PictureBox picMoneyCheck;
    }
}