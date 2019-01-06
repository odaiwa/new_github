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
using System.Configuration;


namespace group28
{
    public partial class DeleteCourseStu : Form
    {
        public StudentZone asd = new StudentZone();
   //     public OleDbConnection conn = new OleDbConnection();
        private OleDbConnection connection = new OleDbConnection();

        public DeleteCourseStu()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            asd.Show();
        }

        public void DeleteCourseStu_Load(object sender, EventArgs e)
        {
        //    dataGridView1.DataSource = GitCourses();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username1 = LoginInfo.userid;
            string id = textBox1.Text.ToString();

            /*
            string id = textBox1.Text.ToString();
            if (id == "") { MessageBox.Show("you must insert a course number"); }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from student_course where StudentID='" + username1 + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    command = new OleDbCommand("DELETE FROM [StudentID] WHERE Number=?", connection);
                    {
                        command.Parameters.AddWithValue("Number", id);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("The Course Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    MessageBox.Show("Incorrect");
                }
                connection.Close();
            */

            connection.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM student_course WHERE Course_Number = '" + id + "'AND StudentID = '"+username1+"'", connection);
            cmd.ExecuteNonQuery();
            OleDbCommand cmd1 = new OleDbCommand("DELETE FROM StudentInCourse WHERE num_course = '" + id + "'AND id_student = '" + username1 + "'", connection);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }
        //private DataTable GitCourses()
        //{
        /*
        DataTable Dtcourse = new DataTable();
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        using (OleDbConnection mm = new OleDbConnection(connstring))
        {
            using (OleDbCommand cmd = new OleDbCommand("Select Course_Number from student_course", mm))
            {
                mm.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                Dtcourse.Load(reader);

            }
        }
            return Dtcourse;
*/
        //}
    }
}
