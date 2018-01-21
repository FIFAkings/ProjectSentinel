namespace ProjectSentinel
{
    partial class LoginActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginActivity));
            this.userUsernameLabelLoginActivity = new System.Windows.Forms.Label();
            this.userPasswrodLabelLoginActivity = new System.Windows.Forms.Label();
            this.userPasswordInputLoginActivity = new System.Windows.Forms.TextBox();
            this.userUsernameInputLoginActivity = new System.Windows.Forms.TextBox();
            this.forgotPasswordLabelLoginActivity = new System.Windows.Forms.Label();
            this.userLoginButtonLoginActivity = new System.Windows.Forms.Button();
            this.userRegisterButtonLoginActivity = new System.Windows.Forms.Button();
            this.ProjectSentinelTempLoginActivity = new System.Windows.Forms.PictureBox();
            this.notAMemberLabelLoginActivity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSentinelTempLoginActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // userUsernameLabelLoginActivity
            // 
            this.userUsernameLabelLoginActivity.AutoSize = true;
            this.userUsernameLabelLoginActivity.Location = new System.Drawing.Point(31, 56);
            this.userUsernameLabelLoginActivity.Name = "userUsernameLabelLoginActivity";
            this.userUsernameLabelLoginActivity.Size = new System.Drawing.Size(61, 13);
            this.userUsernameLabelLoginActivity.TabIndex = 0;
            this.userUsernameLabelLoginActivity.Text = "Username: ";
            // 
            // userPasswrodLabelLoginActivity
            // 
            this.userPasswrodLabelLoginActivity.AutoSize = true;
            this.userPasswrodLabelLoginActivity.Location = new System.Drawing.Point(31, 99);
            this.userPasswrodLabelLoginActivity.Name = "userPasswrodLabelLoginActivity";
            this.userPasswrodLabelLoginActivity.Size = new System.Drawing.Size(59, 13);
            this.userPasswrodLabelLoginActivity.TabIndex = 1;
            this.userPasswrodLabelLoginActivity.Text = "Password: ";
            this.userPasswrodLabelLoginActivity.Click += new System.EventHandler(this.label2_Click);
            // 
            // userPasswordInputLoginActivity
            // 
            this.userPasswordInputLoginActivity.Location = new System.Drawing.Point(96, 96);
            this.userPasswordInputLoginActivity.Name = "userPasswordInputLoginActivity";
            this.userPasswordInputLoginActivity.Size = new System.Drawing.Size(146, 20);
            this.userPasswordInputLoginActivity.TabIndex = 2;
            // 
            // userUsernameInputLoginActivity
            // 
            this.userUsernameInputLoginActivity.Location = new System.Drawing.Point(96, 53);
            this.userUsernameInputLoginActivity.Name = "userUsernameInputLoginActivity";
            this.userUsernameInputLoginActivity.Size = new System.Drawing.Size(146, 20);
            this.userUsernameInputLoginActivity.TabIndex = 3;
            // 
            // forgotPasswordLabelLoginActivity
            // 
            this.forgotPasswordLabelLoginActivity.AutoSize = true;
            this.forgotPasswordLabelLoginActivity.Location = new System.Drawing.Point(125, 119);
            this.forgotPasswordLabelLoginActivity.Name = "forgotPasswordLabelLoginActivity";
            this.forgotPasswordLabelLoginActivity.Size = new System.Drawing.Size(117, 13);
            this.forgotPasswordLabelLoginActivity.TabIndex = 4;
            this.forgotPasswordLabelLoginActivity.Text = "Forgot your password ?";
            this.forgotPasswordLabelLoginActivity.Click += new System.EventHandler(this.label3_Click);
            // 
            // userLoginButtonLoginActivity
            // 
            this.userLoginButtonLoginActivity.Location = new System.Drawing.Point(34, 190);
            this.userLoginButtonLoginActivity.Name = "userLoginButtonLoginActivity";
            this.userLoginButtonLoginActivity.Size = new System.Drawing.Size(87, 23);
            this.userLoginButtonLoginActivity.TabIndex = 5;
            this.userLoginButtonLoginActivity.Text = "Log In";
            this.userLoginButtonLoginActivity.UseVisualStyleBackColor = true;
            this.userLoginButtonLoginActivity.Click += new System.EventHandler(this.userLoginButtonLoginActivity_Click);
            // 
            // userRegisterButtonLoginActivity
            // 
            this.userRegisterButtonLoginActivity.Location = new System.Drawing.Point(155, 190);
            this.userRegisterButtonLoginActivity.Name = "userRegisterButtonLoginActivity";
            this.userRegisterButtonLoginActivity.Size = new System.Drawing.Size(87, 23);
            this.userRegisterButtonLoginActivity.TabIndex = 6;
            this.userRegisterButtonLoginActivity.Text = "Register";
            this.userRegisterButtonLoginActivity.UseVisualStyleBackColor = true;
            this.userRegisterButtonLoginActivity.Click += new System.EventHandler(this.userRegisterButtonLoginActivity_Click);
            // 
            // ProjectSentinelTempLoginActivity
            // 
            this.ProjectSentinelTempLoginActivity.Image = ((System.Drawing.Image)(resources.GetObject("ProjectSentinelTempLoginActivity.Image")));
            this.ProjectSentinelTempLoginActivity.Location = new System.Drawing.Point(300, 35);
            this.ProjectSentinelTempLoginActivity.Name = "ProjectSentinelTempLoginActivity";
            this.ProjectSentinelTempLoginActivity.Size = new System.Drawing.Size(124, 114);
            this.ProjectSentinelTempLoginActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProjectSentinelTempLoginActivity.TabIndex = 7;
            this.ProjectSentinelTempLoginActivity.TabStop = false;
            // 
            // notAMemberLabelLoginActivity
            // 
            this.notAMemberLabelLoginActivity.AutoSize = true;
            this.notAMemberLabelLoginActivity.Location = new System.Drawing.Point(160, 174);
            this.notAMemberLabelLoginActivity.Name = "notAMemberLabelLoginActivity";
            this.notAMemberLabelLoginActivity.Size = new System.Drawing.Size(82, 13);
            this.notAMemberLabelLoginActivity.TabIndex = 8;
            this.notAMemberLabelLoginActivity.Text = "Not a member ?";
            // 
            // LoginActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 260);
            this.Controls.Add(this.notAMemberLabelLoginActivity);
            this.Controls.Add(this.ProjectSentinelTempLoginActivity);
            this.Controls.Add(this.userRegisterButtonLoginActivity);
            this.Controls.Add(this.userLoginButtonLoginActivity);
            this.Controls.Add(this.forgotPasswordLabelLoginActivity);
            this.Controls.Add(this.userUsernameInputLoginActivity);
            this.Controls.Add(this.userPasswordInputLoginActivity);
            this.Controls.Add(this.userPasswrodLabelLoginActivity);
            this.Controls.Add(this.userUsernameLabelLoginActivity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In | Project Sentinel";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSentinelTempLoginActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userUsernameLabelLoginActivity;
        private System.Windows.Forms.Label userPasswrodLabelLoginActivity;
        private System.Windows.Forms.TextBox userPasswordInputLoginActivity;
        private System.Windows.Forms.TextBox userUsernameInputLoginActivity;
        private System.Windows.Forms.Label forgotPasswordLabelLoginActivity;
        private System.Windows.Forms.Button userLoginButtonLoginActivity;
        private System.Windows.Forms.Button userRegisterButtonLoginActivity;
        private System.Windows.Forms.PictureBox ProjectSentinelTempLoginActivity;
        private System.Windows.Forms.Label notAMemberLabelLoginActivity;
    }
}

