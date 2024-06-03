﻿using System;
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
            this.Close();
        }

        // closes the pause menu and re-opens the startscreen 
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
        }

        private void btnMusicCont_Click(object sender, EventArgs e)
        {

        }

        private void timerPause_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
        }
    }
}
