namespace ProjectSentinel
{
    partial class ScheduleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScheduleControl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScheduleControl1
            // 
            this.ScheduleControl1.AutoSize = true;
            this.ScheduleControl1.Location = new System.Drawing.Point(378, 146);
            this.ScheduleControl1.Name = "ScheduleControl1";
            this.ScheduleControl1.Size = new System.Drawing.Size(41, 13);
            this.ScheduleControl1.TabIndex = 0;
            this.ScheduleControl1.Text = "Škeđul";
            // 
            // ScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScheduleControl1);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(902, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScheduleControl1;
    }
}
