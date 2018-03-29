using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assignment_2
{
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\hamma\\Desktop\\students.txt", FileMode.Append);
            StreamWriter obj1 = new StreamWriter(fs);
            obj1.WriteLine(textBox1.Text);
            obj1.WriteLine(textBox2.Text);
            obj1.WriteLine(textBox4.Text);
            obj1.WriteLine(textBox3.Text);
            obj1.WriteLine(textBox5.Text);
            obj1.WriteLine(textBox6.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            obj1.Close();

        }
    }
}
