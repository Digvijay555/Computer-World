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
    public partial class Form5 : Form
    {
        SqlConnection con=new SqlConnection("database=computer;server=.;uid=sa;pwd=1234");
        int counter = 0;
        public int timeleft;

        string d;
        string f;
        public Form5()
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
                lblQuestion1.Text = dr.GetValue(0).ToString();
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
                lblA2.Text = dr.GetValue(0).ToString();
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
                lblB3.Text = dr.GetValue(0).ToString();
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
                lblC4.Text = dr.GetValue(0).ToString();
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
                lblD5.Text = dr.GetValue(0).ToString();
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
                lblAnswer1.Text = dr.GetValue(0).ToString();
            }

            con.Close();

        }




        private void Form5_Load(object sender, EventArgs e)
        {
            timeleft = 15;
            timer1.Start();
            show1("select question from science where id=1");
            show2("select label1 from science where id=1");
            show3("select label2 from science where id=1");
            show4("select label3 from science where id=1");
            show5("select label4 from science where id=1");
            show6("select anslabel from science where id=1");
        }
        

        private void lblA2_Click(object sender, EventArgs e)
        {
            d = lblA2.Text.Trim();
            f = lblAnswer1.Text.Trim();

            //  bool g=string.Equals(d,f);

            if (string.Compare(d, f) == 0)
            {
                // lblA.BackColor = Color.Green;
                // MessageBox.Show("Right Answer");
                timer1.Stop();
                pictureBox3.Show();
                pictureBox4.Hide();

            }
            else
            {
                // lblA.BackColor = Color.Red;
                // MessageBox.Show("Wrong Answer");
                pictureBox4.Show();
                pictureBox3.Hide();
            }
        }
        
        private void lblB3_Click(object sender, EventArgs e)
        {
            d = lblB3.Text.Trim();
            f = lblAnswer1.Text.Trim();

            if (string.Compare(d, f) == 0)
            {
                //  lblB.BackColor = Color.Green;
                //MessageBox.Show("Right Answer");
                timer1.Stop();
                pictureBox3.Show();
                pictureBox4.Hide();
            }
            else
            {
                // lblB.BackColor = Color.Red;
                //MessageBox.Show("Wrong Answer");
                pictureBox4.Show();
                pictureBox3.Hide();
            }
        }

        private void lblC4_Click(object sender, EventArgs e)
        {
            d = lblC4.Text.Trim();
            f = lblAnswer1.Text.Trim();

            if (string.Compare(d, f) == 0)
            {
                //lblC.BackColor = Color.Green;
               // MessageBox.Show("Right Answer");
                timer1.Stop();
                pictureBox3.Show();
                pictureBox4.Hide();
            }
            else
            {
                //lblC.BackColor = Color.Red;
                //MessageBox.Show("Wrong Answer");
                pictureBox4.Show();
                pictureBox3.Hide();
            }
        }

        private void lblD5_Click(object sender, EventArgs e)
        {
            d = lblD5.Text.Trim();
            f = lblAnswer1.Text.Trim();

            if (string.Compare(d, f) == 0)
            {
                //lblD.BackColor = Color.Green;
               // MessageBox.Show("Right Answer");
                timer1.Stop();
                pictureBox3.Show();
                pictureBox4.Hide();
            }
            else
            {
                //lblD.BackColor = Color.Red;
                //MessageBox.Show("Wrong Answer");
                pictureBox4.Show();
                pictureBox3.Hide();
            }
        }

        public void reset()
        {
            lblQuestion1.Text = "";
            lblA2.Text = "";
            lblB3.Text = "";
            lblC4.Text = "";
            lblD5.Text = "";
            lblAnswer1.Text = "";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblTimer.Text = "";
            timeleft = 15;
            timer1.Start();
            pictureBox3.Hide();
            pictureBox4.Hide();
            counter = counter + 1;
            int x = counter % 15;

            if (counter == 1)
            {
                show1("select question from science where id=2");
                show2("select label1 from science where id=2");
                show3("select label2 from science where id=2");
                show4("select label3 from science where id=2");
                show5("select label4 from science where id=2");
                show6("select anslabel from science where id=2");
            }


            if (counter == 2)
            {
                show1("select question from science where id=3");
                show2("select label1 from science where id=3");
                show3("select label2 from science where id=3");
                show4("select label3 from science where id=3");
                show5("select label4 from science where id=3");
                show6("select anslabel from science where id=3");
            }
            if (counter == 3)
            {
                show1("select question from science where id=4");
                show2("select label1 from science where id=4");
                show3("select label2 from science where id=4");
                show4("select label3 from science where id=4");
                show5("select label4 from science where id=4");
                show6("select anslabel from science where id=4");
            }
            if (counter == 4)
            {
                show1("select question from science where id=5");
                show2("select label1 from science where id=5");
                show3("select label2 from science where id=5");
                show4("select label3 from science where id=5");
                show5("select label4 from science where id=5");
                show6("select anslabel from science where id=5");
            }
            if (counter == 5)
            {
                show1("select question from science where id=6");
                show2("select label1 from science where id=6");
                show3("select label2 from science where id=6");
                show4("select label3 from science where id=6");
                show5("select label4 from science where id=6");
                show6("select anslabel from science where id=6");
            }
            if (counter == 6)
            {
                show1("select question from science where id=7");
                show2("select label1 from science where id=7");
                show3("select label2 from science where id=7");
                show4("select label3 from science where id=7");
                show5("select label4 from science where id=7");
                show6("select anslabel from science where id=7");
            }
            if (counter == 7)
            {
                show1("select question from science where id=8");
                show2("select label1 from science where id=8");
                show3("select label2 from science where id=8");
                show4("select label3 from science where id=8");
                show5("select label4 from science where id=8");
                show6("select anslabel from science where id=8");
            }
            if (counter == 8)
            {
                show1("select question from science where id=9");
                show2("select label1 from science where id=9");
                show3("select label2 from science where id=9");
                show4("select label3 from science where id=9");
                show5("select label4 from science where id=9");
                show6("select anslabel from science where id=9");
            }
            if (counter == 9)
            {
                show1("select question from science where id=10");
                show2("select label1 from science where id=10");
                show3("select label2 from science where id=10");
                show4("select label3 from science where id=10");
                show5("select label4 from science where id=10");
                show6("select anslabel from science where id=10");
            }
            if (counter == 10)
            {
                show1("select question from science where id=11");
                show2("select label1 from science where id=11");
                show3("select label2 from science where id=11");
                show4("select label3 from science where id=11");
                show5("select label4 from science where id=11");
                show6("select anslabel from science where id=11");
            }
            if (counter == 11)
            {
                show1("select question from science where id=12");
                show2("select label1 from science where id=12");
                show3("select label2 from science where id=12");
                show4("select label3 from science where id=12");
                show5("select label4 from science where id=12");
                show6("select anslabel from science where id=12");
            }
            if (counter == 12)
            {
                show1("select question from science where id=13");
                show2("select label1 from science where id=13");
                show3("select label2 from science where id=13");
                show4("select label3 from science where id=13");
                show5("select label4 from science where id=13");
                show6("select anslabel from science where id=13");
            }
            if (counter == 13)
            {
                show1("select question from science where id=14");
                show2("select label1 from science where id=14");
                show3("select label2 from science where id=14");
                show4("select label3 from science where id=14");
                show5("select label4 from science where id=14");
                show6("select anslabel from science where id=14");
            }
            if (counter == 14)
            {
                show1("select question from science where id=15");
                show2("select label1 from science where id=15");
                show3("select label2 from science where id=15");
                show4("select label3 from science where id=15");
                show5("select label4 from science where id=15");
                show6("select anslabel from science where id=15");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
