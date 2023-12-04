using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using intelli_tutor_frontend.StudentSide;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    public partial class My_Courses : Form
    {
        EnrolledCourseApi enrolledCourseApi = new EnrolledCourseApi();
        WeekApi weekApi = new WeekApi();
        List<WeekModel> weeksList;
        List<CourseAndEnrolledCourseDTO> enrolledCourseList;
        public My_Courses()
        {
            InitializeComponent();
            enrolledCourseList = new List<CourseAndEnrolledCourseDTO>
        {
            new CourseAndEnrolledCourseDTO
            {
                course_title = "Course 1",
                description = "Description of Course 1",
               
            },
            new CourseAndEnrolledCourseDTO
            {
                course_title = "Course 2",
                description = "ChatGPT is a large language model-based chatbot developed by OpenAI and launched on November 30, 2022, that enables users to refine and steer a conversation towards a desired length, format, style, level of detail, and language ",
               
            },
             new CourseAndEnrolledCourseDTO
            {
                course_title = "Course 3",
                description = "Description of Course 3",
               
            },
              new CourseAndEnrolledCourseDTO
            {
                course_title = "Course 4",
                description = "Description of Course 4",
                
            },
            // Add more hardcoded data as needed
        };
        }


    private void My_Courses_Load(object sender, EventArgs e)
        {
            
            SetPanelRegion(panel9);
            SetPanelRegion(panel10);
            SetPanelRegion(panel11);
            SetPanelRegion(panel12);
            SetPanelRegion(panel13);
            SetPanelRegion(panel14);
            //enrolledCourseList = await enrolledCourseApi.getAllEnrolledCourseData(1);
            showData();
        }
        

        private void My_Courses_Resize(object sender, EventArgs e)
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
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            panel13.BackColor = Color.White;
            panel14.BackColor = Color.FromArgb(192, 192, 255);
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.FromArgb(192, 192, 255);

            Available_Courses available_Courses = new Available_Courses();
            available_Courses.Show();
            this.Hide();
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
        private void showData()
        {
            foreach (var item in enrolledCourseList)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = 400;
                outerPanel.Height = 300;
                outerPanel.Margin = new Padding(50, 20, 20, 20);
                //outerPanel.BackColor = Color.Lavender;
                //outerPanel.BorderStyle = BorderStyle.FixedSingle;



                TableLayoutPanel cardPanel = new TableLayoutPanel();
                cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = 400;
                cardPanel.Height = 300;
                cardPanel.Margin = new Padding(50, 20, 20, 20);
                cardPanel.BackColor = Color.Lavender;
                


                PictureBox pictureBox = new PictureBox();
                //pictureBox.Image = FontAwesome.Sharp.IconChar.Book.ToBitmap(color: Color.Black, size: 40, rotation: 0, flip: FlipOrientation.Normal);
                //pictureBox.Load("D:\\FYP\\IntelliTutor\\intelli-tutor-frontend\\intelli-tutor-frontend\\image.png");
                string imagePath = Path.Combine(Application.StartupPath, "image.png");
                pictureBox.Load(imagePath);

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

                    flowLayoutPanel1.Controls.Clear();
                    StudentSide.CourseContent c = new StudentSide.CourseContent();
                    c.CourseContentSjow(item, flowLayoutPanel1);

                };

                buttonPanel.Controls.Add(enrollButton);

                cardPanel.Controls.Add(buttonPanel, 0, 3);
                outerPanel.Controls.Add(cardPanel);
                SetPanelRegion(outerPanel);

                flowLayoutPanel2.Controls.Add(outerPanel);

            }

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
        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
