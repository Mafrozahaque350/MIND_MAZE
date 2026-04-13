using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MIND_MAZE
{
    public partial class Form22: Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                pictureBox1.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
