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
    public partial class Form43 : Form
    {
        public Form43()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form44 q1 = new Form44();
            q1.ShowDialog();
            this.Close();
        }
    }
}
