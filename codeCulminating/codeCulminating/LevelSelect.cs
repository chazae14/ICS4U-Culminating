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
using System.ComponentModel.Design;

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

        private void frmLevelSelect_Load(object sender, EventArgs e)
        {
            if (frmLevelOne.levelComplete == 1)
            {
                bnLevelTwoSelect.Show();
            }
        }
    }
}
