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
    public partial class adminresult : UserControl
    {
        string path = @"Data Source=DESKTOP-GC3U8L9\SQLEXPRESS;Initial Catalog=Mind_Maze;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        public adminresult()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
            display1();
            display2();
        }

        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from IQ", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void display1()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from GK", con);
                adpt.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void display2()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from SC", con);
                adpt.Fill(dt);
                dataGridView3.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adminresult_Load(object sender, EventArgs e)
        {

        }
    }
}
