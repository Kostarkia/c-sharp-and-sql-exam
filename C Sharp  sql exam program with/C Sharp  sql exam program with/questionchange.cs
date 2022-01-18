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
    public partial class questionchange : Form
    {
        public questionchange()
        {
            InitializeComponent();
        }
        static connection con1 = new connection();
        SqlConnection connection = new SqlConnection(con1.Adres);

        public void showdata(string data)
        {

            SqlDataAdapter r = new SqlDataAdapter(data, connection);
            DataSet dr = new DataSet();
            r.Fill(dr);
            dataGridView1.DataSource = dr.Tables[0];
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Question_Procedures se = new Question_Procedures();
            this.Hide();
            se.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand k = new SqlCommand("delete from soru where no=@no", connection);
            k.Parameters.AddWithValue("@no", textBox1.Text);
            k.ExecuteNonQuery();
            showdata("Select * From soru");
            connection.Close();
            textBox1.Clear();
        }

        private void list_Click(object sender, EventArgs e)
        {
            showdata("Select * From soru");
        }
    }
}
