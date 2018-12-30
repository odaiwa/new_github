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
    public partial class LecturerZone : Form
    {
        public Form1 asd3 = new Form1();
        public LecturerZone()
        {
            InitializeComponent();
        }

        private void LecturerZone_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            asd3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            lec_schedule llc = new lec_schedule();
            llc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            students_in_course sts = new students_in_course();
            sts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
