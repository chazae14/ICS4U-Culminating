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


        int direction;

        // moving the girl in the proper directions
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {

        }

        int[,] map = new int[28, 16];

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(backbuffer, 0, 0, backbuffer.Width, backbuffer.Height);
        }

        // form load to load up first map
        private void frmMain_Load(object sender, EventArgs e)
        {

            Graphics G;
            G = this.CreateGraphics();

            // loading the backbuffer and the mini buffer to preserve the background behind the sprite
            backbuffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            minibuffer = new Bitmap(tileSize, tileSize);

            // loading in the images for the first map
            bmpGirl = new Bitmap(frmG.picGirl.Image, 162, 108);
            bmpWood = new Bitmap(frmG.bmpWood.Image, tileSize, tileSize);
            rect0 = new Rectangle(0, 0, tileSize, tileSize);

            Graphics gback = Graphics.FromImage(backbuffer);
            Graphics gmini = Graphics.FromImage(minibuffer);

            // for loop to fill the form with our background tiles
            for (int m = 0; m < 29; m++)
            {
                for (int n = 0; n < 16; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpWood, rectDest, rect0, GraphicsUnit.Pixel);
                }
            }
            // rectDest to start out sprite in top left corner
            rectDest = new Rectangle(0, 0, tileSize, tileSize);
            rectSource = new Rectangle(0, 0, tileSize, tileSize);

            // drawing out our girl and the background starting from the top left corner
            gmini.DrawImage(backbuffer, rect0, rectSource, GraphicsUnit.Pixel);
            gback.DrawImage(bmpGirl, rectDest, rect0, GraphicsUnit.Pixel);
            
            // girl's current position
            curX = 0; 
            curY = 0;
            gback.Dispose();
            gmini.Dispose();
        }

        // level uno

    }
}
