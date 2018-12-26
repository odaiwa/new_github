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
    public partial class Search_lecturer : Form
    {
        public Search_lecturer()
        {
            InitializeComponent();
        }

        private void lecturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void Search_lecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.database23DataSet.lecturer);

        }

        private void btn_search_lecc_Click(object sender, EventArgs e)
        {
            string id = string.Format(textB_id_lec.Text);

            if (id == "")
            {
                MessageBox.Show("You Must Insert an id lecturer!");
            }
            else
            {
                DataView dv = new DataView();
                dv.Table = database23DataSet.Tables[2];
                dv.RowFilter = "ID  = " + textB_id_lec.Text;
                lecturerDataGridView.DataSource = dv;
            }
        }
    }
}
