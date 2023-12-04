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

namespace intelli_tutor_frontend.TeacherSide
{
    internal class CourseWeek
    {
        //WeekApi weekApi = new WeekApi();
        //List<weekModel> weeksList;

        public List<string> weeksList = new List<string>
        {
            "Week 1",
            "Week 2",
            "Week 3",
            "Week 1",
            "Week 2",
            "Week 3",
            "Week 1",
            "Week 2",
            "Week 3",
            // Add more week titles as needed
        };

        public async void CourseContentSjow(FlowLayoutPanel flowLayoutPanel1)
        {
            //weeksList = await weekApi.getAllWeekData(myCourseData.course_id);
           

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel1.Width;
            mainPanel.Height = flowLayoutPanel1.Height;
            mainPanel.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(mainPanel);

            flowLayoutPanel1.SizeChanged += (sender, e) =>
            {
                mainPanel.Size = new Size(flowLayoutPanel1.Width, flowLayoutPanel1.Height);
                flowLayoutPanel1.Margin = new Padding(3, 3, 3, 3);
            };


            Label courseTitle = new Label();
            //courseTitle.Text = myCourseData.course_title;
            courseTitle.Text = "Object Oriented Programming";
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
            //CourseDescription.Text = myCourseData.description;
            CourseDescription.Text = "In summary, Object-Oriented Programming is a programming paradigm that structures code around objects and classes, promoting principles such as encapsulation, inheritance, polymorphism, and abstraction. It provides a powerful way to model real-world entities and create modular, maintainable, and reusable software. OOP is commonly used in languages like Java, C++, C#, and Python, among others.";
            CourseDescription.Font = new Font("Segoe UI", 14F);
            CourseDescription.Dock = DockStyle.Fill;
            CourseDescription.ReadOnly = true;
            CourseDescription.HideSelection = true;
            CourseDescription.BackColor = Color.Lavender;
            CourseDescription.BorderStyle = BorderStyle.None;
            // Add CourseDescription to your form's controls

            Panel descriptionPanel = new Panel();
            descriptionPanel.Margin = new Padding(10, 10, 10, 10);
            descriptionPanel.Dock = DockStyle.Fill;
            descriptionPanel.AutoScroll = true;
            descriptionPanel.BackColor = Color.Lavender;
            descriptionPanel.Height = 280;
            descriptionPanel.Controls.Add(CourseDescription);
            descriptionPanel.BackColor = Color.Lavender;
            descriptionPanel.Padding = new Padding(10, 50, 10, 10);
            descriptionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Button editButton = new Button();
            editButton.Text = "Edit";
            //editButton.Dock = DockStyle.Right;
            editButton.Width = 70;
            editButton.Height = 40;
            editButton.TextAlign = ContentAlignment.MiddleCenter;
            editButton.Font = new Font("Segoe UI Semibold", 16F);
            editButton.BackColor = Color.DarkSlateBlue;
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right; // Position at top right corner
            editButton.ForeColor = Color.White;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Click += (sender, e) =>
            {
                MessageBox.Show("Edit Description");
            };

            descriptionPanel.Controls.Add(editButton); // Add the edit button to the description panel
            descriptionPanel.Controls.Add(CourseDescription);

            mainPanel.Controls.Add(descriptionPanel, 0, 2);


            TableLayoutPanel weekPanel = new TableLayoutPanel();
            weekPanel.AutoScroll = true;
            weekPanel.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            weekPanel.Height = 250;
            //weekPanel.Dock = DockStyle.Bottom;
            //weekPanel.BackColor = Color.Cyan;
            weekPanel.VerticalScroll.Enabled = false;
            weekPanel.VerticalScroll.Visible = false;
            weekPanel.HorizontalScroll.Enabled = true;
            weekPanel.HorizontalScroll.Visible = true;
            mainPanel.Controls.Add(weekPanel, 0, 3);

            int newRow = weekPanel.RowCount++;
            weekPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            Button newbutton = new Button();
            newbutton.Text = "Edit";
            newbutton.Width = 70;
            newbutton.Height = 40;
            newbutton.TextAlign = ContentAlignment.MiddleCenter;
            newbutton.Font = new Font("Segoe UI Semibold", 16F);
            newbutton.BackColor = Color.DarkSlateBlue;
            newbutton.ForeColor = Color.White;
            newbutton.FlatStyle = FlatStyle.Flat;
            newbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            weekPanel.Controls.Add(newbutton, 0, newRow);
            int counter = 0;
            weekPanel.Margin = new Padding(10, 10, 10, 0);
            foreach (var item in weeksList)
            {
                counter += 1;
                Panel outerPanel = new Panel();
                outerPanel.Width = 180;
                outerPanel.Height = 180;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                ////outerPanel.BackColor = Color.Lavender;
                outerPanel.BorderStyle = BorderStyle.FixedSingle;
                TableLayoutPanel cardPanel = new TableLayoutPanel();
                ////cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = 180;
                cardPanel.Height = 180;
                cardPanel.Margin = new Padding(20, 20, 20, 20);
                cardPanel.BackColor = Color.DarkSlateBlue;
                //cardPanel.AutoScroll = true;

                Button enrollButton = new Button();
                enrollButton.Text = "Week " + counter;
                enrollButton.Dock = DockStyle.Fill;
                enrollButton.Width = 70;
                enrollButton.Height = 30;
                enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                //enrollButton.Padding = new Padding(5, 15, 5, 15);
                enrollButton.Font = new Font("Segoe UI Semibold", 16F);
                enrollButton.BackColor = Color.DarkSlateBlue;
                enrollButton.ForeColor = Color.White;
                enrollButton.FlatStyle = FlatStyle.Flat;
                //enrollButton.Click += async (sender, e) =>
                //{

                //flowLayoutPanel1.Controls.Clear();
                //CourseContent c = new CourseContent();
                //c.CourseContentSjow(item, flowLayoutPanel1);

                //};

                Label titleLabel = new Label();
                titleLabel.Text = "Week " + counter;

                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                titleLabel.Height = 30;
                titleLabel.ForeColor = Color.White;

                cardPanel.Controls.Add(enrollButton, 0, 1);
                outerPanel.Controls.Add(cardPanel);

                enrollButton.Click += async (sender, e) =>
                {

                    flowLayoutPanel1.Controls.Clear();
                    //LabsContent l = new LabsContent();
                    //l.LabContentShow(item.week_id, flowLayoutPanel1);

                };

                weekPanel.Controls.Add(outerPanel, counter, 0);
            }
        }
    }
}

