namespace MIND_MAZE
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPlay = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnEvent = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pnLeaderboard = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pnGallery = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.gf = new System.Windows.Forms.Button();
            this.pnInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.pnFeedback = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnService = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.hh = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnPlay.SuspendLayout();
            this.pnEvent.SuspendLayout();
            this.pnLeaderboard.SuspendLayout();
            this.pnGallery.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnFeedback.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.pnService.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 36);
            this.panel1.TabIndex = 0;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(774, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 34);
            this.close.TabIndex = 22;
            this.close.TabStop = false;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLAYER MENU ǀ MIND MAZE";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(34, 30);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnPlay);
            this.sidebar.Controls.Add(this.pnEvent);
            this.sidebar.Controls.Add(this.pnLeaderboard);
            this.sidebar.Controls.Add(this.pnGallery);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.pnInfo);
            this.sidebar.Controls.Add(this.pnFeedback);
            this.sidebar.Controls.Add(this.pnAbout);
            this.sidebar.Controls.Add(this.pnService);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 36);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(150, 539);
            this.sidebar.TabIndex = 1;
            // 
            // pnPlay
            // 
            this.pnPlay.Controls.Add(this.button3);
            this.pnPlay.Location = new System.Drawing.Point(3, 33);
            this.pnPlay.Name = "pnPlay";
            this.pnPlay.Size = new System.Drawing.Size(159, 33);
            this.pnPlay.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-11, -10);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(177, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "        Play";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnEvent
            // 
            this.pnEvent.Controls.Add(this.button4);
            this.pnEvent.Location = new System.Drawing.Point(3, 72);
            this.pnEvent.Name = "pnEvent";
            this.pnEvent.Size = new System.Drawing.Size(159, 33);
            this.pnEvent.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-11, -10);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(177, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "        Events";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnLeaderboard
            // 
            this.pnLeaderboard.Controls.Add(this.button5);
            this.pnLeaderboard.Location = new System.Drawing.Point(3, 111);
            this.pnLeaderboard.Name = "pnLeaderboard";
            this.pnLeaderboard.Size = new System.Drawing.Size(159, 33);
            this.pnLeaderboard.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-11, -10);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(177, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "        Leaderboard";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnGallery
            // 
            this.pnGallery.Controls.Add(this.button6);
            this.pnGallery.Location = new System.Drawing.Point(3, 150);
            this.pnGallery.Name = "pnGallery";
            this.pnGallery.Size = new System.Drawing.Size(159, 33);
            this.pnGallery.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-11, -10);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(177, 52);
            this.button6.TabIndex = 4;
            this.button6.Text = "        Gallery";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.gf);
            this.pnSettings.Location = new System.Drawing.Point(3, 189);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(159, 33);
            this.pnSettings.TabIndex = 5;
            // 
            // gf
            // 
            this.gf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.gf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gf.ForeColor = System.Drawing.Color.White;
            this.gf.Image = ((System.Drawing.Image)(resources.GetObject("gf.Image")));
            this.gf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gf.Location = new System.Drawing.Point(-11, -10);
            this.gf.Name = "gf";
            this.gf.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.gf.Size = new System.Drawing.Size(177, 52);
            this.gf.TabIndex = 4;
            this.gf.Text = "        Settings";
            this.gf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gf.UseVisualStyleBackColor = false;
            this.gf.Click += new System.EventHandler(this.gf_Click);
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pnInfo.Controls.Add(this.panel4);
            this.pnInfo.Controls.Add(this.panel5);
            this.pnInfo.Controls.Add(this.panel9);
            this.pnInfo.Location = new System.Drawing.Point(0, 225);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(159, 33);
            this.pnInfo.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button8);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 33);
            this.panel4.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-11, -10);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(177, 52);
            this.button8.TabIndex = 4;
            this.button8.Text = "        Info";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button9);
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 33);
            this.panel5.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-11, -10);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(177, 52);
            this.button9.TabIndex = 4;
            this.button9.Text = "        Instructions";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button10);
            this.panel9.Location = new System.Drawing.Point(0, 66);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(159, 33);
            this.panel9.TabIndex = 10;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-11, -10);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(177, 52);
            this.button10.TabIndex = 4;
            this.button10.Text = "        Achievements";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pnFeedback
            // 
            this.pnFeedback.Controls.Add(this.button11);
            this.pnFeedback.Location = new System.Drawing.Point(3, 261);
            this.pnFeedback.Name = "pnFeedback";
            this.pnFeedback.Size = new System.Drawing.Size(159, 33);
            this.pnFeedback.TabIndex = 16;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(-11, -10);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(177, 52);
            this.button11.TabIndex = 4;
            this.button11.Text = "        Feedback";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // pnAbout
            // 
            this.pnAbout.Controls.Add(this.button2);
            this.pnAbout.Location = new System.Drawing.Point(3, 300);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(159, 33);
            this.pnAbout.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-12, -11);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(177, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "        About";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnService
            // 
            this.pnService.Controls.Add(this.button13);
            this.pnService.Location = new System.Drawing.Point(3, 339);
            this.pnService.Name = "pnService";
            this.pnService.Size = new System.Drawing.Size(159, 33);
            this.pnService.TabIndex = 19;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(-11, -10);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(177, 52);
            this.button13.TabIndex = 4;
            this.button13.Text = "        Service";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.hh);
            this.pnLogout.Location = new System.Drawing.Point(3, 378);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(159, 33);
            this.pnLogout.TabIndex = 6;
            // 
            // hh
            // 
            this.hh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.hh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hh.ForeColor = System.Drawing.Color.White;
            this.hh.Image = ((System.Drawing.Image)(resources.GetObject("hh.Image")));
            this.hh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hh.Location = new System.Drawing.Point(-11, -10);
            this.hh.Name = "hh";
            this.hh.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.hh.Size = new System.Drawing.Size(177, 52);
            this.hh.TabIndex = 4;
            this.hh.Text = "        Logout";
            this.hh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hh.UseVisualStyleBackColor = false;
            this.hh.Click += new System.EventHandler(this.hh_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form11
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnPlay.ResumeLayout(false);
            this.pnEvent.ResumeLayout(false);
            this.pnLeaderboard.ResumeLayout(false);
            this.pnGallery.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnFeedback.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.pnService.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button gf;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button hh;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnPlay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnEvent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnLeaderboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnGallery;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel pnInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel pnFeedback;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel pnService;
        private System.Windows.Forms.Button button13;
    }
}