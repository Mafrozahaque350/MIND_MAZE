using MIND_MAZE.Properties;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            mdiProp();

        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(240,240,240);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.adminPanel1.Controls.Clear();
            admindash qs = new admindash();
            this.adminPanel1.Controls.Add(qs);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            sidebarTrasition.Start();
        }

        bool sidebarExpand = false;
        private void sidebarTrasition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                menuController.Width -= 5;
                if (menuController.Width <= 57)
                {
                    sidebarExpand = false;
                    sidebarTrasition.Stop();

                    pnDeshboard.Width = menuController.Width;
                    pnLogout.Width = menuController.Width;
                    ResultSection.Width = menuController.Width;
                    pnFeed.Width = menuController.Width;
                    pnUpdate.Width = menuController.Width;
                    pnSettings.Width = menuController.Width;
                }

            }
            else
            {
                menuController.Width += 5;
                if (menuController.Width >= 155)
                {
                    sidebarExpand = true;
                    sidebarTrasition.Stop();

                    pnDeshboard.Width = menuController.Width;
                     pnLogout.Width = menuController.Width;
                     ResultSection.Width = menuController.Width;
                     pnFeed.Width = menuController.Width;
                     pnUpdate.Width = menuController.Width;
                     pnSettings.Width = menuController.Width;


                }
            }

        }
        bool resultExpand = false;
       // private object adminpanel;

        private void ResultTransition_Tick(object sender, EventArgs e)
        {
            if (resultExpand == false)
            {
                ResultSection.Height += 10;
                if (ResultSection.Height >= 185)
                {
                    ResultTransition.Stop();
                    resultExpand = true;
                }
            }
            else
            {
                ResultSection.Height -= 10;
                if (ResultSection.Height <= 54)
                {
                    ResultTransition.Stop();
                    resultExpand = false;
                }
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            /* if (feedback == null)
             {
                 feedback = new Form18();
                 feedback.FormClosed += Feed_FormClosed;
                 feedback.MdiParent = this;
                 feedback.Dock = DockStyle.Fill;
                 feedback.Show();
             }
             else
             {
                 feedback.Activate();
             }*/
            this.adminPanel1.Controls.Clear();
            adminfeedback qs = new adminfeedback();
            this.adminPanel1.Controls.Add(qs);
        }

        

        private void button20_Click(object sender, EventArgs e)
        {
            this.adminPanel1.Controls.Clear();
            Settings qs = new Settings();
            this.adminPanel1.Controls.Add(qs);
        }

        

        private void Results_Click(object sender, EventArgs e)
        {
            ResultTransition.Start();
            this.adminPanel1.Controls.Clear();
            adminresult qs = new adminresult();
            this.adminPanel1.Controls.Add(qs);

        }

        private void easy1_Click(object sender, EventArgs e)
        {
            /* if (easy == null)
             {
                 easy = new Easy();
                 easy.FormClosed += Esay_FormClosed;
                 easy.MdiParent = this;
                 easy.Dock = DockStyle.Fill;
                 easy.Show();
             }
             else
             {
                 easy.Activate();
             }

     }
     private void Esay_FormClosed(object sender, FormClosedEventArgs e)
     {
         easy = null;*/
            
        }

        private void medium1_Click(object sender, EventArgs e)
        {
           

        }

        

        private void hard1_Click(object sender, EventArgs e)
        {
          
           

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void menuController_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {


            this.adminPanel1.Controls.Clear();
            Q1UserControl qs = new Q1UserControl();
            this.adminPanel1.Controls.Add(qs);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void adminPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            this.adminPanel1.Controls.Clear();
            adminEvent qs = new adminEvent();
            this.adminPanel1.Controls.Add(qs);
        }
    }
 }

