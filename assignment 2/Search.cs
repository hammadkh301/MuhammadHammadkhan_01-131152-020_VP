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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

    
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchById obj2 = new SearchById();
            obj2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchByName obj5 = new SearchByName();
            obj5.Show();
        }
    }
}
