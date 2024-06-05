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
using System.Data.SqlTypes;

namespace codeCulminating
{
    public partial class MemoryGame : Form
    {

        int score = 0;
        int level = 0;


        Random rnd =new Random();

        List<int> sequence = new List<int>();
        List<int> playerSequence = new List<int>();
        bool check = false;
        bool turn;

        string correctSequence;
        

        

        public MemoryGame()
        {
            InitializeComponent();
        }


        void Start_Game()
        {
            turn = true;

            Thread.Sleep(150);


            foreach (int x in sequence)
            {
                switch (x)
                {
                    case 0:
                        button1.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button1.BackColor = Color.Transparent;
                        break;
                    case 1:
                        button2.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button2.BackColor = Color.Transparent;
                        break;
                    case 2:
                        button3.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button3.BackColor = Color.Transparent;
                        break;
                    case 3:
                        button4.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button4.BackColor = Color.Transparent;
                        break;
                    case 4:
                        button5.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button5.BackColor = Color.Transparent;
                        break;
                    case 5:
                        button6.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button6.BackColor = Color.Transparent;
                        break;
                    case 6:
                        button7.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button7.BackColor = Color.Transparent;
                        break;
                    case 7:
                        button8.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button8.BackColor = Color.Transparent;
                        break;
                    case 8:
                        button9.BackColor = Color.Black;
                        Thread.Sleep(150);
                        button9.BackColor = Color.Transparent;
                        break;
                }
                Thread.Sleep(150);

            }

            turn = false;
        }

        void Check_Sequence(int btn_clicked)
        {
            
            if (turn == false && sequence.Count > 0)
            {
                if (level >= sequence.Count())
                {
                    MessageBox.Show("Game Over! That was not in the sequence!");
                    level = 0;
                    sequence.Clear();
                }
                else if(btn_clicked == sequence[level])
                {
                    level++;
                }
                else
                {
                    MessageBox.Show("Game Over!");
                    level = 0;
                    sequence.Clear();
                }
                
            }
       
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            sequence.Add(rnd.Next(0, 9));           
            new Thread(Start_Game).Start();
            level = 0;
        }

        private void Buttons_MouseDown(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.BackColor = Color.Black;
        }

        private void Buttons_MouseUp(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.BackColor = Color.Transparent;
        }

        private void Buttons_MouseClick(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            
            int value = -1;


            if (currentButton == button1)
            {
                value = 0;
                playerSequence.Add(value);
            }
            if (currentButton == button2)
            {
                value = 1;
                playerSequence.Add(value);
            }
            if (currentButton == button3)
            {
                value = 2;
                playerSequence.Add(value);
            }
            if (currentButton == button4)
            {
                value = 3;
                playerSequence.Add(value);
            }
            if (currentButton == button5)
            {
                value = 4;
                playerSequence.Add(value);
            }
            if (currentButton == button6)
            {
                value = 5;
                playerSequence.Add(value);
            }
            if (currentButton == button7)
            {
                value = 6;
                playerSequence.Add(value);
            }
            if (currentButton == button8)
            {
                value = 7;
                playerSequence.Add(value);
            }
            if (currentButton == button9)
            {
                value = 8;
                playerSequence.Add(value);
            }

            if (value != -1 )
            {
                check = true;
                Check_Sequence(value);
            }
        }
    }
}
