using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using intelli_tutor_frontend.BackendApi;

namespace intelli_tutor_frontend.StudentSide
{
    
    public partial class Dashboard : Form
    {
        CurrentUser currentLoginUser = CurrentUser.Instance;
        public Dashboard()
        {
            InitializeComponent();
            loadIcons();
           

        }

        public void loadIcons()
        {
            this.notificationIcon.Image = IconChar.Bell.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);
            this.accountIcon.Image = IconChar.Person.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);
            mydashboard();
           
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.currentUser.Text = "";
            this.currentUser.Text = currentLoginUser.User.username;
           

           
        }

        public void mydashboard()
        {
          this.flowLayoutPanel1.Controls.Clear();
          studentdashBoard u = new studentdashBoard();
          u.StudentDashboard(flowLayoutPanel1, formName);

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
        private void notificationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            StudentNotification studentNotification = new StudentNotification();
            studentNotification.ShowStudentNotification(flowLayoutPanel1, formName);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool courseNamesVisible = false; // Initialize as hidden

        private void showdata()
        {

            dashboardToolStripMenuItem.Enabled = true;
            List<string> enrolledCourseNames = new List<string>();

            // Add course names to the list
            enrolledCourseNames.Add("Course 1");
            enrolledCourseNames.Add("Course 2");
            enrolledCourseNames.Add("Course 3");
            enrolledCourseNames.Add("Course 4");

            List<int> attendancePercentages = new List<int> { 95, 80, 60, 40 };
            int numberOfCoursesEnrolled = enrolledCourseNames.Count;

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

            // Create a Label to display the total enrolled courses count
            Label enrolledCoursesLabel = new Label();
            enrolledCoursesLabel.Text = "Total Enrolled Courses: " + numberOfCoursesEnrolled.ToString();
            enrolledCoursesLabel.Dock = DockStyle.Fill;
            enrolledCoursesLabel.TextAlign = ContentAlignment.MiddleCenter;
            enrolledCoursesLabel.Font = new Font("Segoe UI Semibold", 15F);
            enrolledCoursesLabel.Height = 35;
            cardPanel.Controls.Add(enrolledCoursesLabel, 0, 0);

            // Create a ListBox to display the enrolled course names
            ListBox courseListBox = new ListBox();
            courseListBox.Dock = DockStyle.Fill;
            courseListBox.Font = new Font("Segoe UI", 12F);
            courseListBox.FormattingEnabled = true;
            courseListBox.Items.AddRange(enrolledCourseNames.ToArray());
            courseListBox.Visible = courseNamesVisible; // Set visibility based on the flag
            cardPanel.Controls.Add(courseListBox, 0, 1);

            Panel buttonPanel = new Panel();
            buttonPanel.Height = 50;
            buttonPanel.Width = 40;
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Margin = new Padding(130, 0, 100, 10);

            Button showHideButton = new Button();

            // Toggle course names visibility on button click
            showHideButton.Text = "Show Course Names";
            showHideButton.Dock = DockStyle.Fill;
            showHideButton.Width = 70;
            showHideButton.TextAlign = ContentAlignment.MiddleCenter;
            showHideButton.Padding = new Padding(5, 15, 5, 15);
            showHideButton.Font = new Font("Segoe UI Semibold", 9F);
            showHideButton.BackColor = Color.DarkSlateBlue;
            showHideButton.ForeColor = Color.White;
            showHideButton.Click += (sender, e) =>
            {
                courseNamesVisible = !courseNamesVisible; // Toggle visibility flag
                courseListBox.Visible = courseNamesVisible; // Apply visibility to the course list
                showHideButton.Text = courseNamesVisible ? "Hide Course Names" : "Show Course Names"; // Change button text
            };

            buttonPanel.Controls.Add(showHideButton);

            cardPanel.Controls.Add(buttonPanel, 0, 2);
            outerPanel.Controls.Add(cardPanel);
            TableLayoutPanel attendancePanel = new TableLayoutPanel();
            Panel attendanceOuterPanel = new Panel();
            attendanceOuterPanel.Width = 400;
            attendanceOuterPanel.Height = 300;
            attendanceOuterPanel.Margin = new Padding(50, 20, 20, 20);
            attendancePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            attendancePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            attendancePanel.Width = 400;
            attendancePanel.Height = 300;
            attendancePanel.Margin = new Padding(50, 20, 20, 20);
            attendancePanel.BackColor = Color.Lavender;
            attendancePanel.AutoScroll = true;
            Label attendanceStatusLabel1 = new Label();
            attendanceStatusLabel1.Text = "Attendance Status";
            attendanceStatusLabel1.Dock = DockStyle.Fill;
            attendanceStatusLabel1.TextAlign = ContentAlignment.MiddleCenter;
            attendanceStatusLabel1.Font = new Font("Segoe UI Semibold", 15F);
            attendanceStatusLabel1.Height = 35;
            attendancePanel.Controls.Add(attendanceStatusLabel1, 0, 0);

            attendancePanel.ColumnCount = 3;
            attendancePanel.RowCount = enrolledCourseNames.Count + 1; // +1 for the header row
            attendancePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F)); // Row style for the header
            attendancePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F)); // 40% width for course names
            attendancePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // 30% width for attendance percentages
            attendancePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // 30% width for attendance statuses

            attendancePanel.Controls.Add(attendanceStatusLabel1, 0, 0);
            attendancePanel.SetColumnSpan(attendanceStatusLabel1, 3);

            // Loop through each course and add its name and attendance status to the panel

            for (int i = 0; i < enrolledCourseNames.Count; i++)
            {
                // Label for course name
                Label courseNameLabel = new Label();
                courseNameLabel.Text = enrolledCourseNames[i];
                courseNameLabel.Dock = DockStyle.Fill;
                courseNameLabel.TextAlign = ContentAlignment.MiddleLeft;
                courseNameLabel.Font = new Font("Segoe UI", 12F);
                attendancePanel.Controls.Add(courseNameLabel, 0, i); // Add to column 0
                // Label for attendance percentage
                Label attendancePercentageLabel = new Label();
                attendancePercentageLabel.Text = attendancePercentages[i].ToString() + "%";
                attendancePercentageLabel.Dock = DockStyle.Fill;
                attendancePercentageLabel.TextAlign = ContentAlignment.MiddleCenter;
                attendancePercentageLabel.Font = new Font("Segoe UI", 12F);
                attendancePanel.Controls.Add(attendancePercentageLabel, 1, i); // Add to column 1
                // Label for attendance status
                Label attendanceStatusLabel = new Label();
                attendanceStatusLabel.Dock = DockStyle.Fill;
                attendanceStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
                attendanceStatusLabel.Font = new Font("Segoe UI", 12F);

                // Determine the attendance status based on the percentage
                if (attendancePercentages[i] >= 100)
                    attendanceStatusLabel.Text = "Excellent";
                else if (attendancePercentages[i] >= 75)
                    attendanceStatusLabel.Text = "Better";
                else if (attendancePercentages[i] >= 65)
                    attendanceStatusLabel.Text = "Average";
                else if (attendancePercentages[i] >= 50)
                    attendanceStatusLabel.Text = "Below Average";
                else
                    attendanceStatusLabel.Text = "Alarming";

                attendancePanel.Controls.Add(attendanceStatusLabel, 2, i); // Add to column 2
            }
            // ...

            Panel ProgressBarPanel = new Panel();
            ProgressBarPanel.Width = 400;
            ProgressBarPanel.Height = 300;
            ProgressBarPanel.Margin = new Padding(50, 20, 20, 20);

            TableLayoutPanel cardPanel1 = new TableLayoutPanel();
            cardPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cardPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            cardPanel1.Width = 400;
            cardPanel1.Height = 300; // You might want to adjust the height to fit the progress bar and button.
            cardPanel1.Margin = new Padding(0); // Adjust the margin as necessary.
            cardPanel1.BackColor = Color.Lavender;
            cardPanel1.AutoScroll = true;

            Label pblable = new Label();
            pblable.Text = "YOUR PROGRESS ";
            pblable.Dock = DockStyle.Fill;
            enrolledCoursesLabel.TextAlign = ContentAlignment.MiddleCenter;
            pblable.Font = new Font("Segoe UI Semibold", 15F);
            pblable.Height = 35;
            cardPanel1.Controls.Add(pblable, 0, 0);

            ProgressBar progressBar = new ProgressBar();
            progressBar.Location = new System.Drawing.Point(10, 10);
            progressBar.Size = new System.Drawing.Size(350, 30);
            progressBar.Padding = new Padding(5, 15, 5, 15);
            progressBar.Margin = new Padding(10, 50, 20, 20);
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            cardPanel1.Controls.Add(progressBar); // Adjusted to not specify column and row for a single control.

            Button CheckButton = new Button();
            CheckButton.Location = new System.Drawing.Point(220, 10);
            CheckButton.Size = new System.Drawing.Size(100, 50);
            CheckButton.Text = "Check";
           
            CheckButton.Width = 70;
            CheckButton.TextAlign = ContentAlignment.MiddleCenter;
            CheckButton.Padding = new Padding(5, 15, 5, 15);
            CheckButton.Font = new Font("Segoe UI Semibold", 9F);
            CheckButton.BackColor = Color.DarkSlateBlue;
            CheckButton.ForeColor = Color.White;
            CheckButton.Padding = new Padding(5, 15, 5, 15);
            CheckButton.Margin = new Padding(50, 50, 20, 20);
            CheckButton.Click += new EventHandler(CheckButton_Click);
            cardPanel1.Controls.Add(CheckButton);
            ProgressBarPanel.Controls.Add(cardPanel1); // This line is important. It adds the cardPanel1 to ProgressBarPanel.

            attendanceOuterPanel.Controls.Add(attendancePanel);

            // Add the outerPanel to a container on your form, such as a FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(outerPanel);
            flowLayoutPanel1.Controls.Add(attendanceOuterPanel);
            flowLayoutPanel1.Controls.Add(ProgressBarPanel); // Ensure this panel is added to the FlowLayoutPanel.

            // ...


            void CheckButton_Click(object sender, EventArgs e)
            {
                // Start the update process on a new task
                Task.Run(() =>
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        Thread.Sleep(50); // Simulate work
                                          // Use Invoke to update the progress bar safely from the background thread
                        if (progressBar.InvokeRequired)
                        {
                            progressBar.Invoke(new Action(() =>
                            {
                                progressBar.Value = i;
                            }));
                        }
                        else
                        {
                            progressBar.Value = i;
                        }
                    }
                });
            }


        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.flowLayoutPanel1.Controls.Clear();
            studentdashBoard u = new studentdashBoard();
            u.StudentDashboard(flowLayoutPanel1, formName);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}