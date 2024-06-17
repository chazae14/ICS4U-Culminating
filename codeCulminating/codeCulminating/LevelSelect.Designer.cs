namespace codeCulminating
{
    partial class frmLevelSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelSelect));
            this.btnLevelOne = new System.Windows.Forms.Button();
            this.bnLevelTwoSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLevelOne
            // 
            this.btnLevelOne.BackColor = System.Drawing.Color.Transparent;
            this.btnLevelOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevelOne.BackgroundImage")));
            this.btnLevelOne.FlatAppearance.BorderSize = 0;
            this.btnLevelOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLevelOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLevelOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelOne.Location = new System.Drawing.Point(235, 74);
            this.btnLevelOne.Name = "btnLevelOne";
            this.btnLevelOne.Size = new System.Drawing.Size(408, 317);
            this.btnLevelOne.TabIndex = 0;
            this.btnLevelOne.UseVisualStyleBackColor = false;
            this.btnLevelOne.Click += new System.EventHandler(this.btnLevelOne_Click);
            // 
            // bnLevelTwoSelect
            // 
            this.bnLevelTwoSelect.BackColor = System.Drawing.Color.Transparent;
            this.bnLevelTwoSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnLevelTwoSelect.BackgroundImage")));
            this.bnLevelTwoSelect.FlatAppearance.BorderSize = 0;
            this.bnLevelTwoSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnLevelTwoSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnLevelTwoSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnLevelTwoSelect.Location = new System.Drawing.Point(245, 391);
            this.bnLevelTwoSelect.Name = "bnLevelTwoSelect";
            this.bnLevelTwoSelect.Size = new System.Drawing.Size(398, 287);
            this.bnLevelTwoSelect.TabIndex = 1;
            this.bnLevelTwoSelect.UseVisualStyleBackColor = false;
            this.bnLevelTwoSelect.Click += new System.EventHandler(this.bnLevelTwoSelect_Click);
            // 
            // frmLevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.bnLevelTwoSelect);
            this.Controls.Add(this.btnLevelOne);
            this.Name = "frmLevelSelect";
            this.Text = "LevelSelect";
            this.Load += new System.EventHandler(this.frmLevelSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLevelOne;
        private System.Windows.Forms.Button bnLevelTwoSelect;
    }
}