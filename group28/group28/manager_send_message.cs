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
    public partial class manager_send_message : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        public manager_send_message()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database23.mdb;
Persist Security Info=False;";
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string byid = textB_byid.Text;
                string toid = textB_toid.Text.ToString();
                string text = richTextB_text.Text.ToString();
                string query = "INSERT into messages([sender_id],[reciever_id],[Text])VALUES('" + byid + "','" + toid + "','" + text + "')";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void manager_send_message_Load(object sender, EventArgs e)
        {

        }
    }
}
