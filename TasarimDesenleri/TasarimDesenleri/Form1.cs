﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasarimDesenleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(300,500);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.sninja;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pastane pastaneform = new pastane();
            pastaneform.Show();
            this.Hide();
        }
    }
}
