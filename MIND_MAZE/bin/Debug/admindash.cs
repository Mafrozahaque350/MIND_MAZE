using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace MIND_MAZE
{
    public partial class admindash : UserControl
    {
        string path = @"Data Source=DESKTOP-GC3U8L9\SQLEXPRESS;Initial Catalog=Mind_Maze;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int QNO;
        public admindash()
        {
            InitializeComponent();
             con = new SqlConnection(path);
            display();

        }

        private void TYPES_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clear()
        {
            TYPES_TXT.Text = "";
            O1txt.Text = "";
            O2txt.Text = "";
            O3txt.Text = "";
            Atxt.Text = "";
            q1.Text = "";
            Qtext.Text = "";
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from INSERT_Q1", con);
                adpt.Fill(dt);
                dgvdash.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insert_Click(object sender, EventArgs e)
        { if(TYPES_TXT.Text == "" || O1txt.Text == "" || O2txt.Text == "" || O3txt.Text == "" || Atxt.Text == "" || q1.Text == "")
            {
                MessageBox.Show("Enter value");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO INSERT_Q1 ( QNO,TYPES, QUESTIONS, OPTION1, OPTION2, OPTION3, ANSWER) VALUES ('" + q1.Text + "','" + TYPES_TXT.Text + "','" + Qtext.Text + "','" + O1txt.Text + "','" + O2txt.Text + "','" + O3txt.Text + "','" + Atxt.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Success");
                    clear();
                    display();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error Occured"+ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dgvdash_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             
            QNO = int.Parse(dgvdash.Rows[e.RowIndex].Cells[0].Value.ToString());
            TYPES_TXT.Text = dgvdash.Rows[e.RowIndex].Cells[1].Value.ToString();
            Qtext.Text = dgvdash.Rows[e.RowIndex].Cells[2].Value.ToString();
            O1txt.Text = dgvdash.Rows[e.RowIndex].Cells[3].Value.ToString();
            O2txt.Text = dgvdash.Rows[e.RowIndex].Cells[4].Value.ToString();
            O3txt.Text =dgvdash.Rows[e.RowIndex].Cells[5].Value.ToString();
            Atxt.Text = dgvdash.Rows[e.RowIndex].Cells[6].Value.ToString();

            
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update INSERT_Q1 set TYPES='" + TYPES_TXT.Text + "',QUESTIONS='" + Qtext.Text + "',OPTION1='" + O1txt.Text + "',OPTION2='" + O2txt.Text + "',OPTION3='" + O3txt.Text + "',ANSWER='" + Atxt.Text +"'where QNO='"+QNO+ "'", con);
                cmd.ExecuteNonQuery();                
                con.Close();
                MessageBox.Show("Updated");
                display();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from INSERT_Q1 where QNO='" + QNO + "'", con);
                cmd.ExecuteNonQuery();
                

                con.Close();
                MessageBox.Show("Deleted");
                display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
