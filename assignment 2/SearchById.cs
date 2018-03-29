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
    public partial class SearchById : Form
    {
        public SearchById()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader obj2 = File.OpenText("C:\\Users\\hamma\\Desktop\\students.txt");
            String input;
            input = textBox1.Text;
            do
            {
                if (obj2.ReadLine() == input)
                {
                    MessageBox.Show("Record found");
                    textBox2.Text=obj2.ReadLine();
                    textBox4.Text= obj2.ReadLine();
                    textBox3.Text=obj2.ReadLine();
                    textBox5.Text=obj2.ReadLine();
                    textBox6.Text = obj2.ReadLine();
                   
                }
                else
                {
                    MessageBox.Show("Sorry Record Is Not Found");
                    break;
                }
            } while (!obj2.EndOfStream);
            obj2.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
