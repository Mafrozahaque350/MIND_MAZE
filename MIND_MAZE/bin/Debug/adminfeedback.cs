using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIND_MAZE
{

    public partial class adminfeedback : UserControl
    {
        string path = @"Data Source=DESKTOP-GC3U8L9\SQLEXPRESS;Initial Catalog=Mind_Maze;Integrated Security=True;Encrypt=False";
        SqlConnection con;

        SqlDataAdapter adpt;
        DataTable dt;
        public adminfeedback()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Feedback", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminfeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
