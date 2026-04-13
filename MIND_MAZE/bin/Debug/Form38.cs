using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIND_MAZE
{
    public partial class Form38 : Form
    {
        public Form38()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form39 q1 = new Form39();
            q1.ShowDialog();
            this.Close();
        }
    }
}
