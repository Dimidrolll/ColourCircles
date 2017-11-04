using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ColourCircles
{
    public partial class Form1 : Form
    {
        BindingList<CircleDrawer> drawers = new BindingList<CircleDrawer>();
         
        public Form1()
        {
            InitializeComponent();

            listOfThreads.DataSource = drawers;
            listOfThreads.DisplayMember = "Name";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void addThread_Click(object sender, EventArgs e)
        {
            CircleTemlate circleTemlate = new CircleTemlate(colorDialog1.Color, (int) nudRadius.Value);
            CircleDrawer circleDrawer = new CircleDrawer(circleTemlate, (int) nudRefreshInt.Value, CreateGraphics());
            drawers.Add(circleDrawer);
            circleDrawer.Start();
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
            foreach (var drawer in drawers)
            {
                drawer.End();
                drawer.waitEnd();
            }
        }
        private void suspendButton_Click(object sender, EventArgs e)
        {

        }
        private void resumeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
