using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
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
    internal class StudentMyCourse
    {
        EnrolledCourseApi enrolledCourseApi = new EnrolledCourseApi();
        WeekApi weekApi = new WeekApi();
        List<WeekModel> weeksList;
        List<CourseAndEnrolledCourseDTO> enrolledCourseList;

        public async void StudentMyCourseShow(FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "My Courses";
            enrolledCourseList = await enrolledCourseApi.getAllEnrolledCourseData(2);

            if(enrolledCourseList.Count == 0)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = flowLayoutPanel.Width;
                outerPanel.Height = flowLayoutPanel.Height;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                Label messageLabel = new Label();
                messageLabel.Text = "Not enrolled in any course yet!";
                messageLabel.Dock = DockStyle.Fill;
                messageLabel.TextAlign = ContentAlignment.MiddleCenter;
                messageLabel.Font = new Font("Segoe UI Semibold", 16F);
                messageLabel.Height = 30;
                messageLabel.ForeColor = Color.Black;
                flowLayoutPanel.Controls.Add(messageLabel);

                outerPanel.Controls.Add(messageLabel);

                flowLayoutPanel.Controls.Add(outerPanel);
            }
            else
            {
                foreach (var enrolledCourse in enrolledCourseList)
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
                    string imagePath = Path.Combine(Application.StartupPath, "image.png");
                    pictureBox.Load(imagePath);

                    pictureBox.Width = 150;
                    pictureBox.Height = 150;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Dock = DockStyle.Fill;
                    cardPanel.Controls.Add(pictureBox, 0, 0);

                    Label titleLabel = new Label();
                    titleLabel.Text = enrolledCourse.course_name;
                    titleLabel.Dock = DockStyle.Fill;
                    titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                    titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                    titleLabel.Height = 60;
                    cardPanel.Controls.Add(titleLabel, 0, 1);

                    Label instructorLabel = new Label();
                    instructorLabel.Text = enrolledCourse.course_code;
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

                    enrollButton.Text = "View Course";
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
                        StudentEnrolledCourseWeek studentEnrolledCourseWeek = new StudentEnrolledCourseWeek();
                        studentEnrolledCourseWeek.StudentEnrolledCourseWeekShow(enrolledCourse, flowLayoutPanel, formName);

                    };

                    buttonPanel.Controls.Add(enrollButton);

                    cardPanel.Controls.Add(buttonPanel, 0, 3);
                    outerPanel.Controls.Add(cardPanel);

                    flowLayoutPanel.Controls.Add(outerPanel);

                }
            }
        }
    }
}
