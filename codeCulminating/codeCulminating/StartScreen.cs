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
using WMPLib;
using static System.Net.WebRequestMethods;

namespace codeCulminating
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            audPlayer.URL = "Title_Music.mp3";
        }


        // When clicked open game window
        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMain inGamescreen = new frmMain();
            inGamescreen.Show();
            audPlayer.Ctlcontrols.pause();
        }
        
        // When clicked open Help window
        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            HelpScreen inHelpscreen = new HelpScreen();
            inHelpscreen.Show();
        }

        private void btnMazeGame_Click(object sender, EventArgs e)
        {
            Maze inMazeGame = new Maze();
            inMazeGame.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            audPlayer.Hide();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.05;
            if (Opacity == 100)
            {
                timer1.Stop();

            }
        }
    }
}
