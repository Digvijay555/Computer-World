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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("database=computer;server=.;uid=sa;pwd=1234");
        int counter = 0;
        public int timeleft;
        string d;
        string f;

        public Form6()
        {
            InitializeComponent();
        }

        public void show1(string s)
        {

            con.Open();

            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblQuestion.Text = dr.GetValue(0).ToString();
            }

            con.Close();

        }


        public void show2(string s)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblA.Text = dr.GetValue(0).ToString();
            }

            con.Close();

        }

        public void show3(string s)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblB.Text = dr.GetValue(0).ToString();
            }

            con.Close();

        }

        public void show4(string s)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblC.Text = dr.GetValue(0).ToString();
            }

            con.Close();

        }

        public void show5(string s)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblD.Text = dr.GetValue(0).ToString();
            }

            con.Close();

        }
        public void show6(string s)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblAnswer.Text = dr.GetValue(0).ToString();
            }

            con.Close();

        }


        private void lblA_Click(object sender, EventArgs e)
        {
            d = lblA.Text.Trim();
            f = lblAnswer.Text.Trim();

            //  bool g=string.Equals(d,f);

            if (string.Compare(d, f) == 0)
            {
                // lblA.BackColor = Color.Green;
                // MessageBox.Show("Right Answer");
                timer1.Stop();
                pictureBox1.Show();
                pictureBox2.Hide();

            }
            else
            {
                // lblA.BackColor = Color.Red;
                // MessageBox.Show("Wrong Answer");
                pictureBox2.Show();
                pictureBox1.Hide();
            }
        }

        private void lblB_Click(object sender, EventArgs e)
        {

            d = lblB.Text.Trim();
            f = lblAnswer.Text.Trim();

            if (string.Compare(d, f) == 0)
            {
                //  lblB.BackColor = Color.Green;
                // MessageBox.Show("Right Answer");
                timer1.Stop();
                pictureBox1.Show();
                pictureBox2.Hide();
            }
            else
            {
                // lblB.BackColor = Color.Red;
                //MessageBox.Show("Wrong Answer");
                pictureBox2.Show();
                pictureBox1.Hide();
            }
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            d = lblC.Text.Trim();
            f = lblAnswer.Text.Trim();

            if (string.Compare(d, f) == 0)
            {
                //lblC.BackColor = Color.Green;
                // MessageBox.Show("Right Answer");
                timer1.Stop();
                pictureBox1.Show();
                pictureBox2.Hide();
            }
            else
            {
                //lblC.BackColor = Color.Red;
                //MessageBox.Show("Wrong Answer");
                pictureBox2.Show();
                pictureBox1.Hide();
            }
        }

        private void lblD_Click(object sender, EventArgs e)
        {
            d = lblD.Text.Trim();
            f = lblAnswer.Text.Trim();

            if (string.Compare(d, f) == 0)
            {
                //lblD.BackColor = Color.Green;
                // MessageBox.Show("Right Answer");
                timer1.Stop();
                pictureBox1.Show();
                pictureBox2.Hide();
            }
            else
            {
                //lblD.BackColor = Color.Red;
                // MessageBox.Show("Wrong Answer");
                pictureBox2.Show();
                pictureBox1.Hide();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timeleft = 15;
            timer1.Start();
            show1("select question from gk where id=1");
            show2("select label from gk where id=1");
            show3("select labe2 from gk where id=1");
            show4("select labe3 from gk where id=1");
            show5("select labe4 from gk where id=1");
            show6("select anslabel from gk where id=1");

        }
       
        
        

        




        public void reset()
        {
            lblQuestion.Text = "";
            lblA.Text = "";
            lblB.Text = "";
            lblC.Text = "";
            lblD.Text = "";
            lblAnswer.Text = "";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblTimer.Text = "";
            timeleft = 15;
            timer1.Start();
            pictureBox1.Hide();
            pictureBox2.Hide();
            counter = counter + 1;
            int x = counter % 20;

            if (counter == 1)
            {
                show1("select question from gk where id=2");
                show2("select label from gk where id=2");
                show3("select labe2 from gk where id=2");
                show4("select labe3 from gk where id=2");
                show5("select labe4 from gk where id=2");
                show6("select anslabel from gk where id=2");
            }


            if (counter == 2)
            {
                show1("select question from gk where id=3");
                show2("select label from gk where id=3");
                show3("select labe2 from gk where id=3");
                show4("select labe3 from gk where id=3");
                show5("select labe4 from gk where id=3");
                show6("select anslabel from gk where id=3");
            }
            if (counter == 3)
            {
                show1("select question from gk where id=4");
                show2("select label from gk where id=4");
                show3("select labe2 from gk where id=4");
                show4("select labe3 from gk where id=4");
                show5("select labe4 from gk where id=4");
                show6("select anslabel from gk where id=4");
            }
            if (counter == 4)
            {
                show1("select question from gk where id=5");
                show2("select label from gk where id=5");
                show3("select labe2 from gk where id=5");
                show4("select labe3 from gk where id=5");
                show5("select labe4 from gk where id=5");
                show6("select anslabel from gk where id=5");
            }
            if (counter == 5)
            {
                show1("select question from gk where id=6");
                show2("select label from gk where id=6");
                show3("select labe2 from gk where id=6");
                show4("select labe3 from gk where id=6");
                show5("select labe4 from gk where id=6");
                show6("select anslabel from gk where id=6");
            }
            if (counter == 6)
            {
                show1("select question from gk where id=7");
                show2("select label from gk where id=7");
                show3("select labe2 from gk where id=7");
                show4("select labe3 from gk where id=7");
                show5("select labe4 from gk where id=7");
                show6("select anslabel from gk where id=7");
            }
            if (counter == 7)
            {
                show1("select question from gk where id=8");
                show2("select label from gk where id=8");
                show3("select labe2 from gk where id=8");
                show4("select labe3 from gk where id=8");
                show5("select labe4 from gk where id=8");
                show6("select anslabel from gk where id=8");
            }
            if (counter == 8)
            {
                show1("select question from gk where id=9");
                show2("select label from gk where id=9");
                show3("select labe2 from gk where id=9");
                show4("select labe3 from gk where id=9");
                show5("select labe4 from gk where id=9");
                show6("select anslabel from gk where id=9");
            }
            if (counter == 9)
            {
                show1("select question from gk where id=10");
                show2("select label from gk where id=10");
                show3("select labe2 from gk where id=10");
                show4("select labe3 from gk where id=10");
                show5("select labe4 from gk where id=10");
                show6("select anslabel from gk where id=10");
            }
            if (counter == 10)
            {
                show1("select question from gk where id=11");
                show2("select label from gk where id=11");
                show3("select labe2 from gk where id=11");
                show4("select labe3 from gk where id=11");
                show5("select labe4 from gk where id=11");
                show6("select anslabel from gk where id=11");
            }
            if (counter == 11)
            {
                show1("select question from gk where id=12");
                show2("select label from gk where id=12");
                show3("select labe2 from gk where id=12");
                show4("select labe3 from gk where id=12");
                show5("select labe4 from gk where id=12");
                show6("select anslabel from gk where id=12");
            }
            if (counter == 12)
            {
                show1("select question from gk where id=13");
                show2("select label from gk where id=13");
                show3("select labe2 from gk where id=13");
                show4("select labe3 from gk where id=13");
                show5("select labe4 from gk where id=13");
                show6("select anslabel from gk where id=13");
            }
            if (counter == 13)
            {
                show1("select question from gk where id=14");
                show2("select label from gk where id=14");
                show3("select labe2 from gk where id=14");
                show4("select labe3 from gk where id=14");
                show5("select labe4 from gk where id=14");
                show6("select anslabel from gk where id=14");
            }
            if (counter == 14)
            {
                show1("select question from gk where id=15");
                show2("select label from gk where id=15");
                show3("select labe2 from gk where id=15");
                show4("select labe3 from gk where id=15");
                show5("select labe4 from gk where id=15");
                show6("select anslabel from gk where id=15");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "";
           
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                lblTimer.Text = timeleft.ToString();
                if (timeleft == 0)
                {
                    Form7 f7 = new Form7();
                    this.Hide();
                    f7.Show();
                }
            }


        }
        
    }
}