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
        frmGraphics frmG = new frmGraphics();  
        Bitmap backbuffer;                     
        Bitmap minibuffer;                     

        Bitmap bmpGirl;                        
        Bitmap bmpWood;
        Bitmap bmpWater;
        Rectangle rectSource, rect0, rectDest; 
        int curX, curY;                        
        int moves;                             
        int smallMove = 11;

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(backbuffer, 0, 0, backbuffer.Width, backbuffer.Height);
        }

        int direction;                     

        int[,] map = new int[10, 10];

        private void frmMain_Load(object sender, EventArgs e)
        {

            Graphics G;
            G = this.CreateGraphics();

            backbuffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            minibuffer = new Bitmap(tileSize, tileSize);

            bmpWood = new Bitmap(frmG.bmpWood.Image, tileSize, tileSize);

            Graphics gback = Graphics.FromImage(backbuffer);

            rect0 = new Rectangle(0, 0, tileSize, tileSize);

            // for loop to fill the form with our background tiles
            for (int m = 0; m < 29; m++)
            {
                for (int n = 0; n < 16; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpWood, rectDest, rect0, GraphicsUnit.Pixel);
                }
            }

            gback.Dispose();

        }

        // level uno

    }
}
