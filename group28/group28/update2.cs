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
    public partial class update2 : Form
    {
        public update2()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void update2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = string.Format(textB_num.Text);
            string day = string.Format(textB_day.Text);
            string hour = string.Format(textB_hour.Text);
            //int count = 0;
            for (int rows = 0; rows < (courseDataGridView.Rows.Count) - 1; rows++)
            {
                string value = courseDataGridView.Rows[rows].Cells[0].Value.ToString();
                if (num == value)
                {
                    courseDataGridView.Rows[rows].Cells[4].Value = day;
                    courseDataGridView.Rows[rows].Cells[5].Value = hour;
                }
            }
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }
    }
}
