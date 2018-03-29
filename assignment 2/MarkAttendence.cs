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
    public partial class MarkAttendence : Form
    {
        public MarkAttendence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID;
            FileStream fs = new FileStream("C:\\Users\\hamma\\Desktop\\students.txt", FileMode.Open);
            StreamReader obj2 = new StreamReader(fs);
            Console.WriteLine("please enter the Id");
            ID = textBox1.Text;
            string num;
            while ((num = obj2.ReadToEnd()) != null)
            {
                if (num.Contains(ID))
                {
                    Console.WriteLine("found");
                    break;
                }
                else
                {
                    Console.WriteLine("not found");
                    break;
                }
                obj2.Close();
            }
            StreamWriter obj = File.AppendText("C:\\Users\\hamma\\Desktop\\attendance.txt");
            obj.WriteLine(ID);
            obj.Close();
            StreamWriter obj1 = File.AppendText("C:\\Users\\hamma\\Desktop\\attendance.txt");
            if(radioButton1.Checked==true)
            { obj1.WriteLine("p"); }
            if (radioButton2.Checked == true)
            { obj1.WriteLine("A"); }
            obj1.Close();

        }
    }
}
