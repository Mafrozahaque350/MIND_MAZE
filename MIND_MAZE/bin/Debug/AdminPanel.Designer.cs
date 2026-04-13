namespace MIND_MAZE
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.menuController = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDeshboard = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.ResultSection = new System.Windows.Forms.FlowLayoutPanel();
            this.pnResults = new System.Windows.Forms.Panel();
            this.Results = new System.Windows.Forms.Button();
            this.pnEasy = new System.Windows.Forms.Panel();
            this.easy1 = new System.Windows.Forms.Button();
            this.pnMedium = new System.Windows.Forms.Panel();
            this.medium1 = new System.Windows.Forms.Button();
            this.pnhard = new System.Windows.Forms.Panel();
            this.hard1 = new System.Windows.Forms.Button();
            this.pnUpdate = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.button20 = new System.Windows.Forms.Button();
            this.pnFeed = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.ResultTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTrasition = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adminPanel1 = new System.Windows.Forms.Panel();
            this.menuController.SuspendLayout();
            this.pnDeshboard.SuspendLayout();
            this.ResultSection.SuspendLayout();
            this.pnResults.SuspendLayout();
            this.pnEasy.SuspendLayout();
            this.pnMedium.SuspendLayout();
            this.pnhard.SuspendLayout();
            this.pnUpdate.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.pnFeed.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.adminPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuController
            // 
            this.menuController.BackColor = System.Drawing.Color.Turquoise;
            this.menuController.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuController.Controls.Add(this.pnDeshboard);
            this.menuController.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuController.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuController.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuController.Location = new System.Drawing.Point(0, 57);
            this.menuController.Margin = new System.Windows.Forms.Padding(2);
            this.menuController.Name = "menuController";
            this.menuController.Size = new System.Drawing.Size(159, 518);
            this.menuController.TabIndex = 3;
            this.menuController.Paint += new System.Windows.Forms.PaintEventHandler(this.menuController_Paint);
            // 
            // pnDeshboard
            // 
            this.pnDeshboard.BackColor = System.Drawing.Color.Transparent;
            this.pnDeshboard.Controls.Add(this.button5);
            this.pnDeshboard.Location = new System.Drawing.Point(2, 2);
            this.pnDeshboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnDeshboard.Name = "pnDeshboard";
            this.pnDeshboard.Size = new System.Drawing.Size(155, 44);
            this.pnDeshboard.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Turquoise;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(155, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "         Dashboard";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ResultSection
            // 
            this.ResultSection.BackColor = System.Drawing.Color.Transparent;
            this.ResultSection.Controls.Add(this.pnResults);
            this.ResultSection.Controls.Add(this.pnEasy);
            this.ResultSection.Controls.Add(this.pnMedium);
            this.ResultSection.Controls.Add(this.pnhard);
            this.ResultSection.Location = new System.Drawing.Point(60, 38);
            this.ResultSection.Margin = new System.Windows.Forms.Padding(0);
            this.ResultSection.Name = "ResultSection";
            this.ResultSection.Size = new System.Drawing.Size(154, 190);
            this.ResultSection.TabIndex = 22;
            // 
            // pnResults
            // 
            this.pnResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnResults.Controls.Add(this.Results);
            this.pnResults.Location = new System.Drawing.Point(2, 2);
            this.pnResults.Margin = new System.Windows.Forms.Padding(2);
            this.pnResults.Name = "pnResults";
            this.pnResults.Size = new System.Drawing.Size(156, 44);
            this.pnResults.TabIndex = 14;
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.Turquoise;
            this.Results.FlatAppearance.BorderSize = 0;
            this.Results.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Results.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.Color.Black;
            this.Results.Image = global::MIND_MAZE.Properties.Resources.results;
            this.Results.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Results.Location = new System.Drawing.Point(-3, -1);
            this.Results.Margin = new System.Windows.Forms.Padding(2);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Results.Size = new System.Drawing.Size(154, 44);
            this.Results.TabIndex = 10;
            this.Results.Text = "         Topic";
            this.Results.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Results.UseVisualStyleBackColor = false;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // pnEasy
            // 
            this.pnEasy.Controls.Add(this.easy1);
            this.pnEasy.Location = new System.Drawing.Point(2, 50);
            this.pnEasy.Margin = new System.Windows.Forms.Padding(2);
            this.pnEasy.Name = "pnEasy";
            this.pnEasy.Size = new System.Drawing.Size(155, 44);
            this.pnEasy.TabIndex = 15;
            // 
            // easy1
            // 
            this.easy1.AutoSize = true;
            this.easy1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.easy1.FlatAppearance.BorderSize = 0;
            this.easy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy1.ForeColor = System.Drawing.Color.Black;
            this.easy1.Image = ((System.Drawing.Image)(resources.GetObject("easy1.Image")));
            this.easy1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easy1.Location = new System.Drawing.Point(0, 0);
            this.easy1.Margin = new System.Windows.Forms.Padding(2);
            this.easy1.Name = "easy1";
            this.easy1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.easy1.Size = new System.Drawing.Size(155, 44);
            this.easy1.TabIndex = 12;
            this.easy1.Text = "        IQ";
            this.easy1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easy1.UseVisualStyleBackColor = false;
            this.easy1.Click += new System.EventHandler(this.easy1_Click);
            // 
            // pnMedium
            // 
            this.pnMedium.Controls.Add(this.medium1);
            this.pnMedium.Location = new System.Drawing.Point(2, 98);
            this.pnMedium.Margin = new System.Windows.Forms.Padding(2);
            this.pnMedium.Name = "pnMedium";
            this.pnMedium.Size = new System.Drawing.Size(155, 44);
            this.pnMedium.TabIndex = 15;
            // 
            // medium1
            // 
            this.medium1.AutoSize = true;
            this.medium1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.medium1.FlatAppearance.BorderSize = 0;
            this.medium1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medium1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium1.ForeColor = System.Drawing.Color.Black;
            this.medium1.Image = ((System.Drawing.Image)(resources.GetObject("medium1.Image")));
            this.medium1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medium1.Location = new System.Drawing.Point(0, 0);
            this.medium1.Margin = new System.Windows.Forms.Padding(2);
            this.medium1.Name = "medium1";
            this.medium1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.medium1.Size = new System.Drawing.Size(155, 44);
            this.medium1.TabIndex = 13;
            this.medium1.Text = "        GK";
            this.medium1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medium1.UseVisualStyleBackColor = false;
            this.medium1.Click += new System.EventHandler(this.medium1_Click);
            // 
            // pnhard
            // 
            this.pnhard.Controls.Add(this.hard1);
            this.pnhard.Location = new System.Drawing.Point(2, 146);
            this.pnhard.Margin = new System.Windows.Forms.Padding(2);
            this.pnhard.Name = "pnhard";
            this.pnhard.Size = new System.Drawing.Size(155, 44);
            this.pnhard.TabIndex = 16;
            // 
            // hard1
            // 
            this.hard1.AutoSize = true;
            this.hard1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.hard1.FlatAppearance.BorderSize = 0;
            this.hard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard1.ForeColor = System.Drawing.Color.Black;
            this.hard1.Image = ((System.Drawing.Image)(resources.GetObject("hard1.Image")));
            this.hard1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hard1.Location = new System.Drawing.Point(0, 0);
            this.hard1.Margin = new System.Windows.Forms.Padding(2);
            this.hard1.Name = "hard1";
            this.hard1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.hard1.Size = new System.Drawing.Size(155, 44);
            this.hard1.TabIndex = 11;
            this.hard1.Text = "        SC";
            this.hard1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hard1.UseVisualStyleBackColor = false;
            this.hard1.Click += new System.EventHandler(this.hard1_Click);
            // 
            // pnUpdate
            // 
            this.pnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pnUpdate.Controls.Add(this.update);
            this.pnUpdate.Location = new System.Drawing.Point(347, 88);
            this.pnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.pnUpdate.Name = "pnUpdate";
            this.pnUpdate.Size = new System.Drawing.Size(155, 44);
            this.pnUpdate.TabIndex = 20;
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.Color.Turquoise;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(0, 0);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.update.Size = new System.Drawing.Size(155, 44);
            this.update.TabIndex = 8;
            this.update.Text = "         Event";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.Color.Transparent;
            this.pnSettings.Controls.Add(this.button20);
            this.pnSettings.Location = new System.Drawing.Point(347, 136);
            this.pnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(155, 44);
            this.pnSettings.TabIndex = 20;
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.BackColor = System.Drawing.Color.Turquoise;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.Location = new System.Drawing.Point(0, 0);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button20.Size = new System.Drawing.Size(155, 44);
            this.button20.TabIndex = 6;
            this.button20.Text = "         Settings";
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // pnFeed
            // 
            this.pnFeed.Controls.Add(this.button19);
            this.pnFeed.Location = new System.Drawing.Point(347, 184);
            this.pnFeed.Margin = new System.Windows.Forms.Padding(2);
            this.pnFeed.Name = "pnFeed";
            this.pnFeed.Size = new System.Drawing.Size(155, 44);
            this.pnFeed.TabIndex = 21;
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.BackColor = System.Drawing.Color.Turquoise;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(0, 0);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button19.Size = new System.Drawing.Size(155, 44);
            this.button19.TabIndex = 7;
            this.button19.Text = "          Feedbacks";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.BackColor = System.Drawing.Color.Transparent;
            this.pnLogout.Controls.Add(this.button6);
            this.pnLogout.Location = new System.Drawing.Point(347, 232);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(155, 44);
            this.pnLogout.TabIndex = 19;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.Turquoise;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(155, 44);
            this.button6.TabIndex = 8;
            this.button6.Text = "         Logout";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Admin Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 57);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::MIND_MAZE.Properties.Resources.Email;
            this.button2.Location = new System.Drawing.Point(724, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 38);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::MIND_MAZE.Properties.Resources.notification;
            this.button3.Location = new System.Drawing.Point(676, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 41);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::MIND_MAZE.Properties.Resources.admin;
            this.button4.Location = new System.Drawing.Point(767, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 41);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Image = global::MIND_MAZE.Properties.Resources.icons8_menu_50;
            this.Menu.Location = new System.Drawing.Point(136, 4);
            this.Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(56, 44);
            this.Menu.TabIndex = 29;
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // ResultTransition
            // 
            this.ResultTransition.Tick += new System.EventHandler(this.ResultTransition_Tick);
            // 
            // sidebarTrasition
            // 
            this.sidebarTrasition.Tick += new System.EventHandler(this.sidebarTrasition_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adminPanel1
            // 
            this.adminPanel1.Controls.Add(this.ResultSection);
            this.adminPanel1.Controls.Add(this.pnLogout);
            this.adminPanel1.Controls.Add(this.pnUpdate);
            this.adminPanel1.Controls.Add(this.pnFeed);
            this.adminPanel1.Controls.Add(this.pnSettings);
            this.adminPanel1.Location = new System.Drawing.Point(160, 60);
            this.adminPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.adminPanel1.Name = "adminPanel1";
            this.adminPanel1.Size = new System.Drawing.Size(656, 515);
            this.adminPanel1.TabIndex = 5;
            this.adminPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.adminPanel1_Paint);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.ControlBox = false;
            this.Controls.Add(this.adminPanel1);
            this.Controls.Add(this.menuController);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.menuController.ResumeLayout(false);
            this.pnDeshboard.ResumeLayout(false);
            this.pnDeshboard.PerformLayout();
            this.ResultSection.ResumeLayout(false);
            this.pnResults.ResumeLayout(false);
            this.pnEasy.ResumeLayout(false);
            this.pnEasy.PerformLayout();
            this.pnMedium.ResumeLayout(false);
            this.pnMedium.PerformLayout();
            this.pnhard.ResumeLayout(false);
            this.pnhard.PerformLayout();
            this.pnUpdate.ResumeLayout(false);
            this.pnUpdate.PerformLayout();
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.pnFeed.ResumeLayout(false);
            this.pnFeed.PerformLayout();
            this.pnLogout.ResumeLayout(false);
            this.pnLogout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.adminPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuController;
        private new System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnDeshboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnFeed;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer ResultTransition;
        private System.Windows.Forms.Timer sidebarTrasition;
        private System.Windows.Forms.FlowLayoutPanel ResultSection;
        private System.Windows.Forms.Panel pnResults;
        private System.Windows.Forms.Button Results;
        private System.Windows.Forms.Panel pnEasy;
        private System.Windows.Forms.Button easy1;
        private System.Windows.Forms.Panel pnMedium;
        private System.Windows.Forms.Button medium1;
        private System.Windows.Forms.Panel pnhard;
        private System.Windows.Forms.Button hard1;
        private System.Windows.Forms.Panel pnUpdate;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel adminPanel1;
    }
}