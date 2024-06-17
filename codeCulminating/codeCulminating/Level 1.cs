// 2024/05/28
// Level one mapping and interactions

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
    public partial class frmLevelOne : Form
    {
        public frmLevelOne()
        {
            InitializeComponent();
            //audPlayerLvl1.URL = "Lv1_Eerie_House.mp3";
        }

        int tileSize = 50;
        public static int compCount = 0;
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
        Bitmap bmpWindowTMR;
        Bitmap bmpWindowTR;
        Bitmap bmpWindowML;
        Bitmap bmpWindowMML;
        Bitmap bmpWindowMMR;
        Bitmap bmpWindowMR;
        Bitmap bmpWindowBL;
        Bitmap bmpWindowBML;
        Bitmap bmpWindowBMR;
        Bitmap bmpWindowBR;
        Bitmap bmpTrashCan;
        Bitmap bmpTopDresser;
        Bitmap bmpMiddleDresser;
        Bitmap bmpBottomDresser;

        bool checkTexts;
        SoundPlayer phoneRing = new SoundPlayer();
        PictureBox[] textMsgs;

        Rectangle rectSource, rect0, rectDest;
        int curX, curY;
        int moves;
        int smallMove = 17;
        int direction;
        int clicksCount = 0;
        int objectiveCount = 0;

        int[,] map = new int[29, 16];

        enum dir
        {
            down,
            left,
            right,
            up
        }

        private void Level_1_KeyDown(object sender, KeyEventArgs e)
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
                    if ((curX > 6 * tileSize && curX < 19 * tileSize) || (curX < 6 * tileSize)) // can go if in bounds 
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
                    if (curX <= 6 * tileSize || curX >= 20 * tileSize) // cant go if out of bounds
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
                    if (curY <= 7 * tileSize || curY >= 14 * tileSize) // cant go if out of bounds
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

                    if ((curY > 7 * tileSize && curY < 16 * tileSize) || (curY < 16 * tileSize)) // can go if within bounds
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


                if ((destTile != 0 && destTile != 20 && destTile != 21 && destTile != 23) && walk) // walk when on the right tiles (no bedside or bottom of bed
                {
                    moves = 0;
                    tmrMove.Enabled = true;
                }
                else
                {
                    walk = true;
                }

                /// ITEM INTERACTIONS
                // when near bedside table and e is clicked
                if (curX > 14 * tileSize && curX < 17 * tileSize && curY > 5 * tileSize && curY < 8 * tileSize && e.KeyCode == Keys.E && checkTexts == false)
                {
                    clicksCount += 13;
                    tmrRing.Stop();
                    phoneRing.Stop();
                    picPhone.Hide();
                    lblTransparent.Show();
                    picLockscreen.Show();
                    checkTexts = true;
                    phoneRing.SoundLocation = "Lv1_Eerie_House.wav";
                    phoneRing.Play();
                }
                else if (curX > 14 * tileSize && curX < 17 * tileSize && curY > 5 * tileSize && curY < 8 * tileSize && e.KeyCode == Keys.E && checkTexts == true)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    lblTextBox.Text = "\n \n \n      I'm not quite ready to leave yet.";
                    clicksCount++;

                }
                // desk interaction
                if (curX >= 7 * tileSize && curX <= 10 * tileSize && curY > 5 * tileSize && curY < 7 * tileSize && e.KeyCode == Keys.E)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    lblTextBox.Text = "\n \n \n      I should grab my money from my desk.";
                    clicksCount += 2;

                }

                // when on exit tiles and e is clicked
                else if (curX > 16 * tileSize && curX < 20 * tileSize && curY > 12 * tileSize && curY < 15 * tileSize && e.KeyCode == Keys.E)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    lblTextBox.Text = "\n \n \n      Hmmm. Should I leave yet? I need to make sure i have everything \n \n \n      I need.";
                    clicksCount += 6;
                }
                
           
                // dresser interaction
                else if (curX > 6 * tileSize && curX < 8 * tileSize && curY > 6 * tileSize && curY < 10 * tileSize && e.KeyCode == Keys.E)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    lblTextBox.Text = "\n \n \n      I don't see the paper here... but i guess i can get changed.";
                    clicksCount += 9;
                }

                // trash can interaction
                else if (curX > 5 * tileSize && curX < 7 * tileSize && curY > 4 * tileSize && curY < 7 * tileSize && e.KeyCode == Keys.E)
                {
                    LockCode inGamescreen = new LockCode();
                    inGamescreen.Show();
                }
            }
        }

        private void lblTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTransparent_Click(object sender, EventArgs e)
        {
            clicksCount++;

            // interaction with bedside table
            if (clicksCount == 2)
            {
                clicksCount = 0;

                lblTextBox.Hide();
                picGirlInteract.Hide();
                lblTransparent.Hide();
                lblTextBox.Text = "";
            }

            // interaction with desk
            else if (clicksCount == 3)
            {
                lblTextBox.Text = "\n \n \n      Oh shoot, I locked my drawer and my wallet is in there. \n       I forgot my passcode too!";
            }
            else if (clicksCount == 4)
            {
                lblTextBox.Text = "\n \n \n      That's alright. I'm sure thast I wrote it down on a piece of       paper somewhere...";
            }
            else if (clicksCount == 5)
            {
                CombinationLock inGamescreen = new CombinationLock();
                inGamescreen.Show();

                clicksCount = 0;

                lblTextBox.Hide();
                picGirlInteract.Hide();
                lblTransparent.Hide();
                lblTextBox.Text = "";
            }

            // interaction with exit tiles if not all objectives are completed
            else if (clicksCount == 7 && objectiveCount == 2)
            {
                lblTextBox.Text = "\n \n \n      I'm all set! Let's go!";
                clicksCount = 0;
                this.Close();
            }
            else if (clicksCount == 7 && objectiveCount == 1)
            {
                lblTextBox.Text = "\n \n \n      I still have one last thing to do. I should stay.";
            }
            else if (clicksCount == 7 && objectiveCount == 0)
            {
                lblTextBox.Text = "\n \n \n      I still have to get ready! I should stay.";
                
            }
            else if (clicksCount == 8)
            {
                clicksCount = 0;
                lblTextBox.Hide();
                picGirlInteract.Hide();
                lblTransparent.Hide();
                lblTextBox.Text = "";
            }

            else if (clicksCount == 9)
            {
                lblTextBox.Text = "\n \n \n      I don't see the paper here... I should check somewhere else.";
            }
            // interaction with dresser
            else if (clicksCount == 10)
            {
                SlidingPuzzle inGamescreen = new SlidingPuzzle();
                inGamescreen.Show();
                
                clicksCount = 0;
                lblTextBox.Hide();
                picGirlInteract.Hide();
                lblTransparent.Hide();
                lblTextBox.Text = "";
            }

            // interaction with texts chain
            else if (clicksCount == 13)
            {
                picLockscreen.Show();
            }
            else if (clicksCount == 14)
            {
                picLockscreen.Hide();
                picText1.Show();
            }
            else if (clicksCount == 15)
            {
                picText1.Hide();
                picText2.Show();
            }
            else if (clicksCount == 16)
            {
                picText2.Hide();
                picText3.Show();
            }
            else if (clicksCount == 17)
            {
                picText3.Hide();
                picText4.Show();
            }
            else if (clicksCount == 18)
            {
                picText4.Hide();
                picText5.Show();
            }
            else if (clicksCount == 19)
            {
                picText5.Hide();
            }
            else if (clicksCount == 20)
            {
                lblTextBox.Show();
                picGirlInteract.Show();
                lblTextBox.Text = "\n \n \n      I'll head over to the cafe once I'm ready.";
                picObjectives.Show();
                lblObjectives.Show();
            }
            else if (clicksCount == 21)
            {
                clicksCount = 0;
                lblTextBox.Hide();
                picGirlInteract.Hide();
                lblTransparent.Hide();
                lblTextBox.Text = "";
            }

        }

        private void textMsgs_Click(object sender, EventArgs e)
        {
            clicksCount++;
            if (clicksCount == 13)
            {
                picLockscreen.Show();
            }
            else if (clicksCount == 14)
            {
                picLockscreen.Hide();
                picText1.Show();
            }
            else if (clicksCount == 15)
            {
                picText1.Hide();
                picText2.Show();
            }
            else if (clicksCount == 16)
            {
                picText2.Hide();
                picText3.Show();
            }
            else if (clicksCount == 17)
            {
                picText3.Hide();
                picText4.Show();
            }
            else if (clicksCount == 18)
            {
                picText4.Hide();
                picText5.Show();
            }
            else if (clicksCount == 19)
            {
                picText5.Hide();
            }
            else if (clicksCount == 20)
            {
                lblTextBox.Show();
                picGirlInteract.Show();
                lblTextBox.Text = "\n \n \n      I should go meet her outside after I'm ready.";
            }
        }

        // for the phone ringing
        private void tmrRing_Tick(object sender, EventArgs e)
        {
            if (picPhoneOn.Visible == false)
            {
                picPhoneOn.Visible = true;
            }
            else if (picPhoneOn.Visible == true)
            {
                picPhoneOn.Visible = false;
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

        
        private void Level_1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(backbuffer, 0, 0, backbuffer.Width, backbuffer.Height);
        }

        private void Level_1_Load(object sender, EventArgs e)
        {
            //audPlayerLvl1.uiMode = "none";
            //audPlayerLvl1.Hide();
            Graphics G;
            G = this.CreateGraphics();

            lblTextBox.Hide();
            picGirlInteract.Hide();
            lblTransparent.Hide();
            picObjectives.Hide();
            lblObjectives.Hide();

            // phone starts ringing
            phoneRing.SoundLocation = "phoneVibrate.wav";
            tmrRing.Start();
            phoneRing.Play();

            // sets up eventhandler for clicking texts
            textMsgs = new PictureBox[] { picLockscreen, picText1, picText2, picText3, picText4, picText5 };
            for (int i = 0; i < textMsgs.Length; i++)
            {
                textMsgs[i].Click += new EventHandler(textMsgs_Click);
            }

            // loading the backbuffer and the mini buffer to preserve the background behind the sprite
            backbuffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            minibuffer = new Bitmap(tileSize, tileSize);

            // loading in the images for the first map
            bmpGirl = new Bitmap(frmG.picGirl.Image, 149, 200);
            bmpWood = new Bitmap(frmG.bmpWood.Image, tileSize, tileSize);
            bmpBlack = new Bitmap(frmG.picBlackTile.Image, tileSize, tileSize);
            bmpBottomWall = new Bitmap(frmG.picBottomWall.Image, tileSize, tileSize);
            bmpWall = new Bitmap(frmG.picPlainWall.Image, tileSize, tileSize);
            bmpTopLeftCarpet = new Bitmap(frmG.picToLeftCar.Image, tileSize, tileSize);
            bmpTopRightCarpet = new Bitmap(frmG.picTopRightCar.Image, tileSize, tileSize);
            bmpTopSideCarpet = new Bitmap(frmG.picTopCar.Image, tileSize, tileSize);
            bmpBottomLeftCarpet = new Bitmap(frmG.picBottomLeftCar.Image, tileSize, tileSize);
            bmpBottomRightCarpet = new Bitmap(frmG.picBottomRightCar.Image, tileSize, tileSize);
            bmpLeftCarpet = new Bitmap(frmG.picLeftSideCar.Image, tileSize, tileSize);
            bmpRightCarpet = new Bitmap(frmG.picRightSideCar.Image, tileSize, tileSize);
            bmpCenterCarpet = new Bitmap(frmG.picCenterCarpet.Image, tileSize, tileSize);
            bmpBottomSideCarpet = new Bitmap(frmG.picBottomSideCar.Image, tileSize, tileSize);
            bmpBedBottomLeft = new Bitmap(frmG.picBedBottomLeft.Image, tileSize, tileSize);
            bmpBedBottomRight = new Bitmap(frmG.picBedBottomRight.Image, tileSize, tileSize);
            bmpBedTopLef = new Bitmap(frmG.picBedTopLeft.Image, tileSize, tileSize);
            bmpBedTopRight = new Bitmap(frmG.picLevelOneBed.Image, tileSize, tileSize);
            bmpLeftDesk = new Bitmap(frmG.picLeftSideDesk.Image, tileSize, tileSize);
            bmpRightDesk = new Bitmap(frmG.picRightSideDesk.Image, tileSize, tileSize);
            bmpDeskTL = new Bitmap(frmG.picDeskTL.Image, tileSize, tileSize);
            bmpDeskBL = new Bitmap(frmG.picDeskBL.Image, tileSize, tileSize);
            bmpDeskBM = new Bitmap(frmG.picDeskBM.Image, tileSize, tileSize);
            bmpDeskTM = new Bitmap(frmG.picDeskTP.Image, tileSize, tileSize);
            bmpDeskTR = new Bitmap(frmG.picDeskTR.Image, tileSize, tileSize);
            bmpDeskBR = new Bitmap(frmG.picDeskBR.Image, tileSize, tileSize);
            bmpWallDetail = new Bitmap(frmG.picWallDetail.Image, tileSize, tileSize);
            bmpWindowBL = new Bitmap(frmG.picLvlOneWndBL.Image, tileSize, tileSize);
            bmpWindowBML = new Bitmap(frmG.picLvlOneWndBML.Image, tileSize, tileSize);
            bmpWindowBMR = new Bitmap(frmG.picLvlOneWndBMR.Image, tileSize, tileSize);
            bmpWindowBR = new Bitmap(frmG.picLvlOneWndBR.Image, tileSize, tileSize);
            bmpWindowTL = new Bitmap(frmG.picLvlOneWndTL.Image, tileSize, tileSize);
            bmpWindowTML = new Bitmap(frmG.picLvlOneWndTML.Image, tileSize, tileSize);
            bmpWindowTMR = new Bitmap(frmG.picLvlOneWndTMR.Image, tileSize, tileSize);
            bmpWindowTR = new Bitmap(frmG.picLvlOneWndTR.Image, tileSize, tileSize);
            bmpWindowML = new Bitmap(frmG.picLvlOneWndML.Image, tileSize, tileSize);
            bmpWindowMML = new Bitmap(frmG.picLvlOneWndMML.Image, tileSize, tileSize);
            bmpWindowMMR = new Bitmap(frmG.picLvlOneWndMMR.Image, tileSize, tileSize);
            bmpWindowMR = new Bitmap(frmG.picLvlOneWndMR.Image, tileSize, tileSize);
            bmpTrashCan = new Bitmap(frmG.picTrashCan.Image, tileSize, tileSize);
            bmpTopDresser = new Bitmap(frmG.picTopDresser.Image, tileSize, tileSize);
            bmpMiddleDresser = new Bitmap(frmG.picMiddleDresser.Image, tileSize, tileSize);
            bmpBottomDresser = new Bitmap(frmG.picBottomDresser.Image, tileSize, tileSize);

            rect0 = new Rectangle(0, 0, tileSize, tileSize);

            Graphics gback = Graphics.FromImage(backbuffer);
            Graphics gmini = Graphics.FromImage(minibuffer);

            /// LEVEL 1 MAP!!!
            // blacking out the background 
            for (int x = 0; x < 29; x++)
            {
                for (int y = 0; y < 16; y++)
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
            /// EXIT TILES
            rectDest = new Rectangle(19 * tileSize, 13 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWood, rectDest, rect0, GraphicsUnit.Pixel);
            map[(19), (13)] = 1;

            rectDest = new Rectangle(18 * tileSize, 13 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWood, rectDest, rect0, GraphicsUnit.Pixel);
            map[(18), (13)] = 1;

            map[17, 13] = 1;

            // for loop to display the crowning of the wall
            for (int b = 6; b < 20; b++)
            {
                for (int c = 5; c < 6; c++)
                {
                    rectDest = new Rectangle(b * tileSize, c * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpBottomWall, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(b), (c)] = 2;
                }
            }

            // for loop to display wall
            for (int g = 6; g < 20; g++)
            {
                for (int h = 2; h < 5; h++)
                {
                    rectDest = new Rectangle(g * tileSize, h * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpWall, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(g), (h)] = 3;
                }
            }

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
            rectDest = new Rectangle(15 * tileSize, 7 * tileSize, tileSize, tileSize);
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

            // displaying bed in corner
            // top left corner of bed
            rectDest = new Rectangle(18 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBedTopLef, rectDest, rect0, GraphicsUnit.Pixel);
            map[(17), (6)] = 17;

            // top right corner of bed
            rectDest = new Rectangle(19 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBedTopRight, rectDest, rect0, GraphicsUnit.Pixel);
            map[(18), (6)] = 18;

            // bottom left corner of bed
            rectDest = new Rectangle(18 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBedBottomLeft, rectDest, rect0, GraphicsUnit.Pixel);
            map[(17), (7)] = 19;

            // bottom right corner of bed
            rectDest = new Rectangle(19 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBedBottomRight, rectDest, rect0, GraphicsUnit.Pixel);
            map[(18), (7)] = 20;

            // filling in center of carpet
            for (int g = 11; g < 15; g++)
            {
                for (int h = 8; h < 10; h++)
                {
                    rectDest = new Rectangle(g * tileSize, h * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpCenterCarpet, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(g), (h)] = 18;
                }
            }

            /// WINDOW!!
            // window top left 
            rectDest = new Rectangle(11 * tileSize, 2 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowTL, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (2)] = 28;

            // window top middle left
            rectDest = new Rectangle(12 * tileSize, 2 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowTML, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (2)] = 29;

            // window top middle right
            rectDest = new Rectangle(13 * tileSize, 2 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowTMR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (2)] = 30;

            // window top right
            rectDest = new Rectangle(14 * tileSize, 2 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowTR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(14), (2)] = 31;

            // window middle left
            rectDest = new Rectangle(11 * tileSize, 3 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowML, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (3)] = 32;

            // window middle middle left
            rectDest = new Rectangle(12 * tileSize, 3 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowMML, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (3)] = 33;

            // window middle middle right
            rectDest = new Rectangle(13 * tileSize, 3 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowMMR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (3)] = 34;

            // window middle right
            rectDest = new Rectangle(14 * tileSize, 3 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowMR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(14), (3)] = 35;

            // window bottom left
            rectDest = new Rectangle(11 * tileSize, 4 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowBL, rectDest, rect0, GraphicsUnit.Pixel);
            map[(11), (4)] = 36;

            // window bottom middle left
            rectDest = new Rectangle(12 * tileSize, 4 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowBML, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (4)] = 37;

            // window bottom middle right
            rectDest = new Rectangle(13 * tileSize, 4 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowBMR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (4)] = 38;

            // window bottom right
            rectDest = new Rectangle(14 * tileSize, 4 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpWindowBR, rectDest, rect0, GraphicsUnit.Pixel);
            map[(14), (4)] = 39;

            /// BEDSIDE TABLE!!
            // left side of bedside table
            rectDest = new Rectangle(16 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpLeftDesk, rectDest, rect0, GraphicsUnit.Pixel);
            map[(16), (6)] = 21;

            // right side bedside table
            rectDest = new Rectangle(17 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpRightDesk, rectDest, rect0, GraphicsUnit.Pixel);
            map[(17), (6)] = 22;

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


            // trash can
            rectDest = new Rectangle(7 * tileSize, 6 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTrashCan, rectDest, rect0, GraphicsUnit.Pixel);
            map[(7), (6)] = 40;

            /// dresser
            // top dresser
            rectDest = new Rectangle(6 * tileSize, 7 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpTopDresser, rectDest, rect0, GraphicsUnit.Pixel);
            map[(6), (7)] = 41;

            // middle dresser
            rectDest = new Rectangle(6 * tileSize, 8 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpMiddleDresser, rectDest, rect0, GraphicsUnit.Pixel);
            map[(6), (8)] = 42;

            // bottom dresser
            rectDest = new Rectangle(6 * tileSize, 9 * tileSize, tileSize, tileSize);
            gback.DrawImage(bmpBottomDresser, rectDest, rect0, GraphicsUnit.Pixel);
            map[(6), (9)] = 43;

            // rectDest to start out sprite on her bed
            rectDest = new Rectangle(19 * tileSize, 6 * tileSize, tileSize, tileSize);
            rectSource = new Rectangle(19 * tileSize, 6 * tileSize, tileSize, tileSize);     
            
            // drawing out our girl on her bed
            gmini.DrawImage(backbuffer, rect0, rectDest, GraphicsUnit.Pixel);
            gback.DrawImage(bmpGirl, rectDest, rect0, GraphicsUnit.Pixel);

            // girl's current position
            curX = 19 * tileSize;
            curY = 6 * tileSize;
            gback.Dispose();
            gmini.Dispose();


            try // saving the map to our file from our array
            {
                string filePath = Application.StartupPath + "\\levelOneMap.txt";
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

        }


    }
}

