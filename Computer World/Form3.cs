using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_World
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btncomputer_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.Show();
            f8.btn1.Show();
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.Show();
            f8.btn3.Show();
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

         }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.Show();
            f8.btn2.Show();
            
        }

       
       
    }
}
