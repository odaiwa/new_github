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
    public partial class ManagerZone : Form
    {
        public ManagerZone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_student ss = new Search_student();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_course sc = new Search_course();
            sc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search_lecturer sl = new Search_lecturer();
            sl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_student asd = new Add_student();
            asd.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //  Update_course upcrs = new Update_course();
            // upcrs.Show();
            update2 up = new update2();
            up.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add_course adcrs = new Add_course();
            adcrs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_course dlcrs = new delete_course();
            dlcrs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manager_send_message mmn = new manager_send_message();
            mmn.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            View_Messages vm = new View_Messages();
            vm.Show();
        }
    }
}
