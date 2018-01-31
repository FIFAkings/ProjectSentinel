namespace ProjectSentinel
{
    partial class MainScreenActivity
    {
        User user = new User();
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
            user.loadUserFromDatabase(Properties.Settings.Default.LoggedUserId);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenActivity));
            this.UserIconMainScreenActivity = new System.Windows.Forms.PictureBox();
            this.userLogoutbuttonMainScreenActivity = new System.Windows.Forms.Button();
            this.MyProfileButonMainScreenActivity = new System.Windows.Forms.Button();
            this.SettingsButtonMainScreenActivity = new System.Windows.Forms.Button();
            this.TopPanelMainScreenActivity = new System.Windows.Forms.Panel();
            this.WelcomeLabelMainScreenActivity = new System.Windows.Forms.Label();
            this.SidePanelMainScreenActivity = new System.Windows.Forms.Panel();
            this.SidePanel1 = new System.Windows.Forms.Panel();
            this.ScheduleIconMainScreenActivity = new System.Windows.Forms.PictureBox();
            this.CourseIconMainScreenActivity = new System.Windows.Forms.PictureBox();
            this.ToDoIconMainScreenActivity = new System.Windows.Forms.PictureBox();
            this.FlashcardIconMainScreenActivity = new System.Windows.Forms.PictureBox();
            this.HomeIconMainScreenActivity = new System.Windows.Forms.PictureBox();
            this.ScheduleButtonMainScreenActivity = new System.Windows.Forms.Button();
            this.SidePanel3MainScreenActivity = new System.Windows.Forms.Panel();
            this.SentinelLabelMainScreenActivity = new System.Windows.Forms.Label();
            this.ProjectLabelMainScreenActivity = new System.Windows.Forms.Label();
            this.MainIconMainScreenActivity = new System.Windows.Forms.PictureBox();
            this.CourseButtonMainScreenActivity = new System.Windows.Forms.Button();
            this.FlashcardButtonMainScreenActivity = new System.Windows.Forms.Button();
            this.ToDoButtonMainScreenActivity = new System.Windows.Forms.Button();
            this.HomeButtonMainScreenActivity = new System.Windows.Forms.Button();
            this.MainPanelMainScreenActivity = new System.Windows.Forms.Panel();
            this.HomeControlMainScreenActivity = new ProjectSentinel.HomeControl();
            this.ToDoControlMainScreenActivity = new ProjectSentinel.ToDoControl();
            this.FlashcardControlMainScreenActivity = new ProjectSentinel.FlashcardControl();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconMainScreenActivity)).BeginInit();
            this.TopPanelMainScreenActivity.SuspendLayout();
            this.SidePanelMainScreenActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleIconMainScreenActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseIconMainScreenActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoIconMainScreenActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlashcardIconMainScreenActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconMainScreenActivity)).BeginInit();
            this.SidePanel3MainScreenActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainIconMainScreenActivity)).BeginInit();
            this.MainPanelMainScreenActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserIconMainScreenActivity
            // 
            this.UserIconMainScreenActivity.Image = ((System.Drawing.Image)(resources.GetObject("UserIconMainScreenActivity.Image")));
            this.UserIconMainScreenActivity.Location = new System.Drawing.Point(843, 12);
            this.UserIconMainScreenActivity.Name = "UserIconMainScreenActivity";
            this.UserIconMainScreenActivity.Size = new System.Drawing.Size(35, 35);
            this.UserIconMainScreenActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserIconMainScreenActivity.TabIndex = 1;
            this.UserIconMainScreenActivity.TabStop = false;
            // 
            // userLogoutbuttonMainScreenActivity
            // 
            this.userLogoutbuttonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.userLogoutbuttonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogoutbuttonMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLogoutbuttonMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLogoutbuttonMainScreenActivity.Location = new System.Drawing.Point(743, 0);
            this.userLogoutbuttonMainScreenActivity.Name = "userLogoutbuttonMainScreenActivity";
            this.userLogoutbuttonMainScreenActivity.Size = new System.Drawing.Size(94, 59);
            this.userLogoutbuttonMainScreenActivity.TabIndex = 1;
            this.userLogoutbuttonMainScreenActivity.Text = "Log Out";
            this.userLogoutbuttonMainScreenActivity.UseVisualStyleBackColor = true;
            this.userLogoutbuttonMainScreenActivity.Click += new System.EventHandler(this.userLogoutbuttonMainScreenActivity_Click);
            // 
            // MyProfileButonMainScreenActivity
            // 
            this.MyProfileButonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.MyProfileButonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyProfileButonMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MyProfileButonMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyProfileButonMainScreenActivity.Location = new System.Drawing.Point(555, 0);
            this.MyProfileButonMainScreenActivity.Name = "MyProfileButonMainScreenActivity";
            this.MyProfileButonMainScreenActivity.Size = new System.Drawing.Size(94, 59);
            this.MyProfileButonMainScreenActivity.TabIndex = 2;
            this.MyProfileButonMainScreenActivity.Text = user.Username;
            this.MyProfileButonMainScreenActivity.UseVisualStyleBackColor = true;
            this.MyProfileButonMainScreenActivity.Click += new System.EventHandler(this.MyProfileButon_Click);
            // 
            // SettingsButtonMainScreenActivity
            // 
            this.SettingsButtonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.SettingsButtonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButtonMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButtonMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingsButtonMainScreenActivity.Location = new System.Drawing.Point(649, 0);
            this.SettingsButtonMainScreenActivity.Name = "SettingsButtonMainScreenActivity";
            this.SettingsButtonMainScreenActivity.Size = new System.Drawing.Size(94, 59);
            this.SettingsButtonMainScreenActivity.TabIndex = 3;
            this.SettingsButtonMainScreenActivity.Text = "Settings";
            this.SettingsButtonMainScreenActivity.UseVisualStyleBackColor = true;
            this.SettingsButtonMainScreenActivity.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // TopPanelMainScreenActivity
            // 
            this.TopPanelMainScreenActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(15)))), ((int)(((byte)(51)))));
            this.TopPanelMainScreenActivity.Controls.Add(this.WelcomeLabelMainScreenActivity);
            this.TopPanelMainScreenActivity.Controls.Add(this.SettingsButtonMainScreenActivity);
            this.TopPanelMainScreenActivity.Controls.Add(this.MyProfileButonMainScreenActivity);
            this.TopPanelMainScreenActivity.Controls.Add(this.userLogoutbuttonMainScreenActivity);
            this.TopPanelMainScreenActivity.Controls.Add(this.UserIconMainScreenActivity);
            this.TopPanelMainScreenActivity.Location = new System.Drawing.Point(206, 0);
            this.TopPanelMainScreenActivity.Name = "TopPanelMainScreenActivity";
            this.TopPanelMainScreenActivity.Size = new System.Drawing.Size(902, 56);
            this.TopPanelMainScreenActivity.TabIndex = 0;
            this.TopPanelMainScreenActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // WelcomeLabelMainScreenActivity
            // 
            this.WelcomeLabelMainScreenActivity.AutoSize = true;
            this.WelcomeLabelMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabelMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeLabelMainScreenActivity.Location = new System.Drawing.Point(42, 11);
            this.WelcomeLabelMainScreenActivity.Name = "WelcomeLabelMainScreenActivity";
            this.WelcomeLabelMainScreenActivity.Size = new System.Drawing.Size(130, 28);
            this.WelcomeLabelMainScreenActivity.TabIndex = 4;
            this.WelcomeLabelMainScreenActivity.Text = "Dear "+user.UserFirstName+", happy learning!";
            // 
            // SidePanelMainScreenActivity
            // 
            this.SidePanelMainScreenActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SidePanelMainScreenActivity.Controls.Add(this.SidePanel1);
            this.SidePanelMainScreenActivity.Controls.Add(this.ScheduleIconMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.CourseIconMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.ToDoIconMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.FlashcardIconMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.HomeIconMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.ScheduleButtonMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.SidePanel3MainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.CourseButtonMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.FlashcardButtonMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.ToDoButtonMainScreenActivity);
            this.SidePanelMainScreenActivity.Controls.Add(this.HomeButtonMainScreenActivity);
            this.SidePanelMainScreenActivity.Location = new System.Drawing.Point(0, 0);
            this.SidePanelMainScreenActivity.Name = "SidePanelMainScreenActivity";
            this.SidePanelMainScreenActivity.Size = new System.Drawing.Size(206, 583);
            this.SidePanelMainScreenActivity.TabIndex = 1;
            this.SidePanelMainScreenActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(15)))), ((int)(((byte)(51)))));
            this.SidePanel1.Location = new System.Drawing.Point(0, 172);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(10, 62);
            this.SidePanel1.TabIndex = 2;
            // 
            // ScheduleIconMainScreenActivity
            // 
            this.ScheduleIconMainScreenActivity.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleIconMainScreenActivity.Image")));
            this.ScheduleIconMainScreenActivity.Location = new System.Drawing.Point(26, 435);
            this.ScheduleIconMainScreenActivity.Name = "ScheduleIconMainScreenActivity";
            this.ScheduleIconMainScreenActivity.Size = new System.Drawing.Size(32, 32);
            this.ScheduleIconMainScreenActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ScheduleIconMainScreenActivity.TabIndex = 11;
            this.ScheduleIconMainScreenActivity.TabStop = false;
            // 
            // CourseIconMainScreenActivity
            // 
            this.CourseIconMainScreenActivity.Image = ((System.Drawing.Image)(resources.GetObject("CourseIconMainScreenActivity.Image")));
            this.CourseIconMainScreenActivity.Location = new System.Drawing.Point(26, 373);
            this.CourseIconMainScreenActivity.Name = "CourseIconMainScreenActivity";
            this.CourseIconMainScreenActivity.Size = new System.Drawing.Size(32, 32);
            this.CourseIconMainScreenActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CourseIconMainScreenActivity.TabIndex = 10;
            this.CourseIconMainScreenActivity.TabStop = false;
            // 
            // ToDoIconMainScreenActivity
            // 
            this.ToDoIconMainScreenActivity.Image = ((System.Drawing.Image)(resources.GetObject("ToDoIconMainScreenActivity.Image")));
            this.ToDoIconMainScreenActivity.Location = new System.Drawing.Point(26, 249);
            this.ToDoIconMainScreenActivity.Name = "ToDoIconMainScreenActivity";
            this.ToDoIconMainScreenActivity.Size = new System.Drawing.Size(32, 32);
            this.ToDoIconMainScreenActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ToDoIconMainScreenActivity.TabIndex = 9;
            this.ToDoIconMainScreenActivity.TabStop = false;
            // 
            // FlashcardIconMainScreenActivity
            // 
            this.FlashcardIconMainScreenActivity.Image = ((System.Drawing.Image)(resources.GetObject("FlashcardIconMainScreenActivity.Image")));
            this.FlashcardIconMainScreenActivity.Location = new System.Drawing.Point(26, 311);
            this.FlashcardIconMainScreenActivity.Name = "FlashcardIconMainScreenActivity";
            this.FlashcardIconMainScreenActivity.Size = new System.Drawing.Size(32, 32);
            this.FlashcardIconMainScreenActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FlashcardIconMainScreenActivity.TabIndex = 8;
            this.FlashcardIconMainScreenActivity.TabStop = false;
            // 
            // HomeIconMainScreenActivity
            // 
            this.HomeIconMainScreenActivity.Image = ((System.Drawing.Image)(resources.GetObject("HomeIconMainScreenActivity.Image")));
            this.HomeIconMainScreenActivity.Location = new System.Drawing.Point(26, 186);
            this.HomeIconMainScreenActivity.Name = "HomeIconMainScreenActivity";
            this.HomeIconMainScreenActivity.Size = new System.Drawing.Size(32, 32);
            this.HomeIconMainScreenActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HomeIconMainScreenActivity.TabIndex = 2;
            this.HomeIconMainScreenActivity.TabStop = false;
            // 
            // ScheduleButtonMainScreenActivity
            // 
            this.ScheduleButtonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.ScheduleButtonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleButtonMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScheduleButtonMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScheduleButtonMainScreenActivity.Location = new System.Drawing.Point(0, 420);
            this.ScheduleButtonMainScreenActivity.Name = "ScheduleButtonMainScreenActivity";
            this.ScheduleButtonMainScreenActivity.Size = new System.Drawing.Size(206, 62);
            this.ScheduleButtonMainScreenActivity.TabIndex = 7;
            this.ScheduleButtonMainScreenActivity.Text = "   Schedule";
            this.ScheduleButtonMainScreenActivity.UseVisualStyleBackColor = true;
            // 
            // SidePanel3MainScreenActivity
            // 
            this.SidePanel3MainScreenActivity.BackColor = System.Drawing.Color.Cornsilk;
            this.SidePanel3MainScreenActivity.Controls.Add(this.SentinelLabelMainScreenActivity);
            this.SidePanel3MainScreenActivity.Controls.Add(this.ProjectLabelMainScreenActivity);
            this.SidePanel3MainScreenActivity.Controls.Add(this.MainIconMainScreenActivity);
            this.SidePanel3MainScreenActivity.Location = new System.Drawing.Point(0, 0);
            this.SidePanel3MainScreenActivity.Name = "SidePanel3MainScreenActivity";
            this.SidePanel3MainScreenActivity.Size = new System.Drawing.Size(206, 166);
            this.SidePanel3MainScreenActivity.TabIndex = 2;
            this.SidePanel3MainScreenActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // SentinelLabelMainScreenActivity
            // 
            this.SentinelLabelMainScreenActivity.AutoSize = true;
            this.SentinelLabelMainScreenActivity.Font = new System.Drawing.Font("Castellar", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentinelLabelMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SentinelLabelMainScreenActivity.Location = new System.Drawing.Point(31, 118);
            this.SentinelLabelMainScreenActivity.Name = "SentinelLabelMainScreenActivity";
            this.SentinelLabelMainScreenActivity.Size = new System.Drawing.Size(152, 33);
            this.SentinelLabelMainScreenActivity.TabIndex = 3;
            this.SentinelLabelMainScreenActivity.Text = "Sentinel";
            // 
            // ProjectLabelMainScreenActivity
            // 
            this.ProjectLabelMainScreenActivity.AutoSize = true;
            this.ProjectLabelMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLabelMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProjectLabelMainScreenActivity.Location = new System.Drawing.Point(53, 87);
            this.ProjectLabelMainScreenActivity.Name = "ProjectLabelMainScreenActivity";
            this.ProjectLabelMainScreenActivity.Size = new System.Drawing.Size(108, 33);
            this.ProjectLabelMainScreenActivity.TabIndex = 8;
            this.ProjectLabelMainScreenActivity.Text = "Project";
            // 
            // MainIconMainScreenActivity
            // 
            this.MainIconMainScreenActivity.Image = ((System.Drawing.Image)(resources.GetObject("MainIconMainScreenActivity.Image")));
            this.MainIconMainScreenActivity.Location = new System.Drawing.Point(59, 3);
            this.MainIconMainScreenActivity.Name = "MainIconMainScreenActivity";
            this.MainIconMainScreenActivity.Size = new System.Drawing.Size(96, 81);
            this.MainIconMainScreenActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainIconMainScreenActivity.TabIndex = 5;
            this.MainIconMainScreenActivity.TabStop = false;
            // 
            // CourseButtonMainScreenActivity
            // 
            this.CourseButtonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.CourseButtonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseButtonMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CourseButtonMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CourseButtonMainScreenActivity.Location = new System.Drawing.Point(0, 358);
            this.CourseButtonMainScreenActivity.Name = "CourseButtonMainScreenActivity";
            this.CourseButtonMainScreenActivity.Size = new System.Drawing.Size(206, 62);
            this.CourseButtonMainScreenActivity.TabIndex = 6;
            this.CourseButtonMainScreenActivity.Text = "   Course";
            this.CourseButtonMainScreenActivity.UseVisualStyleBackColor = true;
            // 
            // FlashcardButtonMainScreenActivity
            // 
            this.FlashcardButtonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.FlashcardButtonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlashcardButtonMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlashcardButtonMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FlashcardButtonMainScreenActivity.Location = new System.Drawing.Point(0, 296);
            this.FlashcardButtonMainScreenActivity.Name = "FlashcardButtonMainScreenActivity";
            this.FlashcardButtonMainScreenActivity.Size = new System.Drawing.Size(206, 62);
            this.FlashcardButtonMainScreenActivity.TabIndex = 5;
            this.FlashcardButtonMainScreenActivity.Text = "   Flashcard";
            this.FlashcardButtonMainScreenActivity.UseVisualStyleBackColor = true;
            this.FlashcardButtonMainScreenActivity.Click += new System.EventHandler(this.FlashcardButton_Click);
            // 
            // ToDoButtonMainScreenActivity
            // 
            this.ToDoButtonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.ToDoButtonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDoButtonMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToDoButtonMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToDoButtonMainScreenActivity.Location = new System.Drawing.Point(0, 234);
            this.ToDoButtonMainScreenActivity.Name = "ToDoButtonMainScreenActivity";
            this.ToDoButtonMainScreenActivity.Size = new System.Drawing.Size(206, 62);
            this.ToDoButtonMainScreenActivity.TabIndex = 4;
            this.ToDoButtonMainScreenActivity.Text = "   To Do";
            this.ToDoButtonMainScreenActivity.UseVisualStyleBackColor = true;
            this.ToDoButtonMainScreenActivity.Click += new System.EventHandler(this.ToDoButton_Click);
            // 
            // HomeButtonMainScreenActivity
            // 
            this.HomeButtonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.HomeButtonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButtonMainScreenActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButtonMainScreenActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HomeButtonMainScreenActivity.Location = new System.Drawing.Point(0, 172);
            this.HomeButtonMainScreenActivity.Name = "HomeButtonMainScreenActivity";
            this.HomeButtonMainScreenActivity.Size = new System.Drawing.Size(206, 62);
            this.HomeButtonMainScreenActivity.TabIndex = 2;
            this.HomeButtonMainScreenActivity.Text = "   Home";
            this.HomeButtonMainScreenActivity.UseVisualStyleBackColor = true;
            this.HomeButtonMainScreenActivity.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MainPanelMainScreenActivity
            // 
            this.MainPanelMainScreenActivity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanelMainScreenActivity.Controls.Add(this.HomeControlMainScreenActivity);
            this.MainPanelMainScreenActivity.Controls.Add(this.ToDoControlMainScreenActivity);
            this.MainPanelMainScreenActivity.Controls.Add(this.FlashcardControlMainScreenActivity);
            this.MainPanelMainScreenActivity.Location = new System.Drawing.Point(206, 53);
            this.MainPanelMainScreenActivity.Name = "MainPanelMainScreenActivity";
            this.MainPanelMainScreenActivity.Size = new System.Drawing.Size(902, 530);
            this.MainPanelMainScreenActivity.TabIndex = 2;
            // 
            // HomeControlMainScreenActivity
            // 
            this.HomeControlMainScreenActivity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HomeControlMainScreenActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeControlMainScreenActivity.Location = new System.Drawing.Point(0, 0);
            this.HomeControlMainScreenActivity.Name = "HomeControlMainScreenActivity";
            this.HomeControlMainScreenActivity.Size = new System.Drawing.Size(902, 530);
            this.HomeControlMainScreenActivity.TabIndex = 1;
            // 
            // ToDoControlMainScreenActivity
            // 
            this.ToDoControlMainScreenActivity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToDoControlMainScreenActivity.Location = new System.Drawing.Point(0, 0);
            this.ToDoControlMainScreenActivity.Name = "ToDoControlMainScreenActivity";
            this.ToDoControlMainScreenActivity.Size = new System.Drawing.Size(902, 549);
            this.ToDoControlMainScreenActivity.TabIndex = 0;
            //this.ToDoControlMainScreenActivity.Load += new System.EventHandler(this.ToDoControl_Load);
            // 
            // FlashcardControlMainScreenActivity
            // 
            this.FlashcardControlMainScreenActivity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FlashcardControlMainScreenActivity.Location = new System.Drawing.Point(0, 0);
            this.FlashcardControlMainScreenActivity.Name = "FlashcardControlMainScreenActivity";
            this.FlashcardControlMainScreenActivity.Size = new System.Drawing.Size(902, 549);
            this.FlashcardControlMainScreenActivity.TabIndex = 2;
            // 
            // MainScreenActivity
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1106, 582);
            this.Controls.Add(this.TopPanelMainScreenActivity);
            this.Controls.Add(this.MainPanelMainScreenActivity);
            this.Controls.Add(this.SidePanelMainScreenActivity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreenActivity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "You Can Learn Anything | Project Sentinel";
            this.Load += new System.EventHandler(this.MainScreenActivity_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.UserIconMainScreenActivity)).EndInit();
            this.TopPanelMainScreenActivity.ResumeLayout(false);
            this.TopPanelMainScreenActivity.PerformLayout();
            this.SidePanelMainScreenActivity.ResumeLayout(false);
            this.SidePanelMainScreenActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleIconMainScreenActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseIconMainScreenActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoIconMainScreenActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlashcardIconMainScreenActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconMainScreenActivity)).EndInit();
            this.SidePanel3MainScreenActivity.ResumeLayout(false);
            this.SidePanel3MainScreenActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainIconMainScreenActivity)).EndInit();
            this.MainPanelMainScreenActivity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox UserIconMainScreenActivity;
        private System.Windows.Forms.Button userLogoutbuttonMainScreenActivity;
        private System.Windows.Forms.Button MyProfileButonMainScreenActivity;
        private System.Windows.Forms.Button SettingsButtonMainScreenActivity;
        private System.Windows.Forms.Panel TopPanelMainScreenActivity;
        private System.Windows.Forms.Label WelcomeLabelMainScreenActivity;
        private System.Windows.Forms.Panel SidePanelMainScreenActivity;
        private System.Windows.Forms.Button CourseButtonMainScreenActivity;
        private System.Windows.Forms.Button FlashcardButtonMainScreenActivity;
        private System.Windows.Forms.Button ToDoButtonMainScreenActivity;
        private System.Windows.Forms.Button HomeButtonMainScreenActivity;
        private System.Windows.Forms.Panel SidePanel3MainScreenActivity;
        private System.Windows.Forms.Label SentinelLabelMainScreenActivity;
        private System.Windows.Forms.Label ProjectLabelMainScreenActivity;
        private System.Windows.Forms.PictureBox MainIconMainScreenActivity;
        private System.Windows.Forms.Button ScheduleButtonMainScreenActivity;
        private System.Windows.Forms.Panel SidePanel1;
        private System.Windows.Forms.PictureBox ScheduleIconMainScreenActivity;
        private System.Windows.Forms.PictureBox CourseIconMainScreenActivity;
        private System.Windows.Forms.PictureBox ToDoIconMainScreenActivity;
        private System.Windows.Forms.PictureBox FlashcardIconMainScreenActivity;
        private System.Windows.Forms.PictureBox HomeIconMainScreenActivity;
        private System.Windows.Forms.Panel MainPanelMainScreenActivity;
        private HomeControl HomeControlMainScreenActivity;
        private ToDoControl ToDoControlMainScreenActivity;
        private FlashcardControl FlashcardControlMainScreenActivity;
    }
}