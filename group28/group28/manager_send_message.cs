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
            string text = richTextB_text.Text.ToString();
            string toid = textB_toid.Text.ToString();
            string byid = LoginInfo.userid;
            if (text == "" || toid == "") { MessageBox.Show("you must enter a id you want to send for him and the text message"); }
            else
            {
                try
                {
                    connection.Open();
                    string query = "INSERT into messages([sender_id],[reciever_id],[Text])VALUES('" + byid + "','" + toid + "','" + text + "')";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Message Sended (-_-)");
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
        }

            private void manager_send_message_Load(object sender, EventArgs e)
        {

        }

        private void textB_toid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManagerZone man = new ManagerZone();
            StudentZone stu = new StudentZone();
            LecturerZone lec = new LecturerZone();
            this.Hide();
            string usera = LoginInfo.user;
            if (usera[0] == 's')
            {
                stu.Show();
            }
            if (usera[0] == 'l')
            {
                lec.Show();
            }
            if (usera[0] == 'm')
            {
                man.Show();
            }
        }
    }
}
