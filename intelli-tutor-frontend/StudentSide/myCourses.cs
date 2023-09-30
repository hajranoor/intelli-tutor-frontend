using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.StudentSide
{
    public partial class myCourses : Dashboard
    {
        EnrolledCourseApi enrolledCourseApi = new EnrolledCourseApi();
        WeekApi weekApi = new WeekApi();
        List<weekModel> weeksList;
        List<CourseAndEnrolledCourseDTO> enrolledCourseList;
        public myCourses()
        {
            InitializeComponent();
            formName.Text = "My Courses";
        }

        private async void myCourses_Load(object sender, EventArgs e)
        {
            enrolledCourseList = await enrolledCourseApi.getAllEnrolledCourseData(1);
            showData();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void showData()
        {
            foreach (var item in enrolledCourseList)
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
                pictureBox.Load("D://FYP//IntelliTutor//intelli-tutor-frontend//intelli-tutor-frontend//image.png");

                pictureBox.Width = 150;
                pictureBox.Height = 150;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                cardPanel.Controls.Add(pictureBox, 0, 0);

                Label titleLabel = new Label();
                titleLabel.Text = item.course_title;
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                titleLabel.Height = 60;
                cardPanel.Controls.Add(titleLabel, 0, 1);

                Label instructorLabel = new Label();
                instructorLabel.Text = item.description;
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
                    
                        flowLayoutPanel1.Controls.Clear();
                        CourseContent(item);

                };

                buttonPanel.Controls.Add(enrollButton);

                cardPanel.Controls.Add(buttonPanel, 0, 3);
                outerPanel.Controls.Add(cardPanel);

                flowLayoutPanel1.Controls.Add(outerPanel);

            }

        }

        private async void CourseContent(CourseAndEnrolledCourseDTO myCourseData)
        {
            weeksList = await weekApi.getAllWeekData(myCourseData.course_id);
            
            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Margin = new Padding(10, 10, 10, 10);
            mainPanel.BackColor = Color.BurlyWood;
            mainPanel.Height = flowLayoutPanel1.Height;
            mainPanel.Width = flowLayoutPanel1.Width;
            mainPanel.Margin = flowLayoutPanel1.Margin;
            mainPanel.Padding = flowLayoutPanel1.Padding;

            flowLayoutPanel1.Controls.Add(mainPanel);
            //mainPanel.Location = flowLayoutPanel1.Location;

            //mainPanel.Size = flowLayoutPanel1.Size;
            //mainPanel.AutoScroll = true;
            //mainPanel.Anchor = flowLayoutPanel1.Anchor;
            //mainPanel.Margin = flowLayoutPanel1.Margin;
            //mainPanel.Padding = flowLayoutPanel1.Padding;

            //mainPanel.BackColor = Color.Aquamarine;
            //mainPanel.Dock = DockStyle.Fill;

            //MessageBox.Show(mainPanel.Width.ToString() + " - " + mainPanel.Height.ToString());

            Label courseTitle = new Label();
            courseTitle.Text = myCourseData.course_title;
            courseTitle.Dock = DockStyle.Fill;
            courseTitle.Font = new Font("Segoe UI Semibold", 16F);
            courseTitle.Height = 60;
            mainPanel.Controls.Add(courseTitle, 0, 1);



            Label CourseDescription = new Label();
            CourseDescription.Text = myCourseData.description;
            CourseDescription.Dock = DockStyle.Fill;
            CourseDescription.Font = new Font("Segoe UI Semibold", 10F);
            CourseDescription.Height = 300;
            mainPanel.Controls.Add(CourseDescription, 0, 2);


            TableLayoutPanel weekPanel = new TableLayoutPanel();
            weekPanel.AutoScroll = true;
            weekPanel.Anchor = AnchorStyles.Left;
            weekPanel.Height = 300;
            weekPanel.Dock = DockStyle.Bottom;
            weekPanel.BackColor = Color.Cyan;
            weekPanel.HorizontalScroll.Enabled = true; 
            weekPanel.HorizontalScroll.Visible = true;
            mainPanel.Controls.Add(weekPanel, 0, 3);
            int counter = 0;
            weekPanel.Margin = new Padding(10, 20, 10, 20);

            foreach (var item in weeksList)
            {
                counter += 1;
                Panel outerPanel = new Panel();
                outerPanel.Width = 200;
                outerPanel.Height = 200;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                //outerPanel.BackColor = Color.Lavender;
                outerPanel.BorderStyle = BorderStyle.FixedSingle;

                TableLayoutPanel cardPanel = new TableLayoutPanel();
                //cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = 200;
                cardPanel.Height = 200;
                cardPanel.Margin = new Padding(20, 20, 20, 20);
                cardPanel.BackColor = Color.Lavender;
                cardPanel.AutoScroll = true;



                Label titleLabel = new Label();
                titleLabel.Text = "Week " + counter;
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                titleLabel.Height = 30;
                cardPanel.Controls.Add(titleLabel, 0, 1);
                outerPanel.Controls.Add(cardPanel);

                weekPanel.Controls.Add(outerPanel, counter, 0);
            }

            MessageBox.Show(weeksList.Count.ToString());

        }
    }
}
