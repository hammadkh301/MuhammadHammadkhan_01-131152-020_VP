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
    public partial class viewAttendance : Form
    {
        public viewAttendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         StreamReader obj = File.OpenText("C:\\Users\\hamma\\Desktop\\attendance.txt");
        do
        {
            string input;
            input = textBox1.Text;
            
            if (input ==obj.ReadLine())
            {
                textBox2.Text = obj.ReadLine();
            }
            else
            {
                MessageBox.Show("not found");
            }
            
        } while (!obj.EndOfStream);
        obj.Close();
    }

        }
    }
