// ICS4U Culminating 
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
using System.IO;
using System.Media;
using static System.Net.WebRequestMethods;

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
        Bitmap bmpBlack;
        Bitmap bmpGirl;                        
        Bitmap bmpWood;
        Bitmap bmpTopLeftCarpet;
        Bitmap bmpTopRightCarpet;
        Bitmap bmpBottomLeftCarpet;
        Bitmap bmpBottomRightCarpet;
        Bitmap bmpLeftCarpet;
        Bitmap bmpRightCarpet;
        Bitmap bmpCenterCarpet;
        Bitmap bmpTopSideCarpet;
        Bitmap bmpBottomSideCarpet;
        Bitmap bmpBedTopLef;
        Bitmap bmpBedTopRight;
        Bitmap bmpBedBottomLeft;
        Bitmap bmpBedBottomRight;
        Bitmap bmpRightDesk;
        Bitmap bmpLeftDesk;
        Bitmap bmpDeskTL;
        Bitmap bmpDeskBL;
        Bitmap bmpDeskBM;
        Bitmap bmpDeskTM;
        Bitmap bmpDeskBR;
        Bitmap bmpDeskTR;
        Bitmap bmpWallDetail;
        Bitmap bmpWindowTL;
        Bitmap bmpWindowTML;
        Bitmap bmpWindowTR;
        Bitmap bmpWindowBL;
        Bitmap bmpWindowBML;
        Bitmap bmpWindowBR;
        Bitmap bmpTrashCan;
        Bitmap bmpTopDresser;
        Bitmap bmpMiddleDresser;
        Bitmap bmpBottomDresser;

        Rectangle rectSource, rect0, rectDest; 
        int curX, curY;                        
        int moves;                             
        int smallMove = 17;
        int direction;
        int clicksCount = 0;

        int[,] map = new int[29, 16];
        SoundPlayer lvl1Music = new SoundPlayer();

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
                bool walk = false;
                Graphics gback = Graphics.FromImage(backbuffer);


                //depending on key pressed, check the tile you would move to (get it's tile number from the map)
                if (e.KeyCode == Keys.D)
                {
                    direction = (int)dir.right;
                    if ((curX > 8 * tileSize && curX < 18 * tileSize) || (curX < 8 * tileSize)) // can go if in bounds 
                    {
                        destTile = map[(curX + tileSize) / tileSize, curY / tileSize];
                        walk = true;
                    }
                    else // cant go if out of bounds
                    {
                        walk = false;
                    }
                }
                if (e.KeyCode == Keys.A)
                {
                    direction = (int)dir.left;
                    if (curX <= 7 * tileSize || curX >= 19 * tileSize) // cant go if out of bounds
                    {
                        walk = false;
                    }
                    else // can go if within bounds
                    {
                        destTile = map[(curX - tileSize) / tileSize, curY / tileSize];
                        walk = true;

                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    direction = (int)dir.up;
                    if (curY <= 6 * tileSize || curY >= 12 * tileSize) // cant go if out of bounds
                    {
                        walk = false;
                    }
                    else // can go if within bounds
                    {
                        destTile = map[curX / tileSize, (curY - tileSize) / tileSize];
                        walk = true;

                    }
                }
                else if (e.KeyCode == Keys.S)
                {
                    direction = (int)dir.down;

                    if ((curY > 7 * tileSize && curY < 11 * tileSize) || (curY < 11 * tileSize)) // can go if within bounds
                    {
                        destTile = map[curX / tileSize, (curY + tileSize) / tileSize];
                        walk = true;

                    }
                    else // cant go if out of bounds
                    {
                        walk = false;
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    frmPause frmPause = new frmPause();
                    frmPause.Show();
                }

                if ((destTile != 0 && destTile != 20 && destTile != 21 && destTile != 23) && walk)
                {
                    moves = 0;
                    tmrMove.Enabled = true;
                }
                else
                {
                    walk = true;
                }

                /// ITEM INTERACTION
                // when near desk, & E is clicked, level select shows up
                if (curX >= 7 * tileSize && curX <= 10 * tileSize && curY > 5 * tileSize && curY < 7 * tileSize && e.KeyCode == Keys.E)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    lblTextBox.Text = "\n \n \n      My desk. I keep all my valubles here. Wait, what is that...?";
                    clicksCount += 11;
                }
                // when near bedside table and E is clicked, interaction occurs
                else if (curX > 14 * tileSize && curX < 17 * tileSize && curY > 5 * tileSize && curY < 8 * tileSize && e.KeyCode == Keys.E)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    clicksCount += 2;
                    lblTextBox.Text = "\n \n \n      This is my bedside table, where I usually keep my phone.";

                }
                // when near bed and e is clicked
                else if (curX > 16 * tileSize && curX < 19 * tileSize && curY > 5 * tileSize && curY < 8 * tileSize && e.KeyCode == Keys.E)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    clicksCount += 8;
                    lblTextBox.Text = "\n \n \n      My bed! And my teddy named Lorenzo!";

                }
                // dresser interaction
                else if(curX > 7 * tileSize && curX < 9 * tileSize && curY > 6 * tileSize && curY < 10 * tileSize && e.KeyCode == Keys.E)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    clicksCount += 9;
                    lblTextBox.Text = "\n \n \n      This is my dresser, where I keep all my clothes.";

                }
            }
        }

        private void lblTransparent_Click(object sender, EventArgs e)
        {
            clicksCount++;

            /// CLICKS FOR BEDSIDE TABLE INTERACTION
            if (clicksCount == 3)
            {
                lblTransparent.Hide();
                clicksCount = 0;
                lblTextBox.Hide();
                lblTextBox.Text = "";
                picGirlInteract.Hide();
            }

            /// CLICKS FOR BED
            else if (clicksCount == 9)
            {
                lblTextBox.Hide();
                lblTextBox.Text = "";

                picGirlInteract.Hide();
                lblTransparent.Hide();
                clicksCount = 0;
            }

            /// dresser interactions
            else if (clicksCount == 10)
            {
                lblTextBox.Hide();
                lblTextBox.Text = "";

                picGirlInteract.Hide();
                lblTransparent.Hide();
                clicksCount = 0;
            }

            /// desk interactions
            else if (clicksCount == 12)
            {
                lblTextBox.Text = "\n \n \n      My photo album! Maybe this will help me remember what \n      happened yesterday. Let's start with the beginning \n      of the day.";
            }
            else if (clicksCount == 13)
            {
                frmLevelSelect inGamescreen = new frmLevelSelect();

                inGamescreen.Show();
                clicksCount = 0;
                lblTextBox.Text = "";

                lblTextBox.Hide();
                picGirlInteract.Hide();
                lblTransparent.Hide();
            }

            // opening cutscene
            else if (clicksCount == 14)
            {
                lblTextBox.Show();
                lblTextBox.Text = "\n \n \n      I've been awake for a couple minutes now. Ughhh. Mom  \n      moved all my stuff around again...";

            }
            else if (clicksCount == 15)
            {
                lblTextBox.Text = "\n \n \n      Guess I'll look around to see where my stuff's gone.";

            }
            else if (clicksCount == 16)
            {
                lblTextBox.Hide();
                lblTextBox.Text = "";

                picGirlInteract.Hide();
                lblTransparent.Hide();
                clicksCount = 0;
            }
        }

        private void timerIn_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void lblTextBox_Click(object sender, EventArgs e)
        {

        }

        private void tmrMove_Tick_1(object sender, EventArgs e)
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

            lblTextBox.Hide();
            picGirlInteract.Hide();
            lblTransparent.Hide();

            lvl1Music.SoundLocation = "Title_Music.wav";
            lvl1Music.Play();

            // loading the backbuffer and the mini buffer to preserve the background behind the sprite
            backbuffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            minibuffer = new Bitmap(tileSize, tileSize);

            // loading in the images for the intro map
            bmpGirl = new Bitmap(frmG.picGirl.Image, 149, 200);
            bmpWood = new Bitmap(frmG.bmpWood.Image, tileSize, tileSize);
            bmpBlack = new Bitmap(frmG.picBlackTile.Image, tileSize, tileSize);
            bmpBottomWall = new Bitmap(frmG.picBottomWall.Image, tileSize, tileSize);
            bmpWall = new Bitmap(frmG.picPlainWall.Image, tileSize, tileSize);
            bmpTopLeftCarpet = new Bitmap(frmG.picToLeftCar.Image, tileSize, tileSize);
            bmpTopRightCarpet = new Bitmap(frmG.picTopRightCar.Image, tileSize, tileSize);
            bmpTopSideCarpet = new Bitmap(frmG.picTopCar.Image, tileSize, tileSize);
            bmpBottomLeftCarpet = new Bitmap (frmG.picBottomLeftCar.Image, tileSize, tileSize);
            bmpBottomRightCarpet = new Bitmap (frmG.picBottomRightCar.Image, tileSize, tileSize);
            bmpLeftCarpet = new Bitmap(frmG.picLeftSideCar.Image, tileSize, tileSize);
            bmpRightCarpet = new Bitmap(frmG.picRightSideCar.Image, tileSize, tileSize);
            bmpCenterCarpet = new Bitmap(frmG.picCenterCarpet.Image, tileSize, tileSize);
            bmpBottomSideCarpet = new Bitmap(frmG.picBottomSideCar.Image, tileSize, tileSize);
            bmpBedBottomLeft = new Bitmap (frmG.picBedBottomLeft.Image, tileSize, tileSize);
            bmpBedBottomRight = new Bitmap (frmG.picBedBottomRight.Image, tileSize, tileSize);
            bmpBedTopLef = new Bitmap (frmG.picBedTopLeft.Image, tileSize, tileSize);   
            bmpBedTopRight = new Bitmap(frmG.picBedTopRigt.Image, tileSize, tileSize);
            bmpLeftDesk = new Bitmap (frmG.picLeftSideDesk.Image, tileSize, tileSize);
            bmpRightDesk = new Bitmap (frmG.picRightSideDesk.Image, tileSize, tileSize);
            bmpDeskTL = new Bitmap(frmG.picDeskTL.Image, tileSize, tileSize);
            bmpDeskBL = new Bitmap (frmG.picDeskBL.Image, tileSize, tileSize);
            bmpDeskBM = new Bitmap (frmG.picDeskBM.Image, tileSize, tileSize);
            bmpDeskTM = new Bitmap (frmG.picDeskTP.Image, tileSize, tileSize);
            bmpDeskTR = new Bitmap (frmG.picDeskTR.Image, tileSize, tileSize);
            bmpDeskBR = new Bitmap (frmG.picDeskBR.Image, tileSize, tileSize);  
            bmpWallDetail = new Bitmap (frmG.picWallDetail.Image, tileSize, tileSize);   
            bmpWindowBL = new Bitmap (frmG.picWindowBL.Image, tileSize, tileSize);
            bmpWindowBML = new Bitmap(frmG.picWindowBML.Image, tileSize, tileSize);
            bmpWindowBR = new Bitmap (frmG.picWindowBR.Image, tileSize, tileSize);  
            bmpWindowTL = new Bitmap (frmG.picWindowTL.Image, tileSize, tileSize);
            bmpWindowTML = new Bitmap (frmG.picWindowTML.Image, tileSize, tileSize);    
            bmpWindowTR = new Bitmap (frmG.picWindowTR.Image, tileSize, tileSize);
            bmpTrashCan = new Bitmap(frmG.picTrashCan.Image, tileSize, tileSize);
            bmpTopDresser = new Bitmap(frmG.picTopDresser.Image, tileSize, tileSize);
            bmpMiddleDresser = new Bitmap(frmG.picMiddleDresser.Image, tileSize, tileSize);
            bmpBottomDresser = new Bitmap(frmG.picBottomDresser.Image, tileSize, tileSize);

            rect0 = new Rectangle(0, 0, tileSize, tileSize);

            Graphics gback = Graphics.FromImage(backbuffer);
            Graphics gmini = Graphics.FromImage(minibuffer);

            /// INTRO ONE MAP!! 
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
            for (int m = 7; m < 19; m++)
            {
                for (int n = 6; n < 12; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpWood, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 1;
                }
            }

            // for loop to display the crowning of the wall
            for (int b = 7; b < 19; b++)
            {
                for (int c = 5; c <6; c++)
                {
                    rectDest = new Rectangle(b * tileSize, c * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpBottomWall, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(b), (c)] = 2;
                }
            }

            // for loop to display wall
            for (int g = 7; g < 19; g++)
            {
                for (int h = 2; h < 5; h++)
                {
                    rectDest = new Rectangle(g * tileSize, h * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpWall, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(g), (h)] = 3;
                }
            }

            // displaying wall detail
            rectDest = new Rectangle(17 * tileSize, 4 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWallDetail, rectDest, rect0, GraphicsUnit.Pixel);
            map[(17), (4)] = 6;

            /// displaying carpet
            // displaying top left corner
            rectDest = new Rectangle(11 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTopLeftCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (7)] = 7;

            // displayer top side of carpet
            rectDest = new Rectangle(12 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTopSideCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (7)] = 8;

            rectDest = new Rectangle(13 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTopSideCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (7)] = 8;

            // displaying top right carpet
            rectDest = new Rectangle(14  * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTopRightCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (7)] = 9;

            // displaying left side carpet
            rectDest = new Rectangle(11 * tileSize, 8 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpLeftCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (8)] = 10;

            // displaying right side carpet
            rectDest = new Rectangle(14 * tileSize, 8 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpRightCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (8)] = 11;

            // displaying center carpet
            rectDest = new Rectangle(12 * tileSize, 8 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpCenterCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (8)] = 15;

            rectDest = new Rectangle(13 * tileSize, 8 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpCenterCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (8)] = 15;

            // displaying bottom left carpet
            rectDest = new Rectangle(11 * tileSize, 9 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBottomLeftCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (9)] = 12;

            // displaying bottom side carpet
            rectDest = new Rectangle(12 * tileSize, 9 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBottomSideCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (9)] = 13;

            rectDest = new Rectangle(13 * tileSize, 9 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBottomSideCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (9)] = 13;

            // displaying bottom right side carpet
            rectDest = new Rectangle(14 * tileSize, 9 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBottomRightCarpet, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (9)] = 14;

            /// displaying bed in corner
            // top left corner of bed
            rectDest = new Rectangle(17 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBedTopLef, rectDest, rect0, GraphicsUnit.Pixel);
            map[(17), (6)] = 17;

            // top right corner of bed
            rectDest = new Rectangle(18 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBedTopRight, rectDest, rect0, GraphicsUnit.Pixel);
            map[(18), (6)] = 18;

            // bottom left corner of bed
            rectDest = new Rectangle(17 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBedBottomLeft, rectDest, rect0, GraphicsUnit.Pixel);
            map[(17), (7)] = 19;

            // bottom right corner of bed
            rectDest = new Rectangle(18 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBedBottomRight, rectDest, rect0, GraphicsUnit.Pixel);
            map[(18), (7)] = 20;

            /// BEDSIDE TABLE!!
            // left side of bedside table
            rectDest = new Rectangle(15 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpLeftDesk, rectDest, rect0, GraphicsUnit.Pixel);
            map[(15), (6)] = 21;

            // right side bedside table
            rectDest = new Rectangle(16 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpRightDesk, rectDest, rect0, GraphicsUnit.Pixel);
            map[(16), (6)] = 22;

            /// DESK DESK DESK!
            // top left desk
            rectDest = new Rectangle(8 * tileSize, 5 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpDeskTL, rectDest, rect0, GraphicsUnit.Pixel);
            map[(8), (5)] = 23;

            // top middle desk
            rectDest = new Rectangle(9 * tileSize, 5 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpDeskTM, rectDest, rect0, GraphicsUnit.Pixel);
            map[(9), (5)] = 24;

            // top right desk
            rectDest = new Rectangle(10 * tileSize, 5 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpDeskTR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (5)] = 25;

            // bottom left desk
            rectDest = new Rectangle(8 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpDeskBL, rectDest, rect0, GraphicsUnit.Pixel);
            map[(8), (6)] = 26;

            // bottom middle desk
            rectDest = new Rectangle(9 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpDeskBM, rectDest, rect0, GraphicsUnit.Pixel);
            map[(9), (6)] = 26;

            // bottom right desk
            rectDest = new Rectangle(10 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpDeskBR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (6)] = 27;

            /// WINDOW!!
            // window top left 
            rectDest = new Rectangle(11 * tileSize, 3 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowTL, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (3)] = 28;

            // window top middle 
            rectDest = new Rectangle(12 * tileSize, 3 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowTML, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (3)] = 29;

            // window top right
            rectDest = new Rectangle(13 * tileSize, 3 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowTR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (3)] = 30;

            // window bottom left
            rectDest = new Rectangle(11 * tileSize, 4 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowBL, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (4)] = 35;

            // window bottom middle 
            rectDest = new Rectangle(12 * tileSize, 4 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowBML, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (4)] = 36;

            // window bottom right
            rectDest = new Rectangle(13 * tileSize, 4 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowBR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (4)] = 37;

            // trash can
            rectDest = new Rectangle(7 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTrashCan, rectDest, rect0, GraphicsUnit.Pixel);
            map[(7), (6)] = 38;

            /// dresser
            // top dresser
            rectDest = new Rectangle(7 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTopDresser, rectDest, rect0, GraphicsUnit.Pixel);
            map[(7), (7)] = 39;

            // middle dresser
            rectDest = new Rectangle(7 * tileSize, 8 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpMiddleDresser, rectDest, rect0, GraphicsUnit.Pixel);
            map[(7), (8)] = 40;

            // bottom dresser
            rectDest = new Rectangle(7 * tileSize, 9 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBottomDresser, rectDest, rect0, GraphicsUnit.Pixel);
            map[(7), (9)] = 41;


            // rectDest to start out sprite on her bed
            rectDest = new Rectangle(16 * tileSize, 7 * tileSize, tileSize, tileSize);
            rectSource = new Rectangle(16 * tileSize, 7 * tileSize, tileSize, tileSize);

            // drawing out our girl on her bed
            gmini.DrawImage(backbuffer, rect0, rectDest, GraphicsUnit.Pixel);
            gback.DrawImage(bmpGirl, rectDest, rect0, GraphicsUnit.Pixel);

            // girl's current position
            curX = 16 * tileSize; 
            curY = 7 * tileSize;
            gback.Dispose();
            gmini.Dispose();


            try // saving the map to our file from our array
            {
                string filePath = Application.StartupPath + "\\introLobbyMap.txt";
                FileStream fs = new FileStream(filePath, FileMode.Create);
                StreamWriter myFile = new StreamWriter(fs);
                // saving the numbers of the array into a file to be read later
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    for (int y = 0; y < map.GetLength(1); y++)
                    {
                        myFile.WriteLine("" + map[x, y]);
                    }
                }
                myFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lblTransparent.Show();
            picGirlInteract.Show();
            clicksCount += 13;



        }
    }
}
