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
            this.hekkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.accountIcon = new System.Windows.Forms.PictureBox();
            this.formName = new System.Windows.Forms.Label();
            this.currentUser = new System.Windows.Forms.Label();
            this.notificationIcon = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.34806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.65194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 934);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.label1.Padding = new System.Windows.Forms.Padding(6, 25, 6, 0);
            this.label1.Size = new System.Drawing.Size(417, 190);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intelli Tutor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.availableCoursesToolStripMenuItem,
            this.myCoursesToolStripMenuItem,
            this.hekkoToolStripMenuItem,
            this.notificationToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 190);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(22, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(417, 744);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.dashboardToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(216, 52);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // availableCoursesToolStripMenuItem
            // 
            this.availableCoursesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.availableCoursesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.availableCoursesToolStripMenuItem.Name = "availableCoursesToolStripMenuItem";
            this.availableCoursesToolStripMenuItem.Size = new System.Drawing.Size(321, 52);
            this.availableCoursesToolStripMenuItem.Text = "Available Courses";
            this.availableCoursesToolStripMenuItem.Click += new System.EventHandler(this.availableCoursesToolStripMenuItem_Click);
            // 
            // myCoursesToolStripMenuItem
            // 
            this.myCoursesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.myCoursesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.myCoursesToolStripMenuItem.Name = "myCoursesToolStripMenuItem";
            this.myCoursesToolStripMenuItem.Size = new System.Drawing.Size(226, 52);
            this.myCoursesToolStripMenuItem.Text = "My Courses";
            this.myCoursesToolStripMenuItem.Click += new System.EventHandler(this.myCoursesToolStripMenuItem_Click);
            // 
            // hekkoToolStripMenuItem
            // 
            this.hekkoToolStripMenuItem.Name = "hekkoToolStripMenuItem";
            this.hekkoToolStripMenuItem.Size = new System.Drawing.Size(16, 4);
            // 
            // notificationToolStripMenuItem1
            // 
            this.notificationToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.notificationToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.notificationToolStripMenuItem1.Name = "notificationToolStripMenuItem1";
            this.notificationToolStripMenuItem1.Size = new System.Drawing.Size(246, 52);
            this.notificationToolStripMenuItem1.Text = "Notifications";
            this.notificationToolStripMenuItem1.Click += new System.EventHandler(this.notificationToolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 2);
            this.label3.TabIndex = 3;
            this.label3.Text = "jdfdfnld";
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(417, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1074, 125);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // accountIcon
            // 
            this.accountIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountIcon.Location = new System.Drawing.Point(861, 2);
            this.accountIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountIcon.Name = "accountIcon";
            this.accountIcon.Size = new System.Drawing.Size(47, 121);
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
            this.formName.Location = new System.Drawing.Point(12, 43);
            this.formName.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(186, 38);
            this.formName.TabIndex = 0;
            this.formName.Text = "Dashboard";
            // 
            // currentUser
            // 
            this.currentUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentUser.AutoSize = true;
            this.currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser.ForeColor = System.Drawing.Color.White;
            this.currentUser.Location = new System.Drawing.Point(923, 43);
            this.currentUser.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(134, 38);
            this.currentUser.TabIndex = 1;
            this.currentUser.Text = "Shanza";
            // 
            // notificationIcon
            // 
            this.notificationIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationIcon.Location = new System.Drawing.Point(808, 2);
            this.notificationIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notificationIcon.Name = "notificationIcon";
            this.notificationIcon.Size = new System.Drawing.Size(47, 121);
            this.notificationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.notificationIcon.TabIndex = 2;
            this.notificationIcon.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(428, 138);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1058, 788);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 932);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1512, 890);
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
        private System.Windows.Forms.ToolStripMenuItem hekkoToolStripMenuItem;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox notificationIcon;
        private System.Windows.Forms.ToolStripMenuItem notificationToolStripMenuItem1;
    }
}