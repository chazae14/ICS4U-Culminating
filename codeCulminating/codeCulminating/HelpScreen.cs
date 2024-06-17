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
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();

            

        }

        // Close Help screen
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
