using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ColourCircles
{
    public partial class Form1 : Form
    {
        const int max_count = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void addThread_Click(object sender, EventArgs e)
        {
      
  
        }


        private void removeThread_Click(object sender, EventArgs e)
        {

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorButton.BackColor = colorDialog1.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
        private void suspendButton_Click(object sender, EventArgs e)
        {

        }
        private void resumeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
