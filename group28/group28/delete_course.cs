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

namespace group28
{
    public partial class delete_course : Form
    {
        private OleDbConnection connection= new OleDbConnection();
        public delete_course()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = textB_num.Text.ToString();
            OleDbCommand command = new OleDbCommand("DELETE FROM [Course] WHERE Number=?", connection);
            {
                command.Parameters.AddWithValue("Number", id);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void delete_course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                label1.Text = "connected";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
