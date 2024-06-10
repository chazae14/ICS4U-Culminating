﻿using System;
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
    public partial class frmLevelSelect : Form
    {
        public frmLevelSelect()
        {
            InitializeComponent();
        }

        private void btnLevelOne_Click(object sender, EventArgs e)
        {
            frmLevelOne inGamescreen = new frmLevelOne();

            inGamescreen.Show();

            this.Close();
        }

        private void bnLevelTwoSelect_Click(object sender, EventArgs e)
        {
            LevelTwo inGamescreen = new LevelTwo();

            inGamescreen.Show();

            this.Close();
        }
    }
}
