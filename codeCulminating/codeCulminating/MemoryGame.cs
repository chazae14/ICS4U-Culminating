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

        int level = 0;
        int enable = 0;
        Random rnd =new Random();

        List<int> sequence = new List<int>(); //Stores sequence for game
        Label[] myLabels; // Stores labels
        bool turn; // true if game is displaying sequence

        public MemoryGame()
        {
            InitializeComponent();         
            myLabels = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8 };// Labels in array
            Start();                                                                                          
        }
  
        // Display game sequence
        void Start_Game()
        {
            turn = true;

            Thread.Sleep(500);


            foreach (int x in sequence)
            {
                switch (x)
                {
                    case 0:
                        button1.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button1.BackColor = Color.Transparent;
                        break;
                    case 1:
                        button2.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button2.BackColor = Color.Transparent;
                        break;
                    case 2:
                        button3.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button3.BackColor = Color.Transparent;
                        break;
                    case 3:
                        button4.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button4.BackColor = Color.Transparent;
                        break;
                    case 4:
                        button5.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button5.BackColor = Color.Transparent;
                        break;
                    case 5:
                        button6.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button6.BackColor = Color.Transparent;
                        break;
                    case 6:
                        button7.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button7.BackColor = Color.Transparent;
                        break;
                    case 7:
                        button8.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button8.BackColor = Color.Transparent;
                        break;
                    case 8:
                        button9.BackColor = Color.Black;
                        Thread.Sleep(300);
                        button9.BackColor = Color.Transparent;
                        break;
                }
                Thread.Sleep(200);

            }

            turn = false;
        }

        // Check Player sequece 
        void Check_Sequence(int btn_clicked)
        {


            // make sure game sequence is done displaying and check if there is a game sequece
            if (turn == false && sequence.Count > 0)
            {
                // Game over if you click more buttons than in the sequence
                if (level >= sequence.Count())
                {
                    MessageBox.Show("Game Over! That was not in the sequence!");
                    level = 0;
                    sequence.Clear();
                    enable = 0;

                    // Reset level counter
                    for (int i = 0; i < myLabels.Count(); i++)
                    {
                        myLabels[i].BackColor = Color.Red;
                    }
                }
                // If button clicked is correct, add another level to check next button clicked
                else if(btn_clicked == sequence[level])
                {
                    level++;                    
                    myLabels[level - 1].BackColor = Color.Green;
                }
                // Game over if a wrong button is clicked
                else
                {
                    MessageBox.Show("Game Over!");
                    level = 0;
                    sequence.Clear();
                    enable = 0;

                    for (int i = 0; i < myLabels.Count(); i++)
                    {
                        myLabels[i].BackColor = Color.Red;
                    }
                }
                // Ends game if all levels cleared
                if (label8.BackColor == Color.Green)
                {
                    DialogResult choice = MessageBox.Show("Memory game complete.", "Win", MessageBoxButtons.OK);
                    LevelTwo.completedCount++;
                    if (choice == DialogResult.OK)
                    {
                        this.Close();
                    }
                }

            }

            // Enables start button 
            if (level == enable)
            {
                Start();
            }                  
        }


        // Add random number to sequence
        void Start()
        {
            sequence.Add(rnd.Next(0, 9));
            new Thread(Start_Game).Start();
            level = 0;
            enable++;

        }
   
        // When mouse down, turn button black
        private void Buttons_MouseDown(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.BackColor = Color.Black;
        }

        // when mouse up, turn button transparent
        private void Buttons_MouseUp(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.BackColor = Color.Transparent;
        }

        // Mouse click event for the buttons
        private void Buttons_MouseClick(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            
            int value = -1;

            // make value current button
            if (currentButton == button1)
            {
                value = 0;
            }
            if (currentButton == button2)
            {
                value = 1;
            }
            if (currentButton == button3)
            {
                value = 2;
            }
            if (currentButton == button4)
            {
                value = 3;
            }
            if (currentButton == button5)
            {
                value = 4;
            }
            if (currentButton == button6)
            {
                value = 5;
            }
            if (currentButton == button7)
            {
                value = 6;
            }
            if (currentButton == button8)
            {
                value = 7;           
            }
            if (currentButton == button9)
            {
                value = 8;                
            }

            // Make sure a button is clicked
            if (value != -1 )
            {
                // Send the current button clicked to check if is the correct sequence
                Check_Sequence(value);
            }
        }

    }
}
