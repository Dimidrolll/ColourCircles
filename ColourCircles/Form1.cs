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
        int count_of_threads = -1;
        CircleTemlate[] circleTemplate = new CircleTemlate[max_count];
        CircleDrawer[] circleDrawer = new CircleDrawer[max_count];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void addThread_Click(object sender, EventArgs e)
        {
            ++count_of_threads;
            Graphics g = this.CreateGraphics();
            circleTemplate[count_of_threads] = new CircleTemlate(colorDialog1.Color, (int)nudRadius.Value);
            circleDrawer[count_of_threads] = new CircleDrawer(circleTemplate[count_of_threads], (int)nudRefreshInt.Value, g);

            circleDrawer[count_of_threads].thread.Name = circleTemplate[count_of_threads].color.Name;
            listOfThreads.Items.Add(circleDrawer[count_of_threads]);

            circleDrawer[count_of_threads].Start();
        }


        private void removeThread_Click(object sender, EventArgs e)
        {
            if (listOfThreads.SelectedIndex != -1)
            {
             
                --count_of_threads;

            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorButton.BackColor = colorDialog1.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*for (int i = 0; i < count_of_threads; ++i)
            {
                circleDrawer[i].End();
                circleDrawer[i].waitEnd();
            }*/

        }
        private void suspendButton_Click(object sender, EventArgs e)
        {
            if (listOfThreads.SelectedIndex != -1)
            {
                int temp = listOfThreads.SelectedIndex;
                circleDrawer[count_of_threads].Stop();
            }
        }
        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (listOfThreads.SelectedIndex != -1)
            {
                int temp = listOfThreads.SelectedIndex;
                circleDrawer[count_of_threads].Resume();
            }
        }
    }
}
