namespace codeCulminating
{
    partial class HelpScreen
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
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblControls1 = new System.Windows.Forms.Label();
            this.lblControls2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelpTitle
            // 
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTitle.Location = new System.Drawing.Point(151, 23);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Size = new System.Drawing.Size(101, 36);
            this.lblHelpTitle.TabIndex = 0;
            this.lblHelpTitle.Text = "Options";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblControls1
            // 
            this.lblControls1.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls1.Location = new System.Drawing.Point(34, 94);
            this.lblControls1.Name = "lblControls1";
            this.lblControls1.Size = new System.Drawing.Size(218, 51);
            this.lblControls1.TabIndex = 2;
            this.lblControls1.Text = "- Use W, A, S, D to move";
            // 
            // lblControls2
            // 
            this.lblControls2.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls2.Location = new System.Drawing.Point(34, 162);
            this.lblControls2.Name = "lblControls2";
            this.lblControls2.Size = new System.Drawing.Size(269, 51);
            this.lblControls2.TabIndex = 3;
            this.lblControls2.Text = "- Press E to interact with certain objects";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 99);
            this.label1.TabIndex = 4;
            this.label1.Text = "- DEV TEAM -\r\nHarleen D: Designer\r\nChaza E: Programmer\r\nJemuel L: Programmer\r\nRya" +
    "n C: Programmer and Musician\r\n";
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblControls2);
            this.Controls.Add(this.lblControls1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHelpTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(428, 489);
            this.Name = "HelpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpScreen";
            this.Load += new System.EventHandler(this.HelpScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblControls1;
        private System.Windows.Forms.Label lblControls2;
        private System.Windows.Forms.Label label1;
    }
}