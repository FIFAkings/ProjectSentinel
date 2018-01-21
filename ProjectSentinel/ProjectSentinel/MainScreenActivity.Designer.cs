namespace ProjectSentinel
{
    partial class MainScreenActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenActivity));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userLogoutbuttonMainScreenActivity = new System.Windows.Forms.Button();
            this.MyProfileButon = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.NewsButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(748, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // userLogoutbuttonMainScreenActivity
            // 
            this.userLogoutbuttonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogoutbuttonMainScreenActivity.Location = new System.Drawing.Point(649, 0);
            this.userLogoutbuttonMainScreenActivity.Name = "userLogoutbuttonMainScreenActivity";
            this.userLogoutbuttonMainScreenActivity.Size = new System.Drawing.Size(94, 58);
            this.userLogoutbuttonMainScreenActivity.TabIndex = 1;
            this.userLogoutbuttonMainScreenActivity.Text = "Log Out";
            this.userLogoutbuttonMainScreenActivity.UseVisualStyleBackColor = true;
            this.userLogoutbuttonMainScreenActivity.Click += new System.EventHandler(this.userLogoutbuttonMainScreenActivity_Click);
            // 
            // MyProfileButon
            // 
            this.MyProfileButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyProfileButon.Location = new System.Drawing.Point(461, 0);
            this.MyProfileButon.Name = "MyProfileButon";
            this.MyProfileButon.Size = new System.Drawing.Size(94, 58);
            this.MyProfileButon.TabIndex = 2;
            this.MyProfileButon.Text = "MyProfile";
            this.MyProfileButon.UseVisualStyleBackColor = true;
            this.MyProfileButon.Click += new System.EventHandler(this.MyProfileButon_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(555, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(94, 58);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // NewsButton
            // 
            this.NewsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsButton.Location = new System.Drawing.Point(367, 0);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.Size = new System.Drawing.Size(94, 58);
            this.NewsButton.TabIndex = 3;
            this.NewsButton.Text = "News";
            this.NewsButton.UseVisualStyleBackColor = true;
            this.NewsButton.Click += new System.EventHandler(this.NewsButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.NewsButton);
            this.panel5.Controls.Add(this.SettingsButton);
            this.panel5.Controls.Add(this.MyProfileButon);
            this.panel5.Controls.Add(this.userLogoutbuttonMainScreenActivity);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(203, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(799, 59);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome User";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(-3, -18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 639);
            this.panel6.TabIndex = 1;
            // 
            // MainScreenActivity
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 608);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainScreenActivity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.MainScreenActivity_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button userLogoutbuttonMainScreenActivity;
        private System.Windows.Forms.Button MyProfileButon;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button NewsButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
    }
}