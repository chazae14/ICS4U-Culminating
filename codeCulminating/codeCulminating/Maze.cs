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
    public partial class Maze : Form
    {

        Point startLocation; // Holds start location
        int countDown = 0; // Used for game time
        public Maze()
        {
            InitializeComponent();
            Start();
        }

        // Put cursor in start position and Start countdown
        private void Start()
        {
            GameTime.Start();
            startLocation = lblStart.Location;
            Cursor.Position = PointToScreen(startLocation);
            countDown = 45;
        }
  
        // When cursur hits a wall, reset its position to the start
        private void MazeWall_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(startLocation);
        }

        // Game timer
        private void GameTime_Tick(object sender, EventArgs e)
        {
            // Check if game time is 0
            if (countDown < 0)
            {
                GameTime.Stop();
                // Ask if player wants to continue
                DialogResult choice = MessageBox.Show("You're out of time\nTry again?","Fail", MessageBoxButtons.YesNo);
                
                // If yes, restart maze, else, close window
                if(choice == DialogResult.Yes)
                {
                    Start();
                }
                else
                {
                    this.Close();
                }
            }

            lblTime.Text = countDown.ToString();
            countDown--;
        }

        // End Game
        private void lblEnd_MouseEnter(object sender, EventArgs e)
        {
            GameTime.Stop();
            DialogResult choice = MessageBox.Show("Maze complete.", "Win`", MessageBoxButtons.OK);
            if (choice == DialogResult.OK) 
            {
                this.Close();
            }
        }
    }
}
