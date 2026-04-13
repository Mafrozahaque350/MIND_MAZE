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
    public partial class adminEvent : UserControl
    {
        string path = @"Data Source=DESKTOP-GC3U8L9\SQLEXPRESS;Initial Catalog=Mind_Maze;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        public adminEvent()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""  || textBox6.Text == ""  )
            {
                MessageBox.Show("Enter value");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Admin_Event (Event_No, Event_Name, Event_Topic,Event_Start_Date,Event_End_Date,Event_Prize) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Success");
                    clear();

                }


                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error Occured" + ex.Message);
                }
            }
        }
    }
}
