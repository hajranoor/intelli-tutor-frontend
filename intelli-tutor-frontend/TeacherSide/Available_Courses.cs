using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using intelli_tutor_frontend.StudentSide;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    public partial class Available_Courses : Form
    {
        CourseApi courseApi = new CourseApi();
        EnrolledCourseApi enrolledCourseApi = new EnrolledCourseApi();

        List<coursesModel> availableCoursesList;
        public Available_Courses()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Click(object sender, EventArgs e)
        {
            panel14.BackColor = Color.White;
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel13.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor = Color.FromArgb(192, 192, 255);
            TeacherDashboard dashboard = new TeacherDashboard();
            dashboard.Show();
            this.Hide();
            label13.BackColor= Color.White;
        }
        private void SetPanelRegion(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(panel.Width - (radius * 2), 0, radius * 2, radius * 2, -90, 90);
            path.AddArc(panel.Width - (radius * 2), panel.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(0, panel.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel10.BackColor = Color.White;
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel13.BackColor = Color.FromArgb(192, 192, 255);
            panel14.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.FromArgb(192, 192, 255);
            CreateCourse createCourse = new CreateCourse();
            createCourse.Show();
            this.Hide();
            label8.BackColor= Color.White;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Click(object sender, EventArgs e)
        {
            panel13.BackColor = Color.White;
            panel14.BackColor = Color.FromArgb(192, 192, 255);
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.FromArgb(192, 192, 255);

        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.White;
            panel13.BackColor = Color.FromArgb(192, 192, 255);
            panel14.BackColor = Color.FromArgb(192, 192, 255);
            My_Courses my_Courses = new My_Courses();
            my_Courses.Show();
            this.Hide();
            label11.BackColor = Color.White;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor = Color.FromArgb(192, 192, 255); 
            panel11.BackColor = Color.White;
            panel12.BackColor = Color.FromArgb(192, 192, 255);
            panel13.BackColor = Color.FromArgb(192, 192, 255);
            panel14.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.White;
            panel10.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.FromArgb(192, 192, 255);
            panel13.BackColor = Color.FromArgb(192, 192, 255);
            panel14.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void Available_Courses_Load(object sender, EventArgs e)
        {
           
            SetPanelRegion(panel9);
            SetPanelRegion(panel10);
            SetPanelRegion(panel11);
            SetPanelRegion(panel12);
            SetPanelRegion(panel13);
            SetPanelRegion(panel14);
            //availableCoursesList = await courseApi.getAllCourseData();
            AddHardcodedCourses();
            showData();
        }

        private void Available_Courses_Resize(object sender, EventArgs e)
        {
        
        }
        private void showData()
        {
            foreach (var item in availableCoursesList)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = 400;
                outerPanel.Height = 300;
                outerPanel.Margin = new Padding(50, 20, 20, 20);

                TableLayoutPanel cardPanel = new TableLayoutPanel();
                cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = 400;
                cardPanel.Height = 300;
                cardPanel.Margin = new Padding(50, 20, 20, 20);
                cardPanel.BackColor = Color.Lavender;
                cardPanel.AutoScroll = true;

                PictureBox pictureBox = new PictureBox();
                //pictureBox.Image = FontAwesome.Sharp.IconChar.Book.ToBitmap(color: Color.Black, size: 40, rotation: 0, flip: FlipOrientation.Normal);
                pictureBox.Load("C:\\Users\\Aqsa\\Desktop\\Login1.png");
                pictureBox.Width = 180;
                pictureBox.Height = 150;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                cardPanel.Controls.Add(pictureBox, 0, 0);
                cardPanel.AutoScroll = true;

                Label titleLabel = new Label();
                titleLabel.Text = item.course_title;
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 15F);
                titleLabel.Height = 35;
                cardPanel.Controls.Add(titleLabel, 0, 1);

                Label instructorLabel = new Label();
                instructorLabel.Text = item.description;
                instructorLabel.Dock = DockStyle.Fill;
                instructorLabel.TextAlign = ContentAlignment.MiddleCenter;
                instructorLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
                instructorLabel.Height = 35;

                cardPanel.Controls.Add(instructorLabel, 0, 2);
                Panel buttonPanel = new Panel();
                buttonPanel.Height = 50;
                buttonPanel.Width = 40;
                //buttonPanel.BackColor = Color.DarkSlateBlue;
                buttonPanel.Dock = DockStyle.Bottom;
                buttonPanel.Margin = new Padding(130, 0, 100, 10);

                Button enrollButton = new Button();

                enrollButton.Text = "View Course";
                enrollButton.Dock = DockStyle.Fill;
                enrollButton.Width = 70;
                enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                enrollButton.Padding = new Padding(5, 15, 5, 15);
                enrollButton.Font = new Font("Segoe UI Semibold", 9F);
                enrollButton.BackColor = Color.DarkSlateBlue;
                enrollButton.ForeColor = Color.White;
                enrollButton.Click += async (sender, e) =>
                {
                    DialogResult result = MessageBox.Show("Do you want to enroll in this course " + item.course_title + " ?", "Enrollment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        enrolledCourses enrolledCourses = new enrolledCourses();
                        enrolledCourses.courseId = item.course_id;
                        enrolledCourses.studentId = 1;
                        enrolledCourses.grade = "";
                        string data = await enrolledCourseApi.makeEnrollmentInCourse(enrolledCourses);

                        MessageBox.Show(data);
                    }
                    else
                    {
                    }
                };
                SetPanelRegion(outerPanel);
                buttonPanel.Controls.Add(enrollButton);

                cardPanel.Controls.Add(buttonPanel, 0, 3);
                outerPanel.Controls.Add(cardPanel);

                flowLayoutPanel1.Controls.Add(outerPanel);
            }

        }
        private void AddHardcodedCourses()
        {
            // Create and add hardcoded course instances to the list
            availableCoursesList = new List<coursesModel>
        {
            new coursesModel
            {
                course_id = 1,
                course_title = "Course 1",
                description = "Description of Course 1",
                // Add other properties as needed
            },
            new coursesModel
            {
                course_id = 2,
                course_title = "Course 2",
                description = "Description of Course 2",
                // Add other properties as needed
            },
            new coursesModel
            {
                course_id = 3,
                course_title = "Course 3",
                description = "Description of Course 2",
                // Add other properties as needed
            },
            new coursesModel
            {
                course_id = 4,
                course_title = "Course 4",
                description = "Description of Course 2",
                // Add other properties as needed
            },
            new coursesModel
            {
                course_id = 5,
                course_title = "Course 5",
                description = "Description of Course 2",
                // Add other properties as needed
            },
            // Add more courses as needed
        };
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
