namespace intelli_tutor_frontend
{
    partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.StudentInfo = new System.Windows.Forms.Panel();
            this.session = new System.Windows.Forms.TextBox();
            this.semester = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Teacher_Role = new System.Windows.Forms.Panel();
            this.qualification = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.designationComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BasicInfo = new System.Windows.Forms.Panel();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StudentInfo.SuspendLayout();
            this.Teacher_Role.SuspendLayout();
            this.BasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.StudentInfo);
            this.panel1.Controls.Add(this.Teacher_Role);
            this.panel1.Controls.Add(this.BasicInfo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1773, 923);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1283, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 686);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::intelli_tutor_frontend.Properties.Resources.GTH;
            this.pictureBox1.Location = new System.Drawing.Point(4, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 620);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(389, 738);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(244, 55);
            this.registerBtn.TabIndex = 12;
            this.registerBtn.Text = "Register YouSelf!";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // StudentInfo
            // 
            this.StudentInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentInfo.Controls.Add(this.session);
            this.StudentInfo.Controls.Add(this.semester);
            this.StudentInfo.Controls.Add(this.label9);
            this.StudentInfo.Controls.Add(this.label8);
            this.StudentInfo.Location = new System.Drawing.Point(15, 567);
            this.StudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.Size = new System.Drawing.Size(853, 116);
            this.StudentInfo.TabIndex = 11;
            this.StudentInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentInfo_Paint);
            // 
            // session
            // 
            this.session.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session.Location = new System.Drawing.Point(375, 17);
            this.session.Margin = new System.Windows.Forms.Padding(4);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(441, 37);
            this.session.TabIndex = 16;
            // 
            // semester
            // 
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.Location = new System.Drawing.Point(374, 72);
            this.semester.Margin = new System.Windows.Forms.Padding(4);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(441, 37);
            this.semester.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label9.Location = new System.Drawing.Point(108, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "Current Semester";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label8.Location = new System.Drawing.Point(117, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Session";
            // 
            // Teacher_Role
            // 
            this.Teacher_Role.Controls.Add(this.qualification);
            this.Teacher_Role.Controls.Add(this.label10);
            this.Teacher_Role.Controls.Add(this.designationComboBox);
            this.Teacher_Role.Controls.Add(this.label7);
            this.Teacher_Role.Location = new System.Drawing.Point(15, 567);
            this.Teacher_Role.Margin = new System.Windows.Forms.Padding(4);
            this.Teacher_Role.Name = "Teacher_Role";
            this.Teacher_Role.Size = new System.Drawing.Size(852, 116);
            this.Teacher_Role.TabIndex = 10;
            // 
            // qualification
            // 
            this.qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualification.Location = new System.Drawing.Point(375, 75);
            this.qualification.Margin = new System.Windows.Forms.Padding(4);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(440, 37);
            this.qualification.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label10.Location = new System.Drawing.Point(117, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 31);
            this.label10.TabIndex = 19;
            this.label10.Text = "Qualification";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // designationComboBox
            // 
            this.designationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationComboBox.FormattingEnabled = true;
            this.designationComboBox.Items.AddRange(new object[] {
            "Lecturer",
            "Professor",
            "Assistant Professor",
            "Teacher Assistant"});
            this.designationComboBox.Location = new System.Drawing.Point(375, 17);
            this.designationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.designationComboBox.Name = "designationComboBox";
            this.designationComboBox.Size = new System.Drawing.Size(440, 38);
            this.designationComboBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(117, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Designation";
            // 
            // BasicInfo
            // 
            this.BasicInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BasicInfo.Controls.Add(this.roleComboBox);
            this.BasicInfo.Controls.Add(this.label6);
            this.BasicInfo.Controls.Add(this.label4);
            this.BasicInfo.Controls.Add(this.label3);
            this.BasicInfo.Controls.Add(this.label2);
            this.BasicInfo.Controls.Add(this.label1);
            this.BasicInfo.Controls.Add(this.cPassword);
            this.BasicInfo.Controls.Add(this.password);
            this.BasicInfo.Controls.Add(this.email);
            this.BasicInfo.Controls.Add(this.username);
            this.BasicInfo.Location = new System.Drawing.Point(15, 162);
            this.BasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.BasicInfo.Name = "BasicInfo";
            this.BasicInfo.Size = new System.Drawing.Size(852, 398);
            this.BasicInfo.TabIndex = 9;
            this.BasicInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.BasicInfo_Paint);
            // 
            // roleComboBox
            // 
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.roleComboBox.Location = new System.Drawing.Point(375, 340);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(440, 38);
            this.roleComboBox.TabIndex = 17;
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(117, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(108, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(117, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pasword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(132, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cPassword
            // 
            this.cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPassword.Location = new System.Drawing.Point(375, 262);
            this.cPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cPassword.Name = "cPassword";
            this.cPassword.Size = new System.Drawing.Size(440, 37);
            this.cPassword.TabIndex = 11;
            this.cPassword.TextChanged += new System.EventHandler(this.ConPassTB_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(375, 187);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(440, 37);
            this.password.TabIndex = 10;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(375, 112);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(440, 37);
            this.email.TabIndex = 9;
            this.email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(375, 28);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(440, 37);
            this.username.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(725, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Register YourSelf";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // contextMenuStrip1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 504);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1773, 922);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.ShowIcon = false;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.Resize += new System.EventHandler(this.Register_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StudentInfo.ResumeLayout(false);
            this.StudentInfo.PerformLayout();
            this.Teacher_Role.ResumeLayout(false);
            this.Teacher_Role.PerformLayout();
            this.BasicInfo.ResumeLayout(false);
            this.BasicInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel BasicInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Teacher_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel StudentInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox session;
        private System.Windows.Forms.TextBox semester;
        private System.Windows.Forms.ComboBox designationComboBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox qualification;
    }
}