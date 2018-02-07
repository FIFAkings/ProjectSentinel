namespace ProjectSentinel
{
    partial class FlashcardForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FlashFront = new ProjectSentinel.FlashcardFront();
            this.FlashBack = new ProjectSentinel.FlashcardBack();
            this.FrontFlashcardButtonFlashcardForm = new System.Windows.Forms.Button();
            this.FrontcardBackFlashcardForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(147, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(105, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 23);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(105, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 23);
            this.textBox2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Course:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlashFront);
            this.groupBox1.Controls.Add(this.FlashBack);
            this.groupBox1.Location = new System.Drawing.Point(73, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 271);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // FlashFront
            // 
            this.FlashFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(118)))));
            this.FlashFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FlashFront.Location = new System.Drawing.Point(0, 0);
            this.FlashFront.Name = "FlashFront";
            this.FlashFront.Size = new System.Drawing.Size(239, 271);
            this.FlashFront.TabIndex = 0;
            // 
            // FlashBack
            // 
            this.FlashBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(118)))));
            this.FlashBack.Location = new System.Drawing.Point(0, 0);
            this.FlashBack.Name = "FlashBack";
            this.FlashBack.Size = new System.Drawing.Size(239, 271);
            this.FlashBack.TabIndex = 1;
            // 
            // FrontFlashcardButtonFlashcardForm
            // 
            this.FrontFlashcardButtonFlashcardForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FrontFlashcardButtonFlashcardForm.FlatAppearance.BorderSize = 0;
            this.FrontFlashcardButtonFlashcardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrontFlashcardButtonFlashcardForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FrontFlashcardButtonFlashcardForm.Location = new System.Drawing.Point(73, 438);
            this.FrontFlashcardButtonFlashcardForm.Name = "FrontFlashcardButtonFlashcardForm";
            this.FrontFlashcardButtonFlashcardForm.Size = new System.Drawing.Size(66, 29);
            this.FrontFlashcardButtonFlashcardForm.TabIndex = 23;
            this.FrontFlashcardButtonFlashcardForm.Text = "Front";
            this.FrontFlashcardButtonFlashcardForm.UseVisualStyleBackColor = true;
            this.FrontFlashcardButtonFlashcardForm.Click += new System.EventHandler(this.FrontFlashcardButtonFlashcardForm_Click);
            // 
            // FrontcardBackFlashcardForm
            // 
            this.FrontcardBackFlashcardForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FrontcardBackFlashcardForm.FlatAppearance.BorderSize = 0;
            this.FrontcardBackFlashcardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrontcardBackFlashcardForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FrontcardBackFlashcardForm.Location = new System.Drawing.Point(246, 438);
            this.FrontcardBackFlashcardForm.Name = "FrontcardBackFlashcardForm";
            this.FrontcardBackFlashcardForm.Size = new System.Drawing.Size(66, 29);
            this.FrontcardBackFlashcardForm.TabIndex = 24;
            this.FrontcardBackFlashcardForm.Text = "Back";
            this.FrontcardBackFlashcardForm.UseVisualStyleBackColor = true;
            this.FrontcardBackFlashcardForm.Click += new System.EventHandler(this.FrontcardBackFlashcardForm_Click);
            // 
            // FlashcardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(388, 560);
            this.Controls.Add(this.FrontcardBackFlashcardForm);
            this.Controls.Add(this.FrontFlashcardButtonFlashcardForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FlashcardForm";
            this.Text = "FlashcardForm";
            this.Load += new System.EventHandler(this.FlashcardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private FlashcardFront FlashFront;
        private FlashcardBack FlashBack;
        private System.Windows.Forms.Button FrontFlashcardButtonFlashcardForm;
        private System.Windows.Forms.Button FrontcardBackFlashcardForm;
    }
}