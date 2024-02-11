using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.CustomComponent;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.StudentSide
{
    internal class StudentEnrolledCourseWeek
    {
        WeekApi weekApi = new WeekApi();
        List<WeekModel> weeksList;
    
        public async void StudentEnrolledCourseWeekShow(CourseAndEnrolledCourseDTO courseData, FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "Course Week";
            weeksList = await weekApi.getAllWeekData(courseData.course_offering_id);

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel.Width;
            mainPanel.Height = flowLayoutPanel.Height;
            mainPanel.AutoScroll = true;

          
            flowLayoutPanel.Controls.Add(mainPanel);

            flowLayoutPanel.SizeChanged += (sender, e) =>
            {
                mainPanel.Size = new Size(flowLayoutPanel.Width, flowLayoutPanel.Height);
                flowLayoutPanel.Margin = new Padding(3, 3, 3, 3);
            };


            Label courseTitle = new Label();
            courseTitle.Text = courseData.course_name;
            courseTitle.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            courseTitle.Dock = DockStyle.Fill;
            courseTitle.Font = new Font("Segoe UI Semibold", 16F);
            courseTitle.Height = 60;
            courseTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courseTitle.AutoSize = true;
            courseTitle.Margin = new Padding(10, 10, 10, 10);
            courseTitle.Padding = new Padding(0, 10, 0, 10);
            mainPanel.Controls.Add(courseTitle, 0, 1);

            NoCaretRichTextBox CourseDescription = new NoCaretRichTextBox();
            CourseDescription.Text = courseData.course_code;
            CourseDescription.Font = new Font("Segoe UI", 14F);
            CourseDescription.Dock = DockStyle.Fill;
            CourseDescription.ReadOnly = true;
            CourseDescription.HideSelection = true;
            CourseDescription.BackColor = Color.Lavender;
            CourseDescription.BorderStyle = BorderStyle.None;

            Panel descriptionPanel = new Panel();
            descriptionPanel.Margin = new Padding(10, 10, 10, 10);
            descriptionPanel.Dock = DockStyle.Fill;
            descriptionPanel.AutoScroll = true;
            descriptionPanel.BackColor = Color.Lavender;
            descriptionPanel.Height = 500;
            descriptionPanel.Controls.Add(CourseDescription);
            descriptionPanel.BackColor = Color.Lavender;
            descriptionPanel.Padding = new Padding(10, 10, 10, 10);
            descriptionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            mainPanel.Controls.Add(descriptionPanel, 0, 2);


            



            Panel responsivePanel = new Panel();
            responsivePanel.Dock = DockStyle.Fill;
            responsivePanel.Height = 500;
            responsivePanel.Width = 600;
            responsivePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            responsivePanel.BorderStyle = BorderStyle.FixedSingle;
            responsivePanel.Padding = new Padding(2, 2, 2, 19); // Add padding for content

            TableLayoutPanel tablePanel = new TableLayoutPanel();
            tablePanel.Dock = DockStyle.Fill;
            tablePanel.Height = 456;
            tablePanel.Width = 500;
            tablePanel.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            tablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tablePanel.RowCount = 5;
            tablePanel.ColumnCount = 2;
            tablePanel.Font = new Font("Segoe UI", 10F);
            for (int i = 0; i < 5; i++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 5));
            }

            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            //----------------------
            Label creditHourLabel = new Label();
            creditHourLabel.Text = "Credit Hour ";
            creditHourLabel.Font = new Font("Segoe UI", 10F);
            creditHourLabel.Dock = DockStyle.Fill;
            creditHourLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label creditHourData = new Label();
            creditHourData.Text = courseData.credit_hour.ToString();
            creditHourData.Font = new Font("Segoe UI", 10F);
            creditHourData.Dock = DockStyle.Fill;
            creditHourData.TextAlign = ContentAlignment.MiddleCenter;
            //-----------------------

            Label weeksLabel = new Label();
            weeksLabel.Text = "No of weeks";
            weeksLabel.Font = new Font("Segoe UI", 10F);
            weeksLabel.Dock = DockStyle.Fill;
            weeksLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label weeksData = new Label();
            weeksData.Text = courseData.number_of_weeks.ToString();
            weeksData.Font = new Font("Segoe UI", 10F);
            weeksData.Dock = DockStyle.Fill;
            weeksData.TextAlign = ContentAlignment.MiddleCenter;
            //------------------------

            Label teacheremailLabel = new Label();
            teacheremailLabel.Text = "Teacher Email";
            teacheremailLabel.Font = new Font("Segoe UI", 10F);
            teacheremailLabel.Dock = DockStyle.Fill;
            teacheremailLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label teacheremailData = new Label();
            teacheremailData.Text = courseData.teacher_email;
            teacheremailData.Font = new Font("Segoe UI", 8F);
            teacheremailData.Dock = DockStyle.Fill;
            teacheremailData.TextAlign = ContentAlignment.MiddleCenter;
            //------------------------

            Label yearLabel = new Label();
            yearLabel.Text = "Offering Year";
            yearLabel.Font = new Font("Segoe UI", 10F);
            yearLabel.Dock = DockStyle.Fill;
            yearLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label yearData = new Label();
            yearData.Text = courseData.offering_year.ToString();
            yearData.Font = new Font("Segoe UI", 10F);
            yearData.Dock = DockStyle.Fill;
            yearData.TextAlign = ContentAlignment.MiddleCenter;
            //------------------------

            Label semesterLabel = new Label();
            semesterLabel.Text = "Semester";
            semesterLabel.Font = new Font("Segoe UI", 10F);
            semesterLabel.Dock = DockStyle.Fill;
            semesterLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label semesterData = new Label();
            semesterData.Text = courseData.semester;
            semesterData.Font = new Font("Segoe UI", 10F);
            semesterData.Dock = DockStyle.Fill;
            semesterData.TextAlign = ContentAlignment.MiddleCenter;
            //------------------------
            tablePanel.Controls.Add(teacheremailLabel, 0, 0);
            tablePanel.Controls.Add(teacheremailData, 1, 0);

            tablePanel.Controls.Add(weeksLabel, 0, 1);
            tablePanel.Controls.Add(weeksData, 1, 1);

            tablePanel.Controls.Add(creditHourLabel, 0, 2);
            tablePanel.Controls.Add(creditHourData, 1, 2);

            tablePanel.Controls.Add(yearLabel, 0, 3);
            tablePanel.Controls.Add(yearData, 1, 3);

            tablePanel.Controls.Add(semesterLabel, 0, 4);
            tablePanel.Controls.Add(semesterData, 1, 4);


            TableLayoutPanel parentTablePanel = new TableLayoutPanel();
            parentTablePanel.Dock = DockStyle.Fill;
            parentTablePanel.BackColor = Color.Lavender;
            parentTablePanel.Height = 500;
            parentTablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            parentTablePanel.RowCount = 1;
            parentTablePanel.ColumnCount = 2;
            parentTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
            parentTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            parentTablePanel.Dock = DockStyle.Fill;

            responsivePanel.Controls.Add(tablePanel);
            parentTablePanel.Controls.Add(descriptionPanel, 0, 0);
            parentTablePanel.Controls.Add(responsivePanel, 1, 0);

            // Set Dock property for the parent table panel
            parentTablePanel.Dock = DockStyle.Fill;

            // Add the parent table panel to the form
            ////----
            ///
            //
            //
            //


            mainPanel.Controls.Add(parentTablePanel, 0, 2);










            TableLayoutPanel weekPanel = new TableLayoutPanel();
            weekPanel.AutoScroll = true;
            weekPanel.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            weekPanel.Height = 250;
            weekPanel.VerticalScroll.Enabled = false;
            weekPanel.VerticalScroll.Visible = false;
            weekPanel.HorizontalScroll.Enabled = true;
            weekPanel.HorizontalScroll.Visible = true;
            mainPanel.Controls.Add(weekPanel, 0, 3);
            int counter = 0;
            weekPanel.Margin = new Padding(10, 20, 10, 20);

            if (weeksList.Count == 0)
            {
                Label messageLabel = new Label();
                messageLabel.Text = "No weeks Available";
                messageLabel.Dock = DockStyle.Fill;
                messageLabel.TextAlign = ContentAlignment.MiddleCenter;
                messageLabel.Font = new Font("Segoe UI Semibold", 16F);
                messageLabel.Height = 30;
                messageLabel.ForeColor = Color.Black;
                weekPanel.Controls.Add(messageLabel, 0, 0);
            }
            else
            {
                foreach (var weekData in weeksList)
                {
                    counter += 1;
                    Panel outerPanel = new Panel();
                    outerPanel.Width = 180;
                    outerPanel.Height = 180;
                    outerPanel.Margin = new Padding(20, 20, 20, 20);
                    outerPanel.BorderStyle = BorderStyle.FixedSingle;

                    TableLayoutPanel cardPanel = new TableLayoutPanel();
                    cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                    cardPanel.Width = 180;
                    cardPanel.Height = 180;
                    cardPanel.Margin = new Padding(20, 20, 20, 20);
                    cardPanel.BackColor = Color.DarkSlateBlue;
                    Button enrollButton = new Button();

                    enrollButton.Text = "Week " + counter;
                    enrollButton.Dock = DockStyle.Fill;
                    enrollButton.Width = 70;
                    enrollButton.Height = 30;
                    enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                    enrollButton.Font = new Font("Segoe UI Semibold", 16F);
                    enrollButton.BackColor = Color.DarkSlateBlue;
                    enrollButton.ForeColor = Color.White;
                    enrollButton.FlatStyle = FlatStyle.Flat;

                    Label titleLabel = new Label();
                    titleLabel.Text = "Week " + weekData.week_sequence.ToString();
                    titleLabel.Dock = DockStyle.Fill;
                    titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                    titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                    titleLabel.Height = 30;
                    titleLabel.ForeColor = Color.White;

                    cardPanel.Controls.Add(enrollButton, 0, 1);
                    outerPanel.Controls.Add(cardPanel);

                    enrollButton.Click += async (sender, e) =>
                    {

                        flowLayoutPanel.Controls.Clear();
                        StudentEnrolledCourseContent studentEnrolledCourseContent = new StudentEnrolledCourseContent();
                        studentEnrolledCourseContent.StudentEnrolledCourseContentShow(weekData, flowLayoutPanel, formName);

                    };

                    weekPanel.Controls.Add(outerPanel, counter, 0);
                }
            }
        }
    }
}
