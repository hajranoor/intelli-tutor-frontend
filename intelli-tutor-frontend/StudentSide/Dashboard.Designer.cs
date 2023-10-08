using FontAwesome.Sharp;
using System.Drawing;

namespace intelli_tutor_frontend.StudentSide
{
    partial class Dashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.accountIcon = new System.Windows.Forms.PictureBox();
            this.formName = new System.Windows.Forms.Label();
            this.currentUser = new System.Windows.Forms.Label();
            this.notificationIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.34806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.65194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 747);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 20, 5, 0);
            this.label1.Size = new System.Drawing.Size(371, 152);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intelli Tutor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.availableCoursesToolStripMenuItem,
            this.myCoursesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 152);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(371, 595);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.dashboardToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(181, 45);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // availableCoursesToolStripMenuItem
            // 
            this.availableCoursesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.availableCoursesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.availableCoursesToolStripMenuItem.Name = "availableCoursesToolStripMenuItem";
            this.availableCoursesToolStripMenuItem.Size = new System.Drawing.Size(245, 41);
            this.availableCoursesToolStripMenuItem.Text = "Available Courses";
            this.availableCoursesToolStripMenuItem.Click += new System.EventHandler(this.availableCoursesToolStripMenuItem_Click);
            // 
            // myCoursesToolStripMenuItem
            // 
            this.myCoursesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.myCoursesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.myCoursesToolStripMenuItem.Name = "myCoursesToolStripMenuItem";
            this.myCoursesToolStripMenuItem.Size = new System.Drawing.Size(174, 41);
            this.myCoursesToolStripMenuItem.Text = "My Courses";
            this.myCoursesToolStripMenuItem.Click += new System.EventHandler(this.myCoursesToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 2);
            this.label3.TabIndex = 3;
            this.label3.Text = "jdfdfnld";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.accountIcon, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.formName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.currentUser, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.notificationIcon, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(370, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(954, 100);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // accountIcon
            // 
            this.accountIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountIcon.Location = new System.Drawing.Point(765, 3);
            this.accountIcon.Name = "accountIcon";
            this.accountIcon.Size = new System.Drawing.Size(41, 94);
            this.accountIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.accountIcon.TabIndex = 3;
            this.accountIcon.TabStop = false;
            // 
            // formName
            // 
            this.formName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formName.ForeColor = System.Drawing.Color.White;
            this.formName.Location = new System.Drawing.Point(10, 34);
            this.formName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(162, 32);
            this.formName.TabIndex = 0;
            this.formName.Text = "Dashboard";
            // 
            // currentUser
            // 
            this.currentUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentUser.AutoSize = true;
            this.currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser.ForeColor = System.Drawing.Color.White;
            this.currentUser.Location = new System.Drawing.Point(819, 34);
            this.currentUser.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(117, 32);
            this.currentUser.TabIndex = 1;
            this.currentUser.Text = "Shanza";
            // 
            // notificationIcon
            // 
            this.notificationIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationIcon.Location = new System.Drawing.Point(718, 3);
            this.notificationIcon.Name = "notificationIcon";
            this.notificationIcon.Size = new System.Drawing.Size(41, 94);
            this.notificationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.notificationIcon.TabIndex = 2;
            this.notificationIcon.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 746);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1346, 791);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationIcon)).EndInit();
            this.ResumeLayout(false);

        }

        public virtual void dashboardData() { 

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myCoursesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label currentUser;
        private System.Windows.Forms.PictureBox accountIcon;
        private System.Windows.Forms.PictureBox notificationIcon;
    }
}