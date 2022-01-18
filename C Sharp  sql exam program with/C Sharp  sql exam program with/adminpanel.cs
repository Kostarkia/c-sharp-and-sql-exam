using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp__sql_exam_program_with
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        private void mt_Click(object sender, EventArgs e)
        {
            Member_Transactions f4 = new Member_Transactions();
            this.Hide();
            f4.Show();
        }

        private void qp_Click(object sender, EventArgs e)
        {
            Question_Procedures f5 = new Question_Procedures();
            this.Hide();
            f5.Show();
        }
    }
}
