using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.CustomComponent;
using intelli_tutor_frontend.Model;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    internal class TeacherCourseWeek
    {
        WeekApi weekApi = new WeekApi();
        List<WeekModel> weeksList;

        public TeacherCourseWeek()
        {
            
        }
        

        public async void ShowCourseWeek(FlowLayoutPanel flowLayoutPanel, MainCourseAndCourseOfferingDTO course, Label formName, MenuStrip menuStrip)
        {
            flowLayoutPanel.Controls.Clear();

            MenuStripCourse menuStripCourse = new MenuStripCourse(menuStrip, flowLayoutPanel, formName, course);
            menuStripCourse.createMenu();

            formName.Text = "Course Week";
            weeksList = await weekApi.getAllWeekData(course.course_offering_id);
            //
            //mainPanel
            //
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

            //
            //courseTitle
            //
            Label courseTitle = new Label();
            courseTitle.Text = course.course_name;
            courseTitle.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            courseTitle.Dock = DockStyle.Fill;
            courseTitle.Font = new Font("Segoe UI Semibold", 16F);
            courseTitle.Height = 60;
            courseTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courseTitle.AutoSize = true;
            courseTitle.Margin = new Padding(10, 10, 10, 10);
            courseTitle.Padding = new Padding(0, 10, 0, 10);
            mainPanel.Controls.Add(courseTitle, 0, 1);

            //
            //CourseDescription
            //
            NoCaretRichTextBox CourseDescription = new NoCaretRichTextBox();
            CourseDescription.Text = course.description;
            CourseDescription.Font = new Font("Segoe UI", 14F);
            CourseDescription.Dock = DockStyle.Fill;
            CourseDescription.ReadOnly = true;
            CourseDescription.HideSelection = true;
            CourseDescription.BackColor = Color.Lavender;
            CourseDescription.BorderStyle = BorderStyle.None;

            //
            //descriptionPanel
            //
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
            //
            //table panel new
            //

            Panel responsivePanel = new Panel();
            responsivePanel.Dock = DockStyle.Fill;
            responsivePanel.Height = 500;
            responsivePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            responsivePanel.BorderStyle = BorderStyle.FixedSingle;
            responsivePanel.Padding = new Padding(2,2,2,19); // Add padding for content

            // Set rounded corners
            TableLayoutPanel tablePanel = new TableLayoutPanel();
            tablePanel.Dock = DockStyle.Fill;
            responsivePanel.Height = 456;
            tablePanel.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            tablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tablePanel.RowCount = 5;
            tablePanel.ColumnCount = 2;
            tablePanel.Font = new Font("Segoe UI", 10F);
            for (int i = 0; i < 5; i++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100/5));
            }

            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            //----------------------
            Label courseCodeLabel = new Label();
            courseCodeLabel.Text = "Course Code";
            courseCodeLabel.Font = new Font("Segoe UI", 10F);
            courseCodeLabel.Dock = DockStyle.Fill;
            courseCodeLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label courseCodeData = new Label();
            courseCodeData.Text = course.course_code;
            courseCodeData.Font = new Font("Segoe UI", 10F);
            courseCodeData.Dock = DockStyle.Fill;
            courseCodeData.TextAlign = ContentAlignment.MiddleCenter;
            //-----------------------

            Label contactHourLabel = new Label();
            contactHourLabel.Text = "Contact Hour";
            contactHourLabel.Font = new Font("Segoe UI", 10F);
            contactHourLabel.Dock = DockStyle.Fill;
            contactHourLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label contactHourData = new Label();
            contactHourData.Text = course.contact_hour.ToString();
            contactHourData.Font = new Font("Segoe UI", 10F);
            contactHourData.Dock = DockStyle.Fill;
            contactHourData.TextAlign = ContentAlignment.MiddleCenter;
            //------------------------

            Label creditHourLabel = new Label();
            creditHourLabel.Text = "Credit Hour";
            creditHourLabel.Font = new Font("Segoe UI", 10F);
            creditHourLabel.Dock = DockStyle.Fill;
            creditHourLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label creditHourData = new Label();
            creditHourData.Text = course.credit_hour.ToString();
            creditHourData.Font = new Font("Segoe UI", 10F);
            creditHourData.Dock = DockStyle.Fill;
            creditHourData.TextAlign = ContentAlignment.MiddleCenter;
            //------------------------

            Label capacityLabel = new Label();
            capacityLabel.Text = "Capacity";
            capacityLabel.Font = new Font("Segoe UI", 10F);
            capacityLabel.Dock = DockStyle.Fill;
            capacityLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label capacityData = new Label();
            capacityData.Text = course.capacity.ToString();
            capacityData.Font = new Font("Segoe UI", 10F);
            capacityData.Dock = DockStyle.Fill;
            capacityData.TextAlign = ContentAlignment.MiddleCenter;
            //------------------------

            Label semesterLabel = new Label();
            semesterLabel.Text = "Semester";
            semesterLabel.Font = new Font("Segoe UI", 10F);
            semesterLabel.Dock = DockStyle.Fill;
            semesterLabel.TextAlign = ContentAlignment.MiddleCenter;

            Label semesterData = new Label();
            semesterData.Text = course.semester.ToString();
            semesterData.Font = new Font("Segoe UI", 10F);
            semesterData.Dock = DockStyle.Fill;
            semesterData.TextAlign = ContentAlignment.MiddleCenter;
            //------------------------
            tablePanel.Controls.Add(courseCodeLabel, 0, 0);
            tablePanel.Controls.Add(courseCodeData, 1, 0);

            tablePanel.Controls.Add(contactHourLabel, 0, 1);
            tablePanel.Controls.Add(contactHourData, 1, 1);

            tablePanel.Controls.Add(creditHourLabel, 0, 2);
            tablePanel.Controls.Add(creditHourData, 1, 2);

            tablePanel.Controls.Add(capacityLabel, 0, 3);
            tablePanel.Controls.Add(capacityData, 1, 3);

            tablePanel.Controls.Add(semesterLabel, 0, 4);
            tablePanel.Controls.Add(semesterData, 1, 4);

            
            // Add controls or content to the table cells
            //for (int row = 0; row < 4; row++)
            //{
            //    for (int col = 0; col < 2; col++)
            //    {
            //        Label label = new Label();
            //        label.Text = $"Row {row + 1}, Col {col + 1}";
            //        label.Dock = DockStyle.Fill;
            //        label.TextAlign = ContentAlignment.MiddleCenter;

            //        tablePanel.Controls.Add(label, col, row);
            //    }
            //}

            ///
            //
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

            //
            //weekPanel
            //
            TableLayoutPanel weekPanel = new TableLayoutPanel();
            weekPanel.AutoScroll = true;
            weekPanel.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            weekPanel.Height = 250;
            weekPanel.VerticalScroll.Enabled = false;
            weekPanel.VerticalScroll.Visible = false;
            weekPanel.HorizontalScroll.Enabled = true;
            weekPanel.HorizontalScroll.Visible = true;
            weekPanel.Margin = new Padding(10, 20, 10, 20);

            mainPanel.Controls.Add(weekPanel, 0, 3);
            int counter = 0;

            if (weeksList.Count == 0)
            {
                //
                //messageLabel
                //
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

                    //
                    //outerPanel
                    //
                    Panel outerPanel = new Panel();
                    outerPanel.Width = 180;
                    outerPanel.Height = 180;
                    outerPanel.Margin = new Padding(20, 20, 20, 20);
                    outerPanel.BorderStyle = BorderStyle.FixedSingle;
                    //
                    //cardPanel
                    //
                    TableLayoutPanel cardPanel = new TableLayoutPanel();
                    cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                    cardPanel.Width = 180;
                    cardPanel.Height = 180;
                    cardPanel.Margin = new Padding(20, 20, 20, 20);
                    cardPanel.BackColor = Color.DarkSlateBlue;
                    //
                    //weekButton
                    //
                    Button weekButton = new Button();
                    weekButton.Text = "Week " + weekData.week_sequence.ToString();
                    weekButton.Dock = DockStyle.Fill;
                    weekButton.Width = 70;
                    weekButton.Height = 30;
                    weekButton.TextAlign = ContentAlignment.MiddleCenter;
                    weekButton.Font = new Font("Segoe UI Semibold", 16F);
                    weekButton.BackColor = Color.DarkSlateBlue;
                    weekButton.ForeColor = Color.White;
                    weekButton.FlatStyle = FlatStyle.Flat;

                    weekButton.Click += async (sender, e) =>
                    {
                        flowLayoutPanel.Controls.Clear();
                        TeacherCourseContent teacherCourseContent = new TeacherCourseContent();
                        teacherCourseContent.TeacherMyCoursesContentShow(weekData, flowLayoutPanel, formName);
                    };
                    //
                    //titleLabel
                    //
                    Label titleLabel = new Label();
                    titleLabel.Text = "Week " + weekData.week_sequence;
                    titleLabel.Dock = DockStyle.Fill;
                    titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                    titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                    titleLabel.Height = 30;
                    titleLabel.ForeColor = Color.White;

                    cardPanel.Controls.Add(weekButton, 0, 1);
                    outerPanel.Controls.Add(cardPanel);
                    weekPanel.Controls.Add(outerPanel, counter, 0);
                }
            }
        }
    }
}

