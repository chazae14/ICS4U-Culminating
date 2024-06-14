using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


        string userInput = " "; // Stores user input
        string correctCode = "1420"; // Stores correct code - only make up to 4 digits
        public static int combCode = 0;

        // Add Numbers to text box
        private void Buttons_MouseClick(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;

            // Add number only up to 4 digits
            if(userInput.Length < 4)
            {
                txtCombination.Text += currentButton.Text;
                userInput = txtCombination.Text;
            }          
        }

        // Delete button event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete one digit in text box at a time and update user input
            if ((String.Compare(txtCombination.Text, " ") < 0))
            {
                txtCombination.Text = txtCombination.Text.Substring(0, txtCombination.Text.Length - 1 + 1);
                userInput = txtCombination.Text;
            }
            else
            {
                txtCombination.Text = txtCombination.Text.Substring(0, txtCombination.Text.Length - 1);
                userInput = txtCombination.Text;
            }

            // if text box has nothing, then userInput is nothing
            if (txtCombination.Text.Length == 0)
            {
                userInput = "";
            }
        }

        // Check if userInput is correct
        private void btnEnter_Click(object sender, EventArgs e)
        {
            userInput = txtCombination.Text;

            // If correct, exit window, else shake screen
            if (userInput == correctCode)
            {
                frmLevelOne.compCount+=2;
                this.Close();
            }
            else
            {
                Shake(this);
            }
        }

        //Shake screen code
        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(500);
            const int shake_amplitude = 5;
            for (int i = 0; i < shake_amplitude; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
        }

        private void CombinationLock_Load(object sender, EventArgs e)
        {

        }
    }
}
