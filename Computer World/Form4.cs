﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_World
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();    
            f.Show();
        }

        private void Form4_Click(object sender, EventArgs e)
        {

        }
    }
}
