// ICS4U Culminaiting 
// Chaza, Ryan, Harleen, Jemuel
// 2024/05/10
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
        Bitmap bmpWall;
        Bitmap bmpBottomWall;
        Bitmap bmpWindow;
        Bitmap bmpBlack;
        Bitmap bmpGirl;                        
        Bitmap bmpWood;
        Bitmap bmpMouseHole;
        Bitmap bmpTopLeftCarpet;
        Bitmap bmpTopRightCarpet;
        Bitmap bmpBottomLeftCarpet;
        Bitmap bmpBottomRightCarpet;
        Bitmap bmpLeftCarpet;
        Bitmap bmpRightCarpet;
        Bitmap bmpCenterCarpet;
        Bitmap bmpTopSideCarpet;
        Bitmap bmpBottomSideCarpet;

        Rectangle rectSource, rect0, rectDest; 
        int curX, curY;                        
        int moves;                             
        int smallMove = 16;
        int direction;


        int[,] map = new int[29, 16];

        enum dir
        {
            down,
            left,
            right,
            up
        }

        // moving the girl in the proper directions
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (tmrMove.Enabled == false)
            {
                int destTile = 99;              //default destTile is NOT WALKABLE
                bool walk = true;

                //depending on key pressed, check the tile you would move to (get it's tile number from the map)
                if (e.KeyCode == Keys.Right)
                {
                    direction = (int)dir.right;
                    if ((curX > 0 && curX < 297) || (curX < 297)) // can go if within bounds 
                    {
                        destTile = map[(curX + tileSize) / tileSize, curY / tileSize];
                    }
                    else // cant go if out of bounds
                    {
                        walk = false;
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    direction = (int)dir.left;
                    if (curX <= 0 || curX >= 298) // cant go if out of bounds
                    {
                        walk = false;
                    }
                    else // can go if within bounds
                    {
                        destTile = map[(curX - tileSize) / tileSize, curY / tileSize];
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    direction = (int)dir.up;
                    if (curY <= 0 || curY >= 298) // cant go if out of bounds
                    {
                        walk = false;
                    }
                    else // can go if within bounds
                    {
                        destTile = map[curX / tileSize, (curY - tileSize) / tileSize];
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    direction = (int)dir.down;

                    if ((curY > 0 && curY < 297) || (curY < 297)) // can go if within bounds
                    {
                        destTile = map[curX / tileSize, (curY + tileSize) / tileSize];
                    }
                    else // cant go if out of bounds
                    {
                        walk = false;
                    }
                }

                if ((destTile == 0 || destTile == 3) && walk)             //grass - 0 - is only WALKABLE tile.
                {
                    moves = 0;
                    tmrMove.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You can't go there!");
                    walk = true;
                }
            }
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            Graphics gback = Graphics.FromImage(backbuffer);
            Graphics gmini = Graphics.FromImage(minibuffer);

            //Heal the backbuffer (this essentially erases your sprite from the backbuffer)
            gback.DrawImage(minibuffer, rectSource, rect0, GraphicsUnit.Pixel);

            //adjust x or y coordinates based on direction
            if (direction == (int)dir.right)
            {
                curX += smallMove;
            }
            else if (direction == (int)dir.left)
            {
                curX -= smallMove;
            }
            else if (direction == (int)dir.up)
            {
                curY -= smallMove;
            }
            else if (direction == (int)dir.down)
            {
                curY += smallMove;
            }

            //Preserve the area of the backbuffer that you intend to move to next
            rectSource = new Rectangle(curX, curY, tileSize, tileSize);
            gmini.DrawImage(backbuffer, rect0, rectSource, GraphicsUnit.Pixel);

            //Move your sprite onto the backbuffer at the preserved location
            //Notice the y-coordinate of where we grab our sprite is multiplied by the direction (0, 1, 2 or 3)
            rectDest = new Rectangle(moves * tileSize, direction * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpGirl, rectSource, rectDest, GraphicsUnit.Pixel);
            this.Invalidate();

            //Track the number of mini-moves.  Stop after the 3rd one (because our spritemap has 3 frames)
            moves++;
            if (moves == 3)
            {
                tmrMove.Enabled = false;
            }
        }

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
            bmpBlack = new Bitmap(frmG.picBlackTile.Image, tileSize, tileSize);
            bmpBottomWall = new Bitmap(frmG.picBottomWall.Image, tileSize, tileSize);
            bmpWall = new Bitmap(frmG.picPlainWall.Image, tileSize, tileSize);
            bmpWindow = new Bitmap(frmG.picWindow.Image, tileSize, tileSize);
            bmpMouseHole = new Bitmap(frmG.picMouseHole.Image, tileSize, tileSize);
            bmpTopLeftCarpet = new Bitmap(frmG.picToLeftCar.Image, tileSize, tileSize);
            bmpTopRightCarpet = new Bitmap(frmG.picTopRightCar.Image, tileSize, tileSize);
            bmpTopSideCarpet = new Bitmap(frmG.picTopCar.Image, tileSize, tileSize);
            bmpBottomLeftCarpet = new Bitmap (frmG.picBottomLeftCar.Image, tileSize, tileSize);
            bmpBottomRightCarpet = new Bitmap (frmG.picBottomRightCar.Image, tileSize, tileSize);
            bmpLeftCarpet = new Bitmap(frmG.picLeftSideCar.Image, tileSize, tileSize);
            bmpRightCarpet = new Bitmap(frmG.picRightSideCar.Image, tileSize, tileSize);
            bmpCenterCarpet = new Bitmap(frmG.picCenterCarpet.Image, tileSize, tileSize);
            bmpBottomSideCarpet = new Bitmap(frmG.picBottomSideCar.Image, tileSize, tileSize);

            rect0 = new Rectangle(0, 0, tileSize, tileSize);

            Graphics gback = Graphics.FromImage(backbuffer);
            Graphics gmini = Graphics.FromImage(minibuffer);

            // blacking out the background 
            for (int x = 0; x < 29; x++)
            {
                for(int y = 0; y < 16; y++)
                {
                    rectDest = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpBlack, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(x), (y)] = 0;
                }
            }

            // for loop to display with floor/wood tiles
            for (int m = 6; m < 20; m++)
            {
                for (int n = 6; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpWood, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 1;
                }
            }

            // for loop to display the crowning of the wakll
            for (int b = 6; b < 20; b++)
            {
                for (int c = 5; c <6; c++)
                {
                    rectDest = new Rectangle(b * tileSize, c * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpBottomWall, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(b), (c)] = 2;
                }
            }

            // for loop to display wall
            for (int g = 6; g < 20; g++)
            {
                for (int h = 3; h < 5; h++)
                {
                    rectDest = new Rectangle(g * tileSize, h * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpWall, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(g), (h)] = 3;
                }
            }

            // displaying the window
            rectDest = new Rectangle(11 * tileSize, 4 * tileSize, 150, 100);
            gback.DrawImage(bmpWindow, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (4)] = 5;

            // displaying the mouse hole
            rectDest = new Rectangle(14 * tileSize, 5 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpMouseHole, rectDest, rect0, GraphicsUnit.Pixel);
            map[(14), (5)] = 6;

            // displaying carpet
            // displaying top left corner
            rectDest = new Rectangle(10 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTopLeftCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (7)] = 7;

            // displayer top side of carpet
            for (int g = 11; g < 15; g++)
            {
                for (int h = 7; h < 8; h++)
                {
                    rectDest = new Rectangle(g * tileSize, h * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpTopSideCarpet, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(g), (h)] = 8;
                }
            }

            // displaying top right carpet
            rectDest = new Rectangle(15  * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTopRightCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(15), (7)] = 9;

            // displaying leftside carpet
            rectDest = new Rectangle(10 * tileSize, 8 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpLeftCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (8)] = 10;

            rectDest = new Rectangle(10 * tileSize, 9 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpLeftCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (9)] = 10;

            // displaying bottom left carpet
            rectDest = new Rectangle(10 * tileSize, 10 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBottomLeftCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (10)] = 12;

            // displaying bottom side carpet
            for (int g = 11; g < 15; g++)
            {
                for (int h = 10; h < 11; h++)
                {
                    rectDest = new Rectangle(g * tileSize, h * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpBottomSideCarpet, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(g), (h)] = 13;
                }
            }

            // displaying bottom right side carpet
            rectDest = new Rectangle(15 * tileSize, 10 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBottomRightCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(15), (10)] = 14;

            // displaying right side carpet
            rectDest = new Rectangle(15 * tileSize, 9 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpRightCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(15), (9)] = 15;

            rectDest = new Rectangle(15 * tileSize, 8 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpRightCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(15), (8)] = 16;

            // filling in center of carpet
            for (int g = 11; g < 15; g++)
            {
                for (int h = 8; h < 10; h++)
                {
                    rectDest = new Rectangle(g * tileSize, h * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpCenterCarpet, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(g), (h)] = 17;
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
