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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMain inGamescreen = new frmMain();
            
            inGamescreen.Show();
            Hide();
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            HelpScreen inHelpscreen = new HelpScreen();
            inHelpscreen.Show();
        }
    }
}
