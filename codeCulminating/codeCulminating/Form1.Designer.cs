namespace codeCulminating
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTextBox = new System.Windows.Forms.Label();
            this.btnLevelSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick_1);
            // 
            // lblTextBox
            // 
            this.lblTextBox.Image = ((System.Drawing.Image)(resources.GetObject("lblTextBox.Image")));
            this.lblTextBox.Location = new System.Drawing.Point(770, 542);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(150, 50);
            this.lblTextBox.TabIndex = 0;
            // 
            // btnLevelSelect
            // 
            this.btnLevelSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnLevelSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLevelSelect.FlatAppearance.BorderSize = 0;
            this.btnLevelSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLevelSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLevelSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelSelect.ForeColor = System.Drawing.Color.Transparent;
            this.btnLevelSelect.Location = new System.Drawing.Point(399, 275);
            this.btnLevelSelect.Name = "btnLevelSelect";
            this.btnLevelSelect.Size = new System.Drawing.Size(127, 50);
            this.btnLevelSelect.TabIndex = 1;
            this.btnLevelSelect.UseVisualStyleBackColor = false;
            this.btnLevelSelect.Click += new System.EventHandler(this.btnLevelSelect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.btnLevelSelect);
            this.Controls.Add(this.lblTextBox);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.Button btnLevelSelect;
    }
}

