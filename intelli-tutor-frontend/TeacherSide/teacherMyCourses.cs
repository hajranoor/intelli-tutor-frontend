﻿using intelli_tutor_frontend.BackendApi;
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
    internal class TeacherMyCourses
    {
        CourseOfferingApi courseofferingapi = new CourseOfferingApi();
        List<MainCourseAndCourseOfferingDTO> myCourseList;

        public async void ShowMyCoursesAsync(FlowLayoutPanel flowLayoutPanel, Label formName, MenuStrip menuStrip)
        {
            ToolStripItem[] changeColor = menuStrip.Items.Find("myCourseToolStripMenuItem1", true);
            foreach (var change in changeColor)
            {
                change.ForeColor = Color.White;
                change.BackColor = Color.DarkSlateBlue;
                TeacherSideDashbaord.lastClickedItem = change;
            }

            
            flowLayoutPanel.Controls.Clear();
            formName.Text = "My Courses";
            myCourseList = await courseofferingapi.getMyCoursesForTeacher(1);
            foreach (var course in myCourseList)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = 480;
                outerPanel.Height = 400;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                outerPanel.BorderStyle = BorderStyle.FixedSingle;
                TableLayoutPanel cardPanel = new TableLayoutPanel();
                cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = 480;
                cardPanel.Height = 400;
                cardPanel.Margin = new Padding(20, 20, 20, 20);
                cardPanel.BackColor = Color.Lavender;
                cardPanel.AutoScroll = true;

                PictureBox pictureBox = new PictureBox();

                pictureBox.Width = 150;
                pictureBox.Height = 150;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                cardPanel.Controls.Add(pictureBox, 0, 0);

                Label titleLabel = new Label();
                titleLabel.Text = course.course_name.ToString();
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                titleLabel.Height = 60;
                cardPanel.Controls.Add(titleLabel, 0, 1);

                Label instructorLabel = new Label();
                instructorLabel.Text = course.course_code.ToString();
                instructorLabel.Dock = DockStyle.Fill;
                instructorLabel.TextAlign = ContentAlignment.MiddleCenter;
                instructorLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
                instructorLabel.Height = 60;

                cardPanel.Controls.Add(instructorLabel, 0, 2);
                Panel buttonPanel = new Panel();
                buttonPanel.Height = 65;
                buttonPanel.Width = 70;
                buttonPanel.Dock = DockStyle.Bottom;
                buttonPanel.Margin = new Padding(150, 0, 150, 20);

                Button enrollButton = new Button();

                enrollButton.Text = "View Details";
                enrollButton.Dock = DockStyle.Fill;
                enrollButton.Width = 70;
                enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                enrollButton.Padding = new Padding(5, 15, 5, 15);
                enrollButton.Font = new Font("Segoe UI Semibold", 12F);
                enrollButton.BackColor = Color.DarkSlateBlue;
                enrollButton.ForeColor = Color.White;
                enrollButton.Click += async (sender, e) =>
                {
                    flowLayoutPanel.Controls.Clear();
                    TeacherCourseWeek courseweek = new TeacherCourseWeek();
                    courseweek.ShowCourseWeek(flowLayoutPanel, course, formName, menuStrip);
                   // MessageBox.Show("this is course course code in teacher courses that is being passed", course.description);
                    //DialogResult result = MessageBox.Show("Do you want to enroll in this course " + course.offering_year + " ?", "Enrollment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //if (result == DialogResult.Yes)
                    //{
                    //enrolledCourses enrolledCourses = new enrolledCourses();
                    //enrolledCourses.courseId = course.semester.ToString();
                    //enrolledCourses.studentId = 1;
                    //enrolledCourses.grade = "";
                    //string data = await enrolledCourseApi.makeEnrollmentInCourse(enrolledCourses);

                    //MessageBox.Show(data);
                    //}
                    //else
                    //{
                    //}
                };

                buttonPanel.Controls.Add(enrollButton);

                cardPanel.Controls.Add(buttonPanel, 0, 3);
                outerPanel.Controls.Add(cardPanel);

                flowLayoutPanel.Controls.Add(outerPanel);
            }
        }
    }
}
