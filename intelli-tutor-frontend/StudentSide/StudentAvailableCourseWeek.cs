using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.CustomComponent;
using intelli_tutor_frontend.Model;
using intelli_tutor_frontend.TeacherSide;
using MVCproject.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.StudentSide
{
    internal class StudentAvailableCourseWeek
    {
        WeekApi weekApi = new WeekApi();
        TeacherApi teacherApi = new TeacherApi();

        List<UserAndTeacherDTO> teacherInfo;
        List<WeekModel> weeksList;

        public async void AvailableCourseWeekShow(MainCourseAndCourseOfferingAndTeacherDTO myCourseData, FlowLayoutPanel flowLayoutPanel1, Label formName)
        {
            flowLayoutPanel1.Controls.Clear();
            formName.Text = "Course Description";
            teacherInfo = await teacherApi.getTeacher(myCourseData.teacher_id);
            weeksList = await weekApi.getAllMainWeekDataByCourseOfferingId(myCourseData.course_offering_id);

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel1.Width;
            mainPanel.Height = flowLayoutPanel1.Height;
            mainPanel.AutoScroll = true;

            //new added lines
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // Adjust the percentage as needed
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            mainPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None; // Remove cell borders





            flowLayoutPanel1.Controls.Add(mainPanel);

            flowLayoutPanel1.SizeChanged += (sender, e) =>
            {
                mainPanel.Size = new Size(flowLayoutPanel1.Width, flowLayoutPanel1.Height);
                flowLayoutPanel1.Margin = new Padding(3, 3, 3, 3);
            };


            Label courseTitle = new Label();
            courseTitle.Text = myCourseData.course_name;
            courseTitle.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            courseTitle.Dock = DockStyle.Fill;
            courseTitle.Font = new Font("Segoe UI Semibold", 16F);
            courseTitle.Height = 60;
            courseTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courseTitle.AutoSize = true;
            courseTitle.Margin = new Padding(10, 10, 10, 10);
            courseTitle.Padding = new Padding(0, 10, 0, 10);
            mainPanel.Controls.Add(courseTitle, 0, 1);

            Panel tabPanel = new Panel();
            tabPanel.Dock = DockStyle.Fill;

            
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            TabPage descriptionTabPage = new TabPage("Course Description");
            TabPage otherTabPage = new TabPage("Course Details");
















            NoCaretRichTextBox CourseDescription = new NoCaretRichTextBox();
            CourseDescription.Text = myCourseData.description;
            CourseDescription.Font = new Font("Segoe UI", 14F);
            CourseDescription.Dock = DockStyle.Fill;
            CourseDescription.ReadOnly = true;
            CourseDescription.HideSelection = true;
            CourseDescription.BackColor = Color.Lavender;
            CourseDescription.BorderStyle = BorderStyle.None;

            TableLayoutPanel otherInfoPanel = new TableLayoutPanel();
            otherInfoPanel.Dock = DockStyle.Fill;
            otherInfoPanel.AutoSize = true;
            otherInfoPanel.AutoScroll = true;
            otherInfoPanel.ColumnCount = 2; // You can adjust the number of columns as needed

            otherInfoPanel.Controls.Add(new Label() { Text = "Course Capacity: ", Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true }, 0, 0);
            otherInfoPanel.Controls.Add(new Label() { Text = myCourseData.capacity.ToString(), Font = new Font("Segoe UI", 12), AutoSize = true }, 1, 0);

            otherInfoPanel.Controls.Add(new Label() { Text = "Offering Year: ", Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true }, 0, 1);
            otherInfoPanel.Controls.Add(new Label() { Text = myCourseData.offering_year.ToString(), Font = new Font("Segoe UI", 12), AutoSize = true }, 1, 1);

            otherInfoPanel.Controls.Add(new Label() { Text = "Semester: ", Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true }, 0, 2);
            otherInfoPanel.Controls.Add(new Label() { Text = myCourseData.semester.ToString(), Font = new Font("Segoe UI", 12), AutoSize = true }, 1, 2);

            //otherInfoPanel.Controls.Add(new Label() { Text = "Instructor's Email: ", Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true }, 0, 3);
            //otherInfoPanel.Controls.Add(new Label() { Text = myCourseData.email.ToString(), Font = new Font("Segoe UI", 12), AutoSize = true }, 1, 3);





            Label otherContentLabel = new Label();
            otherContentLabel.Text = "Additional information for the other tab.";
            otherContentLabel.Font = new Font("Segoe UI", 12F);
            otherContentLabel.Dock = DockStyle.Fill;
            otherContentLabel.TextAlign = ContentAlignment.MiddleCenter;

            descriptionTabPage.Controls.Add(CourseDescription);
            otherTabPage.Controls.Add(otherInfoPanel);

            tabControl.TabPages.Add(descriptionTabPage);
            tabControl.TabPages.Add(otherTabPage);

            // Add DrawItem event handler to customize tab appearance
            tabControl.DrawItem += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Brush _textBrush;
                Font tabFont = new Font("Segoe UI", 12F, FontStyle.Bold); // Set custom font for tab text

                // Get the current tab
                TabPage _tabPage = tabControl.TabPages[e.Index];

                // Get the bounds of the tab
                Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

                int padding = 10;
                RectangleF textBounds = new RectangleF(_tabBounds.X + padding, _tabBounds.Y, _tabBounds.Width - 2 * padding, _tabBounds.Height);

                



                // Set the text color based on tab selection
                if (e.State == DrawItemState.Selected)
                {
                    _textBrush = new SolidBrush(Color.White); // Set text color for selected tab
                    g.FillRectangle(Brushes.DarkSlateBlue, e.Bounds); // Set background color for selected tab
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    int radius = 10; // Set the radius for rounded corners
                    int x = e.Bounds.X;
                    int y = e.Bounds.Y;
                    int width = e.Bounds.Width;
                    int height = e.Bounds.Height;
                    path.AddArc(x, y, radius, radius, 180, 90);
                    path.AddArc(x + width - radius, y, radius, radius, 270, 90);
                    path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
                    path.AddArc(x, y + height - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    e.Graphics.FillPath(Brushes.DarkSlateBlue, path);

                }
                else
                {
                    _textBrush = new SolidBrush(Color.Black); // Set text color for unselected tab
                    g.FillRectangle(Brushes.LightGray, e.Bounds); // Set background color for unselected tab
                    e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    int radius = 10; // Set the radius for rounded corners
                    int x = e.Bounds.X;
                    int y = e.Bounds.Y;
                    int width = e.Bounds.Width;
                    int height = e.Bounds.Height;
                    path.AddArc(x, y, radius, radius, 180, 90);
                    path.AddArc(x + width - radius, y, radius, radius, 270, 90);
                    path.AddLine(x + width, y + radius, x + width, y + height - radius);
                    path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
                    path.AddArc(x, y + height - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    e.Graphics.FillPath(Brushes.LightGray, path);

                }

                // Draw the text on the tab
                StringFormat _stringFlags = new StringFormat();
                _stringFlags.Alignment = StringAlignment.Center;
                _stringFlags.LineAlignment = StringAlignment.Center;
                g.DrawString(_tabPage.Text, tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
            };

            // Set the DrawMode of the TabControl to OwnerDrawFixed to enable custom drawing
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(tabControl.Width / tabControl.TabCount, 50);

            
















            tabPanel.Controls.Add(tabControl);




            Panel descriptionPanel = new Panel();
            descriptionPanel.Margin = new Padding(10, 10, 10, 10);
            descriptionPanel.Dock = DockStyle.Fill;
            descriptionPanel.AutoScroll = true;
            descriptionPanel.BackColor = Color.Lavender;
            descriptionPanel.Height = 500;
            descriptionPanel.Controls.Add(tabPanel);
            descriptionPanel.BackColor = Color.Lavender;
            descriptionPanel.Padding = new Padding(10, 10, 10, 10);
            descriptionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            mainPanel.Controls.Add(descriptionPanel, 0, 2);  //was 0,2


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

                    enrollButton.Text = "Week " + weekData.week_sequence.ToString();
                    enrollButton.Dock = DockStyle.Fill;
                    enrollButton.Width = 70;
                    enrollButton.Height = 30;
                    enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                    enrollButton.Font = new Font("Segoe UI Semibold", 16F);
                    enrollButton.BackColor = Color.DarkSlateBlue;
                    enrollButton.ForeColor = Color.White;
                    enrollButton.FlatStyle = FlatStyle.Flat;

                    enrollButton.Click += async (sender, e) =>
                    {



                    };

                    Label titleLabel = new Label();
                    titleLabel.Text = "Week " + counter;
                    titleLabel.Dock = DockStyle.Fill;
                    titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                    titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                    titleLabel.Height = 30;
                    titleLabel.ForeColor = Color.White;

                    cardPanel.Controls.Add(enrollButton, 0, 1);
                    outerPanel.Controls.Add(cardPanel);


                    weekPanel.Controls.Add(outerPanel, counter, 0);
                }
            }
        }
    }
}
