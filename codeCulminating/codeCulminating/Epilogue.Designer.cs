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
            // 
            // Epilogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 761);
            this.Controls.Add(this.lblTransparent);
            this.Name = "Epilogue";
            this.Text = "Epilogue";
            this.Load += new System.EventHandler(this.Epilogue_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Epilogue_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Epilogue_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label lblTransparent;
    }
}