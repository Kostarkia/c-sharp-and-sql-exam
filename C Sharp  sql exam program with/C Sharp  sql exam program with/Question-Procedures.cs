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
    public partial class Question_Procedures : Form
    {
        public Question_Procedures()
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
        private void nxt_Click(object sender, EventArgs e)
        {
            questionchange sc = new questionchange();
            this.Hide();
            sc.Show();
        }

        private void send_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into soru values(@soru, @a,@b,@c,@d,@doğrucevap);", connection);
            komut.Parameters.AddWithValue("@soru", question.Text);
            komut.Parameters.AddWithValue("@a", a.Text);
            komut.Parameters.AddWithValue("@b", b.Text);
            komut.Parameters.AddWithValue("@c", c.Text);
            komut.Parameters.AddWithValue("@d", d.Text);
            komut.Parameters.AddWithValue("@doğrucevap", trueanswer.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminpanel f3 = new adminpanel();
            this.Hide();
            f3.Show();
        }
    }
}
