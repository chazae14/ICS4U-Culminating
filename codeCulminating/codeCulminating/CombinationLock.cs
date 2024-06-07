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
    public partial class CombinationLock : Form
    {
        public CombinationLock()
        {
            InitializeComponent();
        }

        string userInput;


        private void Buttons_MouseClick(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;

            userInput += currentButton.Text;

            txtCombination.Text = userInput;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

    }
}
