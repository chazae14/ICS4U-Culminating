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
    public partial class LevelTwo : Form
    {
        public LevelTwo()
        {
            InitializeComponent();
        }

        Rectangle rectSource, rect0, rectDest;
        int curX, curY;
        int moves;
        int smallMove = 17;
        int direction;
        int clicksCount = 0;
        int[,] map = new int[29, 16];

        public static int completedCount = 0;

        int tileSize = 50;
        frmGraphics frmG = new frmGraphics();
        Bitmap backbuffer;
        Bitmap minibuffer;
        Bitmap bmpBlack;
        Bitmap bmpGirl;
        Bitmap bmpSidewalk;
        Bitmap bmpTopRoad;
        Bitmap bmpBttmRoad;
        Bitmap bmpRoadFiller;
        Bitmap bmpWood;
        Bitmap bmpRoadRightSide;
        Bitmap bmpRoadLeftSide;
        Bitmap bmpSidewalkTop;
        Bitmap bmpCrosswalk;
        Bitmap bmpCrosswalkSide;
        Bitmap bmpGrass;
        Bitmap bmpCafeWallTop;
        Bitmap bmpCafeWallSide;
        Bitmap bmpTableLeft;
        Bitmap bmpTableRight;
        Bitmap bmpCounterLeftEdge;
        Bitmap bmpCounterMiddleLeft;
        Bitmap bmpCounterMiddle;
        Bitmap bmpCounterMiddleRight;
        Bitmap bmpCounterRightEdge;

        SoundPlayer lvl2Music = new SoundPlayer();

        enum dir
        {
            down,
            left,
            right,
            up
        }


        private void LevelTwo_KeyDown(object sender, KeyEventArgs e)
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
                    if ((curX > 3 * tileSize && curX < 19 * tileSize) || (curX < 4 * tileSize)) // can go if in bounds 
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
                    if (curX <= 4 * tileSize || curX >= 20 * tileSize) // cant go if out of bounds
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
                    if (curY <= 1 * tileSize || curY >= 14 * tileSize) // cant go if out of bounds
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

                    if ((curY > 1 * tileSize && curY < 13 * tileSize) || (curY < 13 * tileSize)) // can go if within bounds
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


                if (destTile != 0 && destTile != 8 && destTile != 9 && destTile != 10 && destTile != 11 && destTile != 12 && walk) // walk when on the right tiles (no walls or out of bounds)
                {
                    moves = 0;
                    tmrMove.Enabled = true;
                }
                else
                {
                    walk = true;
                }

                if (curX > 10 * tileSize && curX < 14 * tileSize && curY > 10 * tileSize && curY < 12 * tileSize && e.KeyCode == Keys.E)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    lblTextBox.Text = "\n \n \n     My friend is taking a while. I think i'll just order something.";
                    clicksCount++;
                }

                if (curX > 17 * tileSize && curX < 19 * tileSize && curY > 6 * tileSize && curY < 8 * tileSize && completedCount == 2)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    lblTextBox.Text = "\n \n \n     My friend is taking a while. I think i'll just order something.";
                    clicksCount++;
                }

                if (completedCount == 1)
                {
                    picGirlInteract.Show();
                    lblTextBox.Show();
                    lblTransparent.Show();
                    lblTextBox.Text = "\n \n \n     Oh. A new text message.";
                    clicksCount+= 8;
                    completedCount++;
                }
            }
        }

        private void lblTransparent_Click(object sender, EventArgs e)
        {
            clicksCount++;
            if (clicksCount == 2)
            {
                picBarista.Show();
                lblTextBox.Text = "\n\n\n     I'll just take a coffee and a brownie. Thanks.";
            }
            else if (clicksCount == 3)
            {
                lblTextBox.Text = "   Barista: \n\n      Absolutely! Cash or card?";
            }
            else if (clicksCount == 4)
            {
                lblTextBox.Text = "\n\n\n     Card, please.";
            }
            else if (clicksCount == 5)
            {
                lblTextBox.Text = "   Barista: \n\n      Whenever it's ready for you.";
            } 
            else if (clicksCount == 6)
            {
                MemoryGame inGamescreen = new MemoryGame();
                inGamescreen.Show();
                clicksCount = 0;

                lblTextBox.Hide();
                picGirlInteract.Hide();
                lblTransparent.Hide();
                picBarista.Hide();
                lblTextBox.Text = "";
            }
            else if (clicksCount == 9)
            {
                lblTextBox.Text = "\n\n\n     My friend is just outside. Let's go meet her.";

            }
            else if (clicksCount == 10)
            {
                clicksCount = 0;

                lblTextBox.Hide();
                picGirlInteract.Hide();
                lblTransparent.Hide();
                lblTextBox.Text = "";
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


        private void LevelTwo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(backbuffer, 0, 0, backbuffer.Width, backbuffer.Height);
        }

        private void LevelTwo_Load(object sender, EventArgs e)
        {
            Graphics G;
            G = this.CreateGraphics();

            // hiding all the random pictures 
            lblTextBox.Hide();
            picGirlInteract.Hide();
            lblTransparent.Hide();

            // sets music
            lvl2Music.SoundLocation = "High_and_Dry.wav";
            lvl2Music.Play();

            // loading the backbuffer and the mini buffer to preserve the background behind the sprite
            backbuffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            minibuffer = new Bitmap(tileSize, tileSize);

            bmpGirl = new Bitmap(frmG.picGirl.Image, 149, 200);
            bmpBlack = new Bitmap(frmG.picBlackTile.Image, tileSize, tileSize);
            bmpBttmRoad = new Bitmap(frmG.picRoadMiddle.Image, tileSize, tileSize);
            bmpTopRoad = new Bitmap(frmG.picRoadTop.Image, tileSize, tileSize);
            bmpRoadFiller = new Bitmap(frmG.picRoadBottom.Image, tileSize, tileSize);
            bmpSidewalk = new Bitmap (frmG.picSideWalk.Image, tileSize, tileSize);  
            bmpWood = new Bitmap(frmG.bmpWood.Image, tileSize, tileSize);
            bmpRoadLeftSide = new Bitmap(frmG.picRoadSideLeft.Image, tileSize, tileSize);
            bmpRoadRightSide = new Bitmap(frmG.picRideSideRoad.Image, tileSize, tileSize);
            bmpSidewalkTop = new Bitmap(frmG.picSidewalkTop.Image, tileSize, tileSize); 
            bmpCrosswalk = new Bitmap(frmG.picCrosswalk.Image, tileSize, tileSize);
            bmpCrosswalkSide = new Bitmap(frmG.picCrosswalkSide.Image, tileSize, tileSize); 
            bmpGrass = new Bitmap(frmG.picGrass.Image, tileSize, tileSize);
            bmpCafeWallTop = new Bitmap(frmG.picCafeWall.Image, tileSize, tileSize);
            bmpCafeWallSide = new Bitmap(frmG.picCafeWallSide.Image, tileSize, tileSize);
            bmpTableLeft = new Bitmap(frmG.picTableLeft.Image, tileSize, tileSize);
            bmpTableRight = new Bitmap(frmG.picTableRight.Image, tileSize, tileSize);
            bmpCounterLeftEdge = new Bitmap(frmG.picLeftEndCounter.Image, tileSize, tileSize);  
            bmpCounterMiddleLeft = new Bitmap(frmG.picLeftMiddleCounter.Image, tileSize, tileSize); 
            bmpCounterMiddle = new Bitmap(frmG.picMiddleCounter.Image, tileSize, tileSize);
            bmpCounterMiddleRight = new Bitmap(frmG.picMiddleRightCounter.Image, tileSize, tileSize);
            bmpCounterRightEdge = new Bitmap(frmG.picRightEndCounter.Image, tileSize, tileSize);

            rect0 = new Rectangle(0, 0, tileSize, tileSize);

            Graphics gback = Graphics.FromImage(backbuffer);
            Graphics gmini = Graphics.FromImage(minibuffer);

            /// LEVEL TWO MAP 
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

            ///ROAD 
            // bottom & top of road
            for (int m = 4; m < 18; m++)
            {
                for (int n = 2; n < 3; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpRoadFiller, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 1;
                }
            }

            for (int m = 4; m < 18; m++)
            {
                for (int n = 5; n < 6; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpRoadFiller, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 1;
                }
            }

            for (int m = 19; m < 20; m++)
            {
                for (int n = 6; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpRoadFiller, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 1;
                }
            }

            for (int m = 22; m < 23; m++)
            {
                for (int n = 6; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpRoadFiller, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 1;
                }
            }

            for (int m = 18; m < 23; m++)
            {
                for (int n = 2; n < 6; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpRoadFiller, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 1;
                }
            }

            // middle top road
            for (int m = 4; m < 18; m++)
            {
                for (int n = 3; n < 4; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpTopRoad, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 2;
                }
            }

            for (int m = 20; m < 21; m++)
            {
                for (int n = 6; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpRoadLeftSide, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 6;
                }
            }


            // middle bottom road
            for (int m = 4; m < 18; m++)
            {
                for (int n = 4; n < 5; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpBttmRoad, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 3;
                }
            }

            for (int m = 21; m < 22; m++)
            {
                for (int n = 6; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpRoadRightSide, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 7;
                }
            }

            //sidewalk
            for (int m = 4; m < 18; m++)
            {
                for (int n = 6; n < 7; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpSidewalkTop, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 4;
                }
            }

            for (int m = 4; m < 23; m++)
            {
                for (int n = 1; n < 2; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpSidewalkTop, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 4;
                }
            }

            for (int m = 18; m < 19; m++)
            {
                for (int n = 6; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpSidewalk, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 4;
                }
            }

            // crosswalk
            for (int m = 17; m < 18; m++)
            {
                for (int n = 2; n < 3; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, 100, 200);
                    gback.DrawImage(bmpCrosswalk, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 6;
                }
            }

            for (int m = 19; m < 20; m++)
            {
                for (int n = 6; n < 7; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, 200, 100);
                    gback.DrawImage(bmpCrosswalkSide, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 6;
                }
            }

            ///CAFE
            // grasss in front of cafe
            for (int m = 15; m < 18; m++)
            {
                for (int n = 7; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpGrass, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 7;
                }
            }
            // wood floor
            for (int m = 4; m < 15; m++)
            {
                for (int n = 7; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpWood, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 5;
                }
            } 

            // top wall of cafe
            for (int m = 4; m < 14; m++)
            {
                for (int n = 7; n < 8; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpCafeWallTop, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 8;
                }
            }

            // side wall of cafe
            for (int m = 15; m < 16; m++)
            {
                for (int n = 7; n < 13; n++)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpCafeWallSide, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 9;
                }
            }

            // cafe tables
            for (int m = 5; m < 6; m++) // right side of table
            {
                for (int n = 8; n < 13; n+=2)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpTableRight, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 10;
                }
            }

            for (int m = 4; m < 5; m++) // left side of table
            {
                for (int n = 8; n < 13; n += 2)
                {
                    rectDest = new Rectangle(m * tileSize, n * tileSize, tileSize, tileSize);
                    gback.DrawImage(bmpTableLeft, rectDest, rect0, GraphicsUnit.Pixel);
                    map[(m), (n)] = 11;
                }
            }

            // cafe counter
            rectDest = new Rectangle(10 * tileSize, 11 * tileSize, tileSize, tileSize); // left endge of counter
            gback.DrawImage(bmpCounterLeftEdge, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (11)] = 12;

            rectDest = new Rectangle(11 * tileSize, 11 * tileSize, tileSize, tileSize); // left middle edge of counter
            gback.DrawImage(bmpCounterMiddleLeft, rectDest, rect0, GraphicsUnit.Pixel);
            map[(10), (11)] = 12;

            rectDest = new Rectangle(12 * tileSize, 11 * tileSize, tileSize, tileSize); // middle of counter
            gback.DrawImage(bmpCounterMiddle, rectDest, rect0, GraphicsUnit.Pixel);
            map[(12), (11)] = 12;

            rectDest = new Rectangle(13 * tileSize, 11 * tileSize, tileSize, tileSize); // middle right endge of counter
            gback.DrawImage(bmpCounterMiddleRight, rectDest, rect0, GraphicsUnit.Pixel);
            map[(13), (11)] = 12;

            rectDest = new Rectangle(14 * tileSize, 11 * tileSize, tileSize, tileSize); // right endge of counter
            gback.DrawImage(bmpCounterRightEdge, rectDest, rect0, GraphicsUnit.Pixel);
            map[(14), (11)] = 12;

            // rectDest to start out sprite outside of cafe
            rectDest = new Rectangle(16 * tileSize, 6 * tileSize, tileSize, tileSize);
            rectSource = new Rectangle(16 * tileSize, 6 * tileSize, tileSize, tileSize);

            // drawing out our girl outside of cafe
            gmini.DrawImage(backbuffer, rect0, rectDest, GraphicsUnit.Pixel);
            gback.DrawImage(bmpGirl, rectDest, rect0, GraphicsUnit.Pixel);

            // girl's current position
            curX = 16 * tileSize;
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
