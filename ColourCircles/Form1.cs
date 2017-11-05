﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ColourCircles
{
    public partial class Form1 : Form
    {
        Thread windowThread = Thread.CurrentThread;
        
        BindingList<CircleDrawer> drawers = new BindingList<CircleDrawer>();
         
        public Form1()
        {
            InitializeComponent();

            listOfThreads.DataSource = drawers;
            listOfThreads.DisplayMember = "Name";
            comboBox1.Items.Add(ThreadPriority.Lowest);
            comboBox1.Items.Add(ThreadPriority.BelowNormal);
            comboBox1.Items.Add(ThreadPriority.Normal);
            comboBox1.Items.Add(ThreadPriority.AboveNormal);
            comboBox1.Items.Add(ThreadPriority.Highest);
            comboBox1.SelectedItem = ThreadPriority.Normal;

            comboBox2.Items.Add(ThreadPriority.Lowest);
            comboBox2.Items.Add(ThreadPriority.BelowNormal);
            comboBox2.Items.Add(ThreadPriority.Normal);
            comboBox2.Items.Add(ThreadPriority.AboveNormal);
            comboBox2.Items.Add(ThreadPriority.Highest);
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
            
            drawers.Add(circleDrawer);
            circleDrawer.Start();
        }


        private void removeThread_Click(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                drawer.End();
                drawer.waitEnd();
                drawers.Remove(drawer);
            }
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
                drawer.SetPriority(priority);
            }
        }

        private void listOfThreads_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedDrawer = listOfThreads.SelectedItem;
            if (selectedDrawer != null)
            {
                CircleDrawer drawer = selectedDrawer as CircleDrawer;
                comboBox1.SelectedItem = drawer.GetPriorty();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            drawers.Clear();//??????????????????? память бы почистить
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ThreadPriority priority = (ThreadPriority)comboBox2.SelectedItem;
            windowThread.Priority = priority;
        }
        





        //прикольчики
        private void catsButton_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\acer\Pictures\SlideShow\snoopy_11.jpg", true);
            Graphics g = this.CreateGraphics();
            g.DrawImage(image, new Point(300, 100));
            catsButton.Enabled = false;
            catsButton.Visible = false;
        }

        private void secretButton_Click(object sender, EventArgs e)
        {

            if (catsButton.Visible = true)
            {
                catsButton.Enabled = true;
                catsButton.Visible = true;
            }
            
        }
    }
}
