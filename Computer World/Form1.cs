using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer_World
{
    public partial class Form1 : Form
    {
       // SqlConnection con = new SqlConnection("database=computer;server=.;uid=sa;pwd=1234");
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
