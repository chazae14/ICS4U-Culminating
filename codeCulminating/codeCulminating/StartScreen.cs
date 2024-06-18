using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codeCulminating
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        SoundPlayer titleMusic = new SoundPlayer();


        // When clicked open game window
        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMain inGamescreen = new frmMain();
            
            inGamescreen.Show();
            this.Hide();
            
        }
        
        // When clicked open Help window
        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            HelpScreen inHelpscreen = new HelpScreen();
            inHelpscreen.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnepilogue_Click(object sender, EventArgs e)
        {
            GoodEnding inGamescreen = new GoodEnding();
            inGamescreen.Show();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            titleMusic.SoundLocation = "Title_Music.wav";
            titleMusic.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Epilogue inGamescreen = new Epilogue();
            inGamescreen.Show();
        }
    }
}
