using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student obj = new Add_Student();
            obj.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteStudent obj1 = new deleteStudent();
            obj1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search obj2 = new Search();
            obj2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkAttendence obj = new MarkAttendence();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewAttendance obj = new viewAttendance();
            obj.Show();
        }
    }
}
