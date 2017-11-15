using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ColourCircles
{
    public partial class Form1 : Form
    {
        readonly BindingList<CircleDrawer> _drawers = new BindingList<CircleDrawer>();

        public Form1()
        {
            InitializeComponent();

            listOfThreads.DataSource = _drawers;
            listOfThreads.DisplayMember = "Name";

            object[] threadPriorities = {
                ThreadPriority.Lowest, ThreadPriority.BelowNormal, ThreadPriority.Normal, ThreadPriority.AboveNormal,
                ThreadPriority.Highest
            };
            comboBox1.Items.AddRange(threadPriorities);
            comboBox1.SelectedItem = ThreadPriority.Normal;

            comboBox2.Items.AddRange(threadPriorities);
            comboBox2.SelectedItem = ThreadPriority.Normal;

            catsButton.Enabled = false;
            catsButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addThread_Click(object sender, EventArgs e)
        {
            CircleTemlate circleTemlate = new CircleTemlate(colorDialog1.Color, (int) nudRadius.Value);
            CircleDrawer circleDrawer = new CircleDrawer(circleTemlate, (int) nudRefreshInt.Value, CreateGraphics());

            _drawers.Add(circleDrawer);           
            circleDrawer.Start();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listOfThreads.ClearSelected();
        }

        private void removeThread_Click(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                drawer.End();
                drawer.WaitEnd();
                _drawers.Remove(drawer);
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorButton.BackColor = colorDialog1.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var drawer in _drawers)
            {
                drawer.End();
                drawer.WaitEnd();
            }
        }

        private void suspendButton_Click(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                drawer.Stop();
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                drawer.Resume();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                ThreadPriority priority = (ThreadPriority) comboBox1.SelectedItem;
                drawer.Priority = priority;
            }
        }

        private void listOfThreads_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                comboBox1.SelectedItem = drawer.Priority;
                nudRadius.Value = drawer.GetRadius();
                nudRefreshInt.Value = drawer.GetRef();
                colorButton.BackColor = drawer.GetColor();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _drawers.Clear();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ThreadPriority priority = (ThreadPriority) comboBox2.SelectedItem;
            Thread.CurrentThread.Priority = priority;
        }

        private void nudRadius_ValueChanged(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                drawer.ChangeRadius((int)nudRadius.Value);
            }
        }

        private void nudRefreshInt_ValueChanged(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                drawer.ChangeRef((int)nudRefreshInt.Value);
            }
        }

        private void colorButton_BackColorChanged(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                Color color = colorButton.BackColor;
                drawer.ChangeColor(color);
                //drawer.Name = drawer._circleTemplate.Colour.ToString();


            }
        }








        //прикольчики
        private void catsButton_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@".\snoopy_11.jpg", true);
            Graphics g = CreateGraphics();
            g.DrawImage(image, new Point(300, 100));
            catsButton.Enabled = false;
            catsButton.Visible = false;
        }

        private void secretButton_Click(object sender, EventArgs e)
        {
            if (!catsButton.Visible)
            {
                catsButton.Enabled = true;
                catsButton.Visible = true;
            }
        }

        
    }
}