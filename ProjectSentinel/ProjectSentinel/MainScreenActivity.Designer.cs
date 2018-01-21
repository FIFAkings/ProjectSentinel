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
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.userLogoutbuttonMainScreenActivity = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.userLogoutbuttonMainScreenActivity);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(-3, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1005, 58);
            this.panel5.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(568, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "News";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(747, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 58);
            this.button6.TabIndex = 3;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(656, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 58);
            this.button5.TabIndex = 2;
            this.button5.Text = "MyProfile";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // userLogoutbuttonMainScreenActivity
            // 
            this.userLogoutbuttonMainScreenActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLogoutbuttonMainScreenActivity.Location = new System.Drawing.Point(838, 0);
            this.userLogoutbuttonMainScreenActivity.Name = "userLogoutbuttonMainScreenActivity";
            this.userLogoutbuttonMainScreenActivity.Size = new System.Drawing.Size(94, 58);
            this.userLogoutbuttonMainScreenActivity.TabIndex = 1;
            this.userLogoutbuttonMainScreenActivity.Text = "Log Out";
            this.userLogoutbuttonMainScreenActivity.UseVisualStyleBackColor = true;
            this.userLogoutbuttonMainScreenActivity.Click += new System.EventHandler(this.userLogoutbuttonMainScreenActivity_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(948, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MainScreenActivity
            // 
            this.ClientSize = new System.Drawing.Size(1002, 603);
            this.Controls.Add(this.panel5);
            this.Name = "MainScreenActivity";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button userLogoutbuttonMainScreenActivity;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}