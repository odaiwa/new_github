using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static group28.Form1;

namespace group28
{
    public partial class DeleteCourseStu : Form
    {
        public StudentZone asd = new StudentZone();
        public OleDbConnection conn = new OleDbConnection();

        public DeleteCourseStu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            asd.Show();
        }

        public void DeleteCourseStu_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
            string username1 = LoginInfo.userid;

            conn.Open();
            OleDbCommand sc = new OleDbCommand("select num_course from student_course WHERE id_student = " + username1 + "", conn);
            OleDbDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("num_course", typeof(string));
           // dt.Columns.Add("num_course", typeof(string));
            dt.Load(reader);

            comboBox1.ValueMember = "num_course";
            comboBox1.DisplayMember = "num_course";
            comboBox1.DataSource = dt;
            conn.Close();
        }
    }
}
