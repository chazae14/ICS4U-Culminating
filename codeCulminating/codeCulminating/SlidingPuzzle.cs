using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace codeCulminating
{
    public partial class SlidingPuzzle : Form
    {
        Point EmptyPoint;
        ArrayList images = new ArrayList(); // stores croped image
        frmGraphics frmG =new frmGraphics(); // get image from form2
        public static int slideCode = 0; // variable to inform what mini-game was completed to check off right box
        public SlidingPuzzle()
        {
            InitializeComponent();
            EmptyPoint.X = 180;
            EmptyPoint.Y = 180;

            foreach (Button b in panel1.Controls)
            {
                b.Enabled = true;
            }

            Image orginal = frmG.picSlidingGame.Image; // Get original image

            cropImage(orginal, 270, 270); // crop image to fit buttons

            AddImage(images); // add images to buttons
        }

        // Add images to buttons
        private void AddImage(ArrayList images)
        {
            int i = 0;
            int[] myButtons = { 0, 1, 2, 3, 4, 5, 6, 7, };

            myButtons = shuffle(myButtons); // shuffle randomly the images

            // Add each image to buttons in panel
            foreach(Button b in panel1.Controls)
            {
                if ( i < myButtons.Length)
                {
                    b.Image = (Image)images[myButtons[i]];
                    i++;
                }
            }
        }

        // Get random sequence
        private int[] shuffle(int[] myButtons)
        {
            Random rnd = new Random();
            myButtons = myButtons.OrderBy(x => rnd.Next()).ToArray();

            return myButtons;
        }

        // Crop images
        private void cropImage(Image orginal, int w, int h)
        {
            Bitmap bmpImage = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmpImage); // Get original image

            g.DrawImage(orginal, 0, 0, w, h);

            g.Dispose();

            int movr = 0, movd = 0;

            // Get 8 croped pieces from image
            for (int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(90, 90);

                for (int i = 0; i < 90; i++)
                {
                    for (int j = 0; j < 90; j++)
                    {
                        piece.SetPixel(i,j, bmpImage.GetPixel(i + movr,j + movd));
                    }
                }

                images.Add(piece); // add croped pieces to array


                movr += 90; // Do 1st row first

                if (movr == 270) // then move down
                {
                    movr = 0;
                    movd += 90;
                }
            }
        }

        // Button click event
        private void Buttons_MouseClick(object sender, MouseEventArgs e)
        {
            MoveButton((Button)sender); // Move buttons
        }
        private void MoveButton(Button btn)
        {
            // check if there is a empty space next to the button, if so then swap
            if (((btn.Location.X == EmptyPoint.X - 90 || btn.Location.X == EmptyPoint.X + 90) && btn.Location.Y == EmptyPoint.Y) 
                || (btn.Location.Y == EmptyPoint.Y - 90 || btn.Location.Y == EmptyPoint.Y + 90) && btn.Location.X == EmptyPoint.X)
            {
                // Swap
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = swap;
            }

            // Check if puzzle complete
            if (EmptyPoint.X == 180 && EmptyPoint.Y == 180)
            {
                CheckValid();
            }
        }
        
        // check if puzzle is complete
        private void CheckValid()
        {
            int count = 0, index;


            foreach(Button btn in panel1.Controls)
            {
                index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90;
                
                if (images[index] == btn.Image)
                {
                    count++;
                }
            }

            // Show message box if puzzle complete
            if (count == 8)
            {
                DialogResult choice = MessageBox.Show("Sliding puzzle complete.", "Win", MessageBoxButtons.OK);
                frmLevelOne.compCount++;
                slideCode++;
                if (choice == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
