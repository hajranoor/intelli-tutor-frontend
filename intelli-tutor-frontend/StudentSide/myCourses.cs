using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<WeekModel> weeksList;
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
                //pictureBox.Load("D:\\FYP\\IntelliTutor\\intelli-tutor-frontend\\intelli-tutor-frontend\\image.png");
                string imagePath = Path.Combine(Application.StartupPath, "image.png");
                pictureBox.Load(imagePath);

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
                    StudentCourseWeek c = new StudentCourseWeek();
                    c.CourseContentSjow(item, flowLayoutPanel1);

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
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.BurlyWood;
            mainPanel.Padding = new Padding(30, 30, 30, 30);
            mainPanel.Width = flowLayoutPanel1.Width;
            mainPanel.Height = flowLayoutPanel1.Height;
            mainPanel.AutoScroll = true;
            
            // Add mainPanel to flowLayoutPanel1
            flowLayoutPanel1.Controls.Add(mainPanel);

            // Handle the SizeChanged event of flowLayoutPanel1
            flowLayoutPanel1.SizeChanged += (sender, e) =>
            {
                // Adjust the size of mainPanel to match the size of flowLayoutPanel1
                mainPanel.Size = new Size(flowLayoutPanel1.Width - 100, flowLayoutPanel1.Height);

                // Optionally, adjust the size of other controls within mainPanel
                // based on the new size of mainPanel.
            };


            Label courseTitle = new Label();
            courseTitle.Text = myCourseData.course_title + "iuwehwuheuhsdkjhaskjdn,msa dkjnsajkdaskjdkjsadkjsa   asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsa  asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsa  asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsa  asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsa asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsav  asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsav asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsa  asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsav asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsa asjdsalkjdhlsad a dsajdnjkasdkjashd asdjksakjdkjsav";
            courseTitle.Dock = DockStyle.Fill;
            courseTitle.Font = new Font("Segoe UI Semibold", 16F);
            courseTitle.Height = 60;
            courseTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(courseTitle, 0, 1);

            RichTextBox CourseDescription = new RichTextBox();
            CourseDescription.Text = myCourseData.description;
            CourseDescription.Font = new Font("Segoe UI Semibold", 10F);
            CourseDescription.Dock = DockStyle.Fill;
            CourseDescription.ReadOnly = true;

            Panel descriptionPanel = new Panel();
            descriptionPanel.Dock = DockStyle.Fill;
            descriptionPanel.AutoScroll = true;
            descriptionPanel.BackColor = Color.CadetBlue;
            descriptionPanel.Height = 500;
            descriptionPanel.Controls.Add(CourseDescription);
            descriptionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            mainPanel.Controls.Add(descriptionPanel, 0, 2);


            TableLayoutPanel weekPanel = new TableLayoutPanel();
            weekPanel.AutoScroll = true;
            weekPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
                ////outerPanel.BackColor = Color.Lavender;
                outerPanel.BorderStyle = BorderStyle.FixedSingle;

                TableLayoutPanel cardPanel = new TableLayoutPanel();
                ////cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
        }
    }
}
