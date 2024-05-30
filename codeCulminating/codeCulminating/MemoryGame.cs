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

        int score = 0;
        int level = 0;


        Random rnd =new Random();

        List<int> sequence = new List<int>();
        

        string correctSequence;
        string playerSequence;

        

        public MemoryGame()
        {
            InitializeComponent();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            sequence.Add(rnd.Next(0,9));
            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
