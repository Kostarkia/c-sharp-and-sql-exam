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
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Drawing.Printing;

namespace C_Sharp__sql_exam_program_with
{
    public partial class conclusion : Form
    {
        public conclusion()
        {
            InitializeComponent();
        }
        private Button printButton = new Button();
        public static string users;
        Bitmap btm;
        static connection con1 = new connection();
        SqlConnection connection = new SqlConnection(con1.Adres);

        private void button_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            btm = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(btm);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void conclusion_Load(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand k = new SqlCommand("select * from UserTable where us=@p1", connection);
            k.Parameters.AddWithValue("@p1", users);
            SqlDataReader d = k.ExecuteReader();
            while (d.Read())
            {

                username.Text = d[3].ToString();
                lbls.Text = d[4].ToString();
                lblage.Text = d[5].ToString();
                puan2.Text = d[6].ToString();

            }
            connection.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(btm, 0, 0);
        }
    }
}
