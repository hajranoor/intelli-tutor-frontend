﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace intelli_tutor_frontend.StudentSide
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            loadIcons();
            
        }
        public void loadIcons()
        {
            this.notificationIcon.Image = IconChar.Bell.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);
            this.accountIcon.Image = IconChar.Person.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashboardToolStripMenuItem.Enabled = true;
        }

        private void availableCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            StudentAvailableCourses studentAvailableCourses = new StudentAvailableCourses();
            studentAvailableCourses.availableCoursesShow(flowLayoutPanel1, formName);
        }

        private void myCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            StudentMyCourse studentMyCourse = new StudentMyCourse();
            studentMyCourse.StudentMyCourseShow(flowLayoutPanel1, formName);
        }
    }
}
