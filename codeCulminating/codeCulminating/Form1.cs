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

        int[,] map = new int[10, 10];

        private void frmMain_Load(object sender, EventArgs e)
        {

            backbuffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            minibuffer = new Bitmap(tileSize, tileSize);



            Graphics G;
            G = this.CreateGraphics();
            // for loop to fill the form with black tiles
            for (int x = 0; x < this.Width; x += tileSize)
            {
                for (int y = 0; y < this.Height; y += tileSize)
                {
                    G.DrawImage(bmpWood, x, y, tileSize, tileSize);

                }
            }
            G.Dispose();
        }

        // level uno

    }
}
