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

namespace codeCulminating
{
    public partial class MemoryGame : Form
    {
        Button[] myButtons;
        List<int> myList;
        Random rnd = new Random();
        int turn = 0;
        public MemoryGame()
        {
            InitializeComponent();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            myList = new List<int>();
            rnd = new Random();
            myList.Add(rnd.Next(0,10));


            myButtons = new Button[] {button1,button2,button3,button4,button5,button6,button7,button8,button9};
            ;

            for (int n = 0; n < myButtons.Count(); n++)
            {
                myButtons[n].Text = "";
                myButtons[n].Click += new EventHandler(myButtons_Click);
            }


            

        }

        private void Simon_Says()
        {
            Thread.Sleep(150);

            foreach(int x in myList) 
            {
                switch (x)
                {
                    case 0:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break;
                    case 1:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break;
                    case 2:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break; 
                    case 3:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break;
                    case 4:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break;
                    case 5:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break;
                    case 6:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break;
                    case 7:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break;
                    case 8:
                        myButtons[x].BackColor = Color.Black;
                        Thread.Sleep(1000);
                        myButtons[x].BackColor = Color.Transparent;
                        break;
                }
            }
        }

        private void myButtons_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new Thread(Simon_Says).Start();
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
