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
    public partial class SearchByName : Form
    {
        public SearchByName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader obj2 = File.OpenText("C:\\Users\\hamma\\Desktop\\students.txt");
            String input;
            Console.WriteLine("please enter the id");
            input = textBox1.Text;
            do
            {
              
                if (obj2.ReadLine() == input)
                {
                    MessageBox.Show("Record found");
                    textBox4.Text= obj2.ReadLine();
                    textBox3.Text =obj2.ReadLine();
                   textBox5.Text=obj2.ReadLine();
                   textBox2.Text = obj2.ReadLine();
                }
                else
                {
                    MessageBox.Show("Sorry Record Is Not Found");
                    
                }
            } while (!obj2.EndOfStream);

        }

        private void SearchByName_Load(object sender, EventArgs e)
        {

        }
    }
}
