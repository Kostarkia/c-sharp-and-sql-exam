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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlCommand com;
        SqlDataReader r;
        int right = 3;
        static connection con1 = new connection();
        SqlConnection connection = new SqlConnection(con1.Adres);

        private void Login_Click(object sender, EventArgs e)
        {

            try
            {
                string u = k1.Text;
                string pass = k2.Text;

                connection.Open();

                com = new SqlCommand("Select * from UserTable where us='" + u + "' and Pass='" + pass + "' ", connection);
                r = com.ExecuteReader();
                if (r.Read() == true)
                {
                    conclusion.users = k1.Text;
                    exam.scor = k1.Text;
                    MessageBox.Show("Giriş Başarılı");
                    exam f3 = new exam();
                    f3.Show();
                    this.Hide();


                }
                else
                {

                    right--;
                    MessageBox.Show("Incorrect entry, your remaining right: " + right);
                    if (right == 0)
                    {
                        Application.Exit();

                    }

                    k1.Clear();
                    k2.Clear();
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("HATA = " + HATA.Message);
            }
            connection.Close();
        }
        private void signin_Click(object sender, EventArgs e)
        {
            signin f2 = new signin();
            f2.Show();
            this.Hide();
        }

        private void alogin_Click(object sender, EventArgs e)
        {
            string adminus = k3.Text;
            string adminpass = k4.Text;
            k1.Clear();
            k2.Clear();
            connection.Open();
            com = new SqlCommand("Select * from adminn where adminus='" + adminus + "' and adminpass='" + adminpass + "' ", connection);
            r = com.ExecuteReader();
            try
            {
                if (r.Read())
                {
                    MessageBox.Show("Giriş Başarılı");
                    adminpanel f3 = new adminpanel();
                    f3.Show();
                    this.Hide();

                }
                else
                {

                    right--;
                    MessageBox.Show("Incorrect entry, your remaining right: " + right);
                    if (right == 0)
                    {
                        Application.Exit();

                    }
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("HATA = " + HATA.Message);
            }
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            k2.PasswordChar = '*';
            k4.PasswordChar = '*';
        }
    }
}
