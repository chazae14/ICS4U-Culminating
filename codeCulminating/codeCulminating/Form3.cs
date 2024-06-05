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
    public partial class frmPause : Form
    {
        public frmPause()
        {
            InitializeComponent();
        }

        private void frmPause_Load(object sender, EventArgs e)
        {
            timerPause.Start();
        }

        // closes the pause menu
        private void btnResume_Click(object sender, EventArgs e)
        {
            timerClose.Start();
            while (Opacity < 0)
            {
            }
        }

        // closes the pause menu and re-opens the startscreen 
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerClose.Start();
            while (Opacity < 0)
            {
            }
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
        }

        // adds fade in animation effect when form is made
        private void timerPause_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timerPause.Stop();
            }
            Opacity += 0.1;
        }

        // adds fade out animation effect when form is closed
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                timerClose.Stop();
                this.Close();
            }
            Opacity -= 0.1;
        }
    }
}
