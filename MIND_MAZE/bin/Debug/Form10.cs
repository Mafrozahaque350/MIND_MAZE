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
    public partial class Form10 : Form
    {
        string path = @"Data Source=DESKTOP-GC3U8L9\SQLEXPRESS;Initial Catalog=Mind_Maze;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        
        public Form10()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedItem = "";
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedItem ==null)
            {
                MessageBox.Show("Enter value");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Feedback (Name, Email, Feedback) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +  "')", con);
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

        private void Form10_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
