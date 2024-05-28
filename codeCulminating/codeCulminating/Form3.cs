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
            // nothing yet
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

        
    }
}
