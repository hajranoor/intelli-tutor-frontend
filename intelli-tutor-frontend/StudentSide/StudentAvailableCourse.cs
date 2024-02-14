using FontAwesome.Sharp;
using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using intelli_tutor_frontend.TeacherSide;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.StudentSide
{
    internal class StudentAvailableCourses
    {
        CourseOfferingApi courseOfferingApi = new CourseOfferingApi();
        EnrolledCourseApi enrolledCourseApi = new EnrolledCourseApi();

        List<MainCourseAndCourseOfferingAndTeacherDTO> availableCoursesList;

        public async void availableCoursesShow(FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            flowLayoutPanel.Controls.Clear();
            formName.Text = "Available Courses";
            availableCoursesList = await courseOfferingApi.getCourseOfferingForStudent();
            if (availableCoursesList.Count == 0)
            {
                MessageBox.Show("No Courses Available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            foreach (var courseData in availableCoursesList)
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
                pictureBox.Image = FontAwesome.Sharp.IconChar.Book.ToBitmap(color: Color.Black, size: 40, rotation: 0, flip: FlipOrientation.Normal);
                string imagePath = Path.Combine(Application.StartupPath, "labimage.png");
                pictureBox.Load(imagePath);

                pictureBox.Width = 150;
                pictureBox.Height = 150;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                cardPanel.Controls.Add(pictureBox, 0, 0);

                Label titleLabel = new Label();
                titleLabel.Text = courseData.course_name;
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                titleLabel.Height = 60;
                cardPanel.Controls.Add(titleLabel, 0, 1);

                Label instructorLabel = new Label();
                instructorLabel.Text = courseData.semester + (courseData.offering_year).ToString();
                instructorLabel.Dock = DockStyle.Fill;
                instructorLabel.TextAlign = ContentAlignment.MiddleCenter;
                instructorLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
                instructorLabel.Height = 60;

                cardPanel.Controls.Add(instructorLabel, 0, 2);
                TableLayoutPanel buttonPanel = new TableLayoutPanel();
                buttonPanel.Height = 70;
                buttonPanel.Width = 150;
                buttonPanel.Dock = DockStyle.Bottom;
                buttonPanel.Margin = new Padding(10, 0, 10, 20);

                buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                Button enrollButton = new Button();

                enrollButton.Text = "Enroll";
                enrollButton.Dock = DockStyle.Fill;
                enrollButton.Width = 60;
                enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                enrollButton.Padding = new Padding(5, 15, 5, 15);
                enrollButton.Font = new Font("Segoe UI Semibold", 12F);
                enrollButton.BackColor = Color.DarkSlateBlue;
                enrollButton.ForeColor = Color.White;
                enrollButton.Click += async (sender, e) =>
                {
                    DialogResult result = MessageBox.Show("Do you want to enroll in this course" + courseData.course_name + " ?", "Enrollment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bool isCapacitySufficient = await enrolledCourseApi.checkCourseCapacity(courseData.course_offering_id);

                        if (isCapacitySufficient)
                        {
                            EnrolledCourses enrolledCourses = new EnrolledCourses();
                            enrolledCourses.course_offering_id = courseData.course_offering_id;
                            enrolledCourses.student_id = 2; //change it
                            enrolledCourses.grade = "null";
                            string message = await enrolledCourseApi.makeEnrollmentInCourse(enrolledCourses);
                            MessageBox.Show(message, " Message ");

                        }

                        else
                        {
                            MessageBox.Show("course capacity exceeded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        

                    }

                };

                buttonPanel.Controls.Add(enrollButton, 0, 0);

                Button viewbutton = new Button();

                viewbutton.Text = "View Course";
                viewbutton.Dock = DockStyle.Fill;
                viewbutton.Width = 60;
                viewbutton.TextAlign = ContentAlignment.MiddleCenter;
                viewbutton.Padding = new Padding(5, 15, 5, 15);
                viewbutton.Font = new Font("Segoe UI Semibold", 12F);
                viewbutton.BackColor = Color.DarkSlateBlue;
                viewbutton.ForeColor = Color.White;
                viewbutton.Click += async (sender, e) =>
                {
                    flowLayoutPanel.Controls.Clear();
                    StudentAvailableCourseWeek studentAvailableCourseWeek = new StudentAvailableCourseWeek();
                    studentAvailableCourseWeek.AvailableCourseWeekShow(courseData, flowLayoutPanel, formName);

                };

                buttonPanel.Controls.Add(viewbutton, 1, 0);

                cardPanel.Controls.Add(buttonPanel, 0, 3);
                outerPanel.Controls.Add(cardPanel);

                flowLayoutPanel.Controls.Add(outerPanel);
            }
        }
        }
    }
}
