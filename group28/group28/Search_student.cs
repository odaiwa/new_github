using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group28
{
    public partial class Search_student : Form
    {
        public Search_student()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void Search_student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database23DataSet.student);

        }

        private void btn_search_lec_Click(object sender, EventArgs e)
        {
            string id = string.Format(textB_id.Text);

            if (id == "") {
                MessageBox.Show("You Must Insert a Student ID !");
            }
            else
            {
                DataView dv = new DataView();
                dv.Table = database23DataSet.Tables[6];
                dv.RowFilter = "ID  = " + textB_id.Text;
                // dv.RowFilter = "departmentName  = " + "software";
                studentDataGridView.DataSource = dv;
            }
        }
    }
}
