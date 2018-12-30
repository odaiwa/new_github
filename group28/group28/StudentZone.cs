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
        public Search_course asd = new Search_course();
        public Search_lecturer asd1 = new Search_lecturer();
        public EmailUpdate asd2 = new EmailUpdate();
        public Form1 asd3 = new Form1();

        public StudentZone()
        {
            InitializeComponent();
        }

        private void sch_stu_Click(object sender, EventArgs e)
        {
            Hide();
            schedule_student ss = new schedule_student();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            asd.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            asd3.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            asd1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            asd2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            View_Messages vm = new View_Messages();
            vm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            manager_send_message mm = new manager_send_message();
            mm.Show();
        }
    }
}
