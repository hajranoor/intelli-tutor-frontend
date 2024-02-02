using intelli_tutor_frontend.BackendApi;
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
        List<CourseOfferingModel> courseofferinglist;

        public async Task ShowMyCoursesAsync(FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "My Courses";
            courseofferinglist = await courseofferingapi.getCourseOfferings(1);

            MessageBox.Show("clicked 2" + courseofferinglist.Count.ToString());


            ShowCourses(flowLayoutPanel);


        }

        public void ShowCourses(FlowLayoutPanel flowLayoutPanel)
        {
            MessageBox.Show("are we here?");
            foreach (var course in courseofferinglist)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = 480;
                outerPanel.Height = 400;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                //outerPanel.BackColor = Color.Lavender;
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
                //pictureBox.Image = FontAwesome.Sharp.IconChar.Book.ToBitmap(color: Color.Black, size: 40, rotation: 0, flip: FlipOrientation.Normal);
                //pictureBox.Load("D:\\FYP\\IntelliTutor\\intelli-tutor-frontend\\intelli-tutor-frontend\\image.png");

                pictureBox.Width = 150;
                pictureBox.Height = 150;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                cardPanel.Controls.Add(pictureBox, 0, 0);

                Label titleLabel = new Label();
                titleLabel.Text = course.course_offering_id.ToString();
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                titleLabel.Height = 60;
                cardPanel.Controls.Add(titleLabel, 0, 1);

                Label instructorLabel = new Label();
                instructorLabel.Text = course.course_id.ToString();
                instructorLabel.Dock = DockStyle.Fill;
                instructorLabel.TextAlign = ContentAlignment.MiddleCenter;
                instructorLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
                instructorLabel.Height = 60;

                cardPanel.Controls.Add(instructorLabel, 0, 2);
                Panel buttonPanel = new Panel();
                buttonPanel.Height = 65;
                buttonPanel.Width = 70;
                //buttonPanel.BackColor = Color.DarkSlateBlue;
                buttonPanel.Dock = DockStyle.Bottom;
                buttonPanel.Margin = new Padding(150, 0, 150, 20);

                Button enrollButton = new Button();

                enrollButton.Text = "Enroll";
                enrollButton.Dock = DockStyle.Fill;
                enrollButton.Width = 70;
                enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                enrollButton.Padding = new Padding(5, 15, 5, 15);
                enrollButton.Font = new Font("Segoe UI Semibold", 12F);
                enrollButton.BackColor = Color.DarkSlateBlue;
                enrollButton.ForeColor = Color.White;
                enrollButton.Click += async (sender, e) =>
                {
                    DialogResult result = MessageBox.Show("Do you want to enroll in this course " + course.offering_year + " ?", "Enrollment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
