using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace codeCulminating
{
    public partial class MemoryGame : Form
    {
        Button[] myButtons;
        List<int> myList;
        int[] myNums = new int[9];
        Random rnd = new Random();
        int turn = 1;
        bool guess = true;
        public MemoryGame()
        {
            InitializeComponent();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            myList = new List<int>();
            rnd = new Random();

            myButtons = new Button[] {button1,button2,button3,button4,button5,button6,button7,button8,button9};
            ;

            for (int n = 0; n < myButtons.Count(); n++)
            {
                
                myButtons[n].Click += new EventHandler(myButtons_Click);                
                myNums[n] = rnd.Next(0,9);
            }
            new Thread(Simon_Says).Start();
        }

        private void Simon_Says()
        {
            Thread.Sleep(150);


            for (int x = 0; x < turn; x++)
            {
                myButtons[myNums[x]].BackColor = Color.Black;
                Thread.Sleep(750);
                myButtons[myNums[x]].BackColor = Color.Transparent;
                Thread.Sleep(150);
            }
            
          
        }

        private void myButtons_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            for (int x = 0;x < turn; x++)
            {
                if (currentButton.Text == myNums[x].ToString())
                {
                    guess = true;                 
                }

                
            }
            if (guess)
            {
                turn++;
                new Thread(Simon_Says).Start();
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void myButtons_MouseDown(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.BackColor = Color.Black;          
        }

        private void myButtons_MouseUp(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.BackColor = Color.Transparent;
        }
    }
}
