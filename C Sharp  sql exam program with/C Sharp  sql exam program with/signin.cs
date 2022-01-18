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

namespace C_Sharp__sql_exam_program_with
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }
        static connection con1 = new connection();
        SqlConnection connection = new SqlConnection(con1.Adres);
        public void clear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }
        private void signup_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into UserTable (us,Pass,ad,soyad,yas,puan) values(@us,@Pass,@ad,@soyad,@yas,0);", connection);
            komut.Parameters.AddWithValue("@us", txtusername.Text);
            komut.Parameters.AddWithValue("@Pass", password.Text);
            komut.Parameters.AddWithValue("@ad", txtname.Text);
            komut.Parameters.AddWithValue("@soyad", txtsurname.Text);
            komut.Parameters.AddWithValue("@yas", txtage.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void signin_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
    }
}
