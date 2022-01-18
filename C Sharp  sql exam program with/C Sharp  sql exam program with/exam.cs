using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace C_Sharp__sql_exam_program_with
{
    public partial class exam : Form
    {

        public exam()
        {
            InitializeComponent();
        }
        int minute = 9;
        int second = 60;
        static connection con1 = new connection();
        SqlConnection connection = new SqlConnection(con1.Adres);
        int point = 0;
        int counter = 0;
        public static string scor;
        private void fnsh_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            connection.Open();
            SqlCommand komut = new SqlCommand("update UserTable set puan='" + lpoint.Text + "' where us='" + scor + "'", connection);
            komut.Parameters.AddWithValue("puan", lpoint.Text);
            komut.ExecuteNonQuery();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conclusion s = new conclusion();
            this.Hide();
            s.Show();
        }

        private void examm_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            examm.Font = fontDialog1.Font;
            colorDialog1.ShowDialog();
            examm.ForeColor = colorDialog1.Color;
        }

        private void exam_Load(object sender, EventArgs e)
        {
            lblquestion.Text = counter.ToString();
            panel1.Visible = false;
            lbld.Visible = false;
            start.Enabled = false;
            button1.Enabled = false;
        }


        private void starttime_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            starttime.Enabled = false;
            start.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            if (second == 0)
            {
                second = 59;
                minute--;

                if (minute == -1)
                {

                    minute = 0;
                    second = 0;
                    min.Text = "0";
                    sec.Text = "0";
                    timer1.Stop();
                    panel1.Enabled = false;
                    MessageBox.Show("Your Time Has Expired !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }


            }
            min.Text = minute.ToString();
            sec.Text = second.ToString();
            progressBar1.Value--;
        }

        private void start_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            starttime.Text = "Next";
            start.Enabled = false;
            ba.Enabled = true;
            bb.Enabled = true;
            bc.Enabled = true;
            bd.Enabled = true;
            counter++;
            lblquestion.Text = counter.ToString();
            if (counter == 1)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }


                connection.Close();
            }
            if (counter == 2)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }


                connection.Close();
            }
            if (counter == 3)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }


                connection.Close();
            }
            if (counter == 4)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }


                connection.Close();
            }
            if (counter == 5)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }


                connection.Close();
            }
            if (counter == 6)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }


                connection.Close();
            }
            if (counter == 7)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }


                connection.Close();
            }
            if (counter == 8)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }


                connection.Close();
            }
            if (counter == 9)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }



                connection.Close();
            }
            if (counter == 10)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());



                }



                connection.Close();
            }
            if (counter == 11)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  * FROM soru ORDER BY NewID()", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    ba.Text = (rd["a"].ToString());
                    bb.Text = (rd["b"].ToString());
                    bc.Text = (rd["c"].ToString());
                    bd.Text = (rd["d"].ToString());
                    groupBox1.Text = (rd["soru"].ToString());
                    lbld.Text = (rd["doğrucevap"].ToString());
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    starttime.Enabled = false;


                }


                connection.Close();
            }
        }

        private void bb_Click(object sender, EventArgs e)
        {
            if (bb.Text == lbld.Text)
            {
                point += 10;
                lpoint.Text = point.ToString();
            }
            start.Enabled = true;
            ba.Enabled = false;
            bb.Enabled = false;
            bc.Enabled = false;
            bd.Enabled = false;
        }

        private void bc_Click(object sender, EventArgs e)
        {
            if (bc.Text == lbld.Text)
            {
                point += 10;
                lpoint.Text = point.ToString();
            }
            start.Enabled = true;
            ba.Enabled = false;
            bb.Enabled = false;
            bc.Enabled = false;
            bd.Enabled = false;
        }

        private void ba_Click(object sender, EventArgs e)
        {
            if (ba.Text == lbld.Text)
            {
                point += 10;
                lpoint.Text = point.ToString();
            }
            start.Enabled = true;
            ba.Enabled = false;
            bb.Enabled = false;
            bc.Enabled = false;
            bd.Enabled = false;
        }

        private void bd_Click(object sender, EventArgs e)
        {
            if (bd.Text == lbld.Text)
            {
                point += 10;
                lpoint.Text = point.ToString();
            }
            start.Enabled = true;
            ba.Enabled = false;
            bb.Enabled = false;
            bc.Enabled = false;
            bd.Enabled = false;
        }
    }
}
