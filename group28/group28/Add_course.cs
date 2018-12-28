using group28.Database23DataSetTableAdapters;
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
    public partial class Add_course : Form
    {
        CourseTableAdapter CTA = new CourseTableAdapter();
        public Add_course()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void Add_course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void add_corse_Click(object sender, EventArgs e)
        {

            string num = string.Format(textB_num.Text);
            string name = string.Format(textB_name.Text);
            string lec_id = string.Format(textB_lecid.Text);
            string lec_name = string.Format(textB_lecname.Text);
            string day = string.Format(textB_day.Text);
            string hour= string.Format(textB_hour.Text);
            string points = string.Format(textB_points.Text);
            int count = 0;
            int count2 = 0;
            if (num == "" || name == "" || lec_id == "" || lec_name == "" || day == "" || hour == "" || points == "") { MessageBox.Show("you must enter all information about course"); }
            for (int rows = 0; rows < (courseDataGridView.Rows.Count) - 1; rows++)
            {
                {
                    string value = courseDataGridView.Rows[rows].Cells[0].Value.ToString();
                    string lecid = courseDataGridView.Rows[rows].Cells[2].Value.ToString();
                    if (num == value)
                        count++;
                    if (lecid == lec_id)
                        count2++;
                }
            }
            if (count == 0 && count2 != 0)
            {
                database23DataSet.Course.AddCourseRow(textB_num.Text, textB_name.Text, textB_lecid.Text, textB_lecname.Text, textB_day.Text, textB_hour.Text, int.Parse(textB_points.Text));
                CTA.Update(database23DataSet);
                tableAdapterManager.UpdateAll(database23DataSet);
                MessageBox.Show("Success!");
            }
            else if (count != 0)
                MessageBox.Show("The Course Already Exist!");
            else if (count2 == 0)
                MessageBox.Show("This4  lecturer is not Exsit!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            ManagerZone mm = new ManagerZone();
            mm.Show();
        }
    }
}
