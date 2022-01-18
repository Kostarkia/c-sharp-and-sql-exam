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
    public partial class Member_Transactions : Form
    {
        public Member_Transactions()
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
        private void return3_Click(object sender, EventArgs e)
        {
            adminpanel ad = new adminpanel();
            this.Hide();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showdata("Select * From UserTable");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand k = new SqlCommand("delete from UserTable where ad=@adi", connection);
            k.Parameters.AddWithValue("@adi", textBox1.Text);
            k.ExecuteNonQuery();
            showdata("Select * From UserTable");
            connection.Close();
            textBox1.Clear();
        }

        private void search_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable tab = new DataTable();
            string search, cumle;
            search = textBox1.Text;
            cumle = " Select * from UserTable where ad like'%" + textBox1.Text + "%' ";
            SqlDataAdapter r = new SqlDataAdapter(cumle, connection);
            r.Fill(tab);
            connection.Close();
            dataGridView1.DataSource = tab;
        }
    }
}
