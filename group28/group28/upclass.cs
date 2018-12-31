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
    public partial class upclass : Form
    {
        public upclass()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void upclass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = string.Format(textB_num.Text);
            string classs = string.Format(textB_class.Text);
            for (int rows = 0; rows < (courseDataGridView.Rows.Count) - 1; rows++)
            {
                string value = courseDataGridView.Rows[rows].Cells[0].Value.ToString();
                if (num == value)
                {
                    courseDataGridView.Rows[rows].Cells[2].Value = classs;
                }
            }
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);
        }
    }
}
