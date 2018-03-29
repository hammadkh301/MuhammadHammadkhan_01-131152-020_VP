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
    public partial class deleteStudent : Form
    {
        public deleteStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          String StudentId;
        
         StudentId = textBox1.Text;
         int index = 0;
         string[] num2 = new string[20];
         String[] array1 = new string[50];
         string[] name = new string[500];
         int d = 0;
         StreamReader read = new StreamReader("C:\\Users\\hamma\\Desktop\\students.txt");
         do
         {
             array1[index] = read.ReadLine();
             index++;
         }

         while (!read.EndOfStream);
         for (int i = 0; i < index; i++)
         {
             if (StudentId == array1[i])
             {
                 MessageBox.Show("deleted");
                 i = i + 5;
             }
             else
             {
                 MessageBox.Show("record is not exists");
                 num2[d] = array1[i];
                 d++;
             }
         }
         read.Close();
         StreamWriter write = File.CreateText("C:\\Users\\hamma\\Desktop\\students.txt");
         for (int i = 0; i < index; i++)
         {
             write.WriteLine(num2[i]);
         }
         write.Close();
         
     }

        
    }
}
