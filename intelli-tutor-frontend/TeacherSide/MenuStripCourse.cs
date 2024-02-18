using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    internal class MenuStripCourse
    {
        static MenuStrip menuStrip;
        static Label formName;
        static FlowLayoutPanel flowLayoutPanel;
        static MainCourseAndCourseOfferingDTO courseData;
        private static ToolStripMenuItem courseWeekToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripItem lastClickedItem = courseWeekToolStripMenuItem;

        int counter;
        public MenuStripCourse(MenuStrip menuStrip1, FlowLayoutPanel flowLayoutPanel1, Label formName1, MainCourseAndCourseOfferingDTO courseData1)
        {
            menuStrip = menuStrip1;
            flowLayoutPanel = flowLayoutPanel1;
            formName = formName1;
            courseData = courseData1;

           
        }
       
        public void createMenu()
        {
            
            ToolStripMenuItem enrolmentToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem addWeekToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem backToolStripMenuItem = new ToolStripMenuItem();
            // 
            // enrolmentToolStripMenuItem
            // 
            courseWeekToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            courseWeekToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            courseWeekToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            courseWeekToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            courseWeekToolStripMenuItem.Name = "courseWeekToolStripMenuItem";
            courseWeekToolStripMenuItem.Size = new System.Drawing.Size(181, 45);
            courseWeekToolStripMenuItem.Text = "Course Week";
            courseWeekToolStripMenuItem.Click += new System.EventHandler(this.courseWeekToolStripMenuItem_Click);

            // 
            // addWeekToolStripMenuItem
            // 
            addWeekToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            addWeekToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            addWeekToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            addWeekToolStripMenuItem.Name = "addWeekToolStripMenuItem";
            addWeekToolStripMenuItem.Size = new System.Drawing.Size(181, 45);
            addWeekToolStripMenuItem.Text = "Add Week";
            addWeekToolStripMenuItem.Click += new System.EventHandler(this.addWeekToolStripMenuItem_Click);

            // 
            // enrolmentToolStripMenuItem
            // 
            enrolmentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            enrolmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            enrolmentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            enrolmentToolStripMenuItem.Name = "enrolmentToolStripMenuItem";
            enrolmentToolStripMenuItem.Size = new System.Drawing.Size(181, 45);
            enrolmentToolStripMenuItem.Text = "Enrolments";
            enrolmentToolStripMenuItem.Click += new System.EventHandler(this.enrolmentToolStripMenuItem_Click);

            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            backToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new System.Drawing.Size(181, 45);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);

            menuStrip.Items.Clear();
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            courseWeekToolStripMenuItem,
            addWeekToolStripMenuItem,
            enrolmentToolStripMenuItem,
            backToolStripMenuItem});
            menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);

        }

        private void courseWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherCourseWeek teacherCourseWeek = new TeacherCourseWeek();
            teacherCourseWeek.ShowCourseWeek(flowLayoutPanel, courseData, formName, menuStrip);
        }

        private void addWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAddWeek teacherAddWeek = new TeacherAddWeek();
            teacherAddWeek.ShowTeacherAddWeek(courseData, flowLayoutPanel, formName);
        }

        private async void enrolmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ViewEnrollments viewEnrollments = new ViewEnrollments();
           await viewEnrollments.ViewEnrollmentsAsync(flowLayoutPanel, formName, courseData);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip.Items.Clear();
            menuStrip.Items.AddRange(TeacherSideDashbaord.originalMenuItems.ToArray());
            TeacherMyCourses teacherMyCourses = new TeacherMyCourses();
            teacherMyCourses.ShowMyCoursesAsync(flowLayoutPanel, formName, menuStrip);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (lastClickedItem != null)
            {
                lastClickedItem.ForeColor = Color.Black;
                lastClickedItem.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            }

            ToolStripItem clickedItem = e.ClickedItem;
            clickedItem.ForeColor = Color.White;
            clickedItem.BackColor = Color.DarkSlateBlue;

            lastClickedItem = clickedItem;
        }
    }
}
