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
    public partial class StudentZone : Form
    {
        public StudentZone()
        {
            InitializeComponent();
        }

        private void sch_stu_Click(object sender, EventArgs e)
        {
            schedule_student ss = new schedule_student();
            ss.Show();
        }
    }
}
