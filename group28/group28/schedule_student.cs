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
    public partial class schedule_student : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter sda;
        DataTable dt;

        public schedule_student()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sda = new OleDbDataAdapter("SELECT Name,day,Hour,lecturerName FROM Course,student,student_course WHERE student_course.StudentID='"+ LoginInfo.userid + "' AND Course.Number=student_course.Course_Number", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0;i < dataGridView1.Rows.Count; i++){
                int k = 0;
                for (int j = 0; j < (dataGridView1.Rows.Count)-1; j++)
                {
                    string v1 = dataGridView1.Rows[i].Cells["Name"].Value.ToString();
                    string v2 = dataGridView1.Rows[j].Cells["Name"].Value.ToString();
                    if (v1==v2)
                    {
                        if (k != 0)
                        {
                            dt.Rows.RemoveAt(j);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    k++;
                }
            }
            dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void schedule_student_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
