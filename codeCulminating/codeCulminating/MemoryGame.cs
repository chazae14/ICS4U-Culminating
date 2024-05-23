using System;
using System.CodeDom;
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
    public partial class MemoryGame : Form
    {
        Button[] myButtons;
        Random rnd = new Random();
        int turn = 9;
        public MemoryGame()
        {
            InitializeComponent();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            myButtons = new Button[] {button1,button2,button3,button4,button5,button6,button7,button8,button9};

            for (int n = 0; n < myButtons.Count(); n++)
            {
                myButtons[n].Text = "";
                myButtons[n].Click += new EventHandler(myButtons_Click);
            }

        }

        private void myButtons_Click(object sender, EventArgs e)
        {
            
        }
    }
}
