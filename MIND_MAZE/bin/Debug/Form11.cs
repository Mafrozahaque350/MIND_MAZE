using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MIND_MAZE
{
    public partial class Form11 : Form
    {
        Form16 instructions;
        Form15 achievements;
        Form14 settings;
        Form13 about;
        QuizLevel play;
       // Form17 logout;
        Form10 feedback;
        Form20 events;
        Form21 leaderboard;
        Form22 gallery;
        Form23 service;
        public Form11()
        {
            InitializeComponent();
            mdiProp();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool menuExpand=false;
        private void mdiProp() 
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand==false) 
            {
                pnInfo.Height += 10;
                if (pnInfo.Height >=110) 
                { 
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                pnInfo.Height -= 10;
                if(pnInfo.Height <=33)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand) 
            {
                sidebar.Width-= 5;
                if(sidebar.Width <= 46)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnPlay.Width = sidebar.Width;
                    pnEvent.Width = sidebar.Width;
                    pnLeaderboard.Width = sidebar.Width;
                    pnGallery.Width = sidebar.Width;
                    pnFeedback.Width = sidebar.Width;
                    pnService.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    pnInfo.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if(sidebar.Width >= 150)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnPlay.Width = sidebar.Width;
                    pnEvent.Width = sidebar.Width;
                    pnLeaderboard.Width = sidebar.Width;
                    pnGallery.Width = sidebar.Width;
                    pnFeedback.Width = sidebar.Width;
                    pnService.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    pnInfo.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Play_FormClosed(object sender, FormClosedEventArgs e)
        {
            play = null;
        }

        private void submenu1_Click(object sender, EventArgs e)
        {
           
        }

        private void Achievements_FormClosed(object sender, FormClosedEventArgs e)
        {
            achievements = null;
        }

        private void submenu2_Click(object sender, EventArgs e)
        {
            
        }
        private void Instructions_FormClosed(object sender, FormClosedEventArgs e)
        {
            instructions = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new Form13();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }
        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }

        private void gf_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new Form14();
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }

        private void hh_Click(object sender, EventArgs e)
        {
            /*if (logout == null)
            {
                logout = new Form17();
                logout.FormClosed += Logout_FormClosed;
                logout.MdiParent = this;
                logout.Dock = DockStyle.Fill;
                logout.Show();
            }
            else
            {
                logout.Activate();
            }
        }
        private void Logout_FormClosed(object sender, FormClosedEventArgs e)
        {
            logout = null;
        */
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (play == null)
            {
                play = new QuizLevel();
                play.FormClosed += Play_FormClosed;
                play.MdiParent = this;
                play.Dock = DockStyle.Fill;
                play.Show();
            }
            else
            {
                play.Activate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (events == null)
            {
                events = new Form20();
                events.FormClosed += Events_FormClosed;
                events.MdiParent = this;
                events.Dock = DockStyle.Fill;
                events.Show();
            }
            else
            {
                events.Activate();
            }
        }
        private void Events_FormClosed(object sender, FormClosedEventArgs e)
        {
            events = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (leaderboard == null)
            {
                leaderboard = new Form21();
                leaderboard.FormClosed += Leaderboard_FormClosed;
                leaderboard.MdiParent = this;
                leaderboard.Dock = DockStyle.Fill;
                leaderboard.Show();
            }
            else
            {
                leaderboard.Activate();
            }
        }
        private void Leaderboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            leaderboard = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gallery == null)
            {
                gallery = new Form22();
                gallery.FormClosed += Gallery_FormClosed;
                gallery.MdiParent = this;
                gallery.Dock = DockStyle.Fill;
                gallery.Show();
            }
            else
            {
                gallery.Activate();
            }
        }
        private void Gallery_FormClosed(object sender, FormClosedEventArgs e)
        {
            gallery = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (feedback == null)
            {
                feedback = new Form10();
                feedback.FormClosed += Feedback_FormClosed;
                feedback.MdiParent = this;
                feedback.Dock = DockStyle.Fill;
                feedback.Show();
            }
            else
            {
                feedback.Activate();
            }
        }
        private void Feedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            feedback = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (service== null)
            {
                service = new Form23();
                service.FormClosed += Service_FormClosed;
                service.MdiParent = this;
                service.Dock = DockStyle.Fill;
                service.Show();
            }
            else
            {
                service.Activate();
            }
        }
        private void Service_FormClosed(object sender, FormClosedEventArgs e)
        {
            service = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (achievements == null)
            {
                instructions = new Form16();
                instructions.FormClosed += Instructions_FormClosed;
                instructions.MdiParent = this;
                instructions.Dock = DockStyle.Fill;
                instructions.Show();
            }
            else
            {
                instructions.Activate();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
                if (achievements == null)
            {
                achievements = new Form15();
                achievements.FormClosed += Achievements_FormClosed;
                achievements.MdiParent = this;
                achievements.Dock = DockStyle.Fill;
                achievements.Show();
            }
            else
            {
                achievements.Activate();
            }
        }
    }
    }

