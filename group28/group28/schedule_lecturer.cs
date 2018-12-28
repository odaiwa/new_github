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
    public partial class schedule_lecturer : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter sda;
        DataTable dt;

        public schedule_lecturer()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sda = new OleDbDataAdapter("SELECT Course_Name,day,Hour FROM lecturer,Course WHERE lecturer.ID='" + LoginInfo.userid + "'", connection);
            dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void schedule_lecturer_Load(object sender, EventArgs e)
        {

        }
    }
}
