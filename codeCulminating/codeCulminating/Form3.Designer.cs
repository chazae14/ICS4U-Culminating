namespace codeCulminating
{
    partial class frmPause
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
            this.btnResume = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMusicCont = new System.Windows.Forms.Button();
            this.timerPause = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Transparent;
            this.btnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResume.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Location = new System.Drawing.Point(523, 319);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(375, 99);
            this.btnResume.TabIndex = 0;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(523, 606);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(375, 103);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMusicCont
            // 
            this.btnMusicCont.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusicCont.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMusicCont.FlatAppearance.BorderSize = 0;
            this.btnMusicCont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMusicCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCont.Location = new System.Drawing.Point(523, 468);
            this.btnMusicCont.Name = "btnMusicCont";
            this.btnMusicCont.Size = new System.Drawing.Size(375, 99);
            this.btnMusicCont.TabIndex = 2;
            this.btnMusicCont.UseVisualStyleBackColor = false;
            this.btnMusicCont.Click += new System.EventHandler(this.btnMusicCont_Click);
            // 
            // timerPause
            // 
            this.timerPause.Interval = 10;
            this.timerPause.Tick += new System.EventHandler(this.timerPause_Tick);
            // 
            // frmPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::codeCulminating.Properties.Resources.pausemenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnResume;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.btnMusicCont);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnResume);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPause";
            this.Opacity = 0D;
            this.Text = "PauseMenu";
            this.Load += new System.EventHandler(this.frmPause_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMusicCont;
        private System.Windows.Forms.Timer timerPause;
    }
}