using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codeCulminating
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int tileSize = 50;

        private void frmMain_Load(object sender, EventArgs e)
        {
            Graphics G;
            G = this.CreateGraphics();
            // for loop to fill the form with black tiles
            for (int x = 0; x < this.Width; x += tileSize)
            {
                for (int y = 0; y < this.Height; y += tileSize)
                {
                    G.DrawImage(bmpWood, newX, newY, tileSize, tileSize);

                }
            }
            G.Dispose();
        }

        // level uno

    }
}
