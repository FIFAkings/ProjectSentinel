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
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(842, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // userLogoutbuttonMainScreenActivity
            // 
            this.userLogoutbuttonMainScreenActivity.FlatAppearance.BorderSize = 0;
            this.userLogoutbuttonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogoutbuttonMainScreenActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLogoutbuttonMainScreenActivity.Location = new System.Drawing.Point(743, 0);
            this.userLogoutbuttonMainScreenActivity.Name = "userLogoutbuttonMainScreenActivity";
            this.userLogoutbuttonMainScreenActivity.Size = new System.Drawing.Size(94, 59);
            this.userLogoutbuttonMainScreenActivity.TabIndex = 1;
            this.userLogoutbuttonMainScreenActivity.Text = "Log Out";
            this.userLogoutbuttonMainScreenActivity.UseVisualStyleBackColor = true;
            this.userLogoutbuttonMainScreenActivity.Click += new System.EventHandler(this.userLogoutbuttonMainScreenActivity_Click);
            // 
            // MyProfileButon
            // 
            this.MyProfileButon.FlatAppearance.BorderSize = 0;
            this.MyProfileButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyProfileButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MyProfileButon.Location = new System.Drawing.Point(555, 0);
            this.MyProfileButon.Name = "MyProfileButon";
            this.MyProfileButon.Size = new System.Drawing.Size(94, 59);
            this.MyProfileButon.TabIndex = 2;
            this.MyProfileButon.Text = "MyProfile";
            this.MyProfileButon.UseVisualStyleBackColor = true;
            this.MyProfileButon.Click += new System.EventHandler(this.MyProfileButon_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.Location = new System.Drawing.Point(649, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(94, 59);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // NewsButton
            // 
            this.NewsButton.FlatAppearance.BorderSize = 0;
            this.NewsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewsButton.Location = new System.Drawing.Point(461, 0);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.Size = new System.Drawing.Size(94, 59);
            this.NewsButton.TabIndex = 3;
            this.NewsButton.Text = "News";
            this.NewsButton.UseVisualStyleBackColor = true;
            this.NewsButton.Click += new System.EventHandler(this.NewsButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(15)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.NewsButton);
            this.panel5.Controls.Add(this.SettingsButton);
            this.panel5.Controls.Add(this.MyProfileButon);
            this.panel5.Controls.Add(this.userLogoutbuttonMainScreenActivity);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(203, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 59);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 621);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 62);
            this.button6.TabIndex = 4;
            this.button6.Text = "button2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 62);
            this.button7.TabIndex = 5;
            this.button7.Text = "button3";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 284);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(206, 62);
            this.button8.TabIndex = 6;
            this.button8.Text = "button4";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(15)))), ((int)(((byte)(51)))));
            this.panel7.Location = new System.Drawing.Point(275, 80);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 2;
            // 
            // MainScreenActivity
            // 
            this.ClientSize = new System.Drawing.Size(1108, 601);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainScreenActivity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.MainScreenActivity_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
    }
}