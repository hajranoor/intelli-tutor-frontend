using intelli_tutor_frontend.BackendApi;
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
    internal class TeacherAddWeek
    {
        WeekApi weekApi = new WeekApi();
        public async void ShowTeacherAddWeek(MainCourseAndCourseOfferingDTO myCourse, FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "Add New Week";

            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //
            //mainPanel
            //
            Panel panel = new Panel();
            TableLayoutPanel mainPanel = new TableLayoutPanel();
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel.Width;
            mainPanel.Height = flowLayoutPanel.Height;
            mainPanel.AutoScroll = true;
            mainPanel.RowCount = 10;
            mainPanel.ColumnCount = 4;

            flowLayoutPanel.Controls.Add(mainPanel);
            flowLayoutPanel.SizeChanged += (sender, e) =>
            {
                mainPanel.Size = new Size(flowLayoutPanel.Width, flowLayoutPanel.Height);
                flowLayoutPanel.Margin = new Padding(3, 3, 3, 3);
            };

            //
            //regexLabel
            //
            Label weekNameLabel = new Label();
            weekNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            weekNameLabel.Margin = new Padding(20, 10, 20, 10);
            weekNameLabel.Text = "Week Name";
            weekNameLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            weekNameLabel.Font = new Font("Segoe UI Semibold", 12F);
            weekNameLabel.Height = 30;
            weekNameLabel.Width = 400;
            weekNameLabel.Top = 15;

            mainPanel.Controls.Add(weekNameLabel, 0, 0);

            TextBox weekNameTextBox = new TextBox();
            weekNameTextBox.Margin = new Padding(20, 10, 20, 10);
            weekNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            weekNameTextBox.Font = new Font("Segoe UI Semibold", 12F);
            weekNameTextBox.Height = 30;
            weekNameTextBox.Width = 400;
            weekNameTextBox.Top = 15;

            mainPanel.Controls.Add(weekNameTextBox, 1, 0);
   
            //---------------------------------------------
            //
            //descriptionLabel
            //
            Label descriptionLabel = new Label();
            descriptionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            descriptionLabel.Margin = new Padding(20, 10, 20, 10);
            descriptionLabel.Text = "Description";
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            descriptionLabel.Font = new Font("Segoe UI Semibold", 12F);
            descriptionLabel.Height = 30;
            descriptionLabel.Width = 400;
            descriptionLabel.Top = 15;

            mainPanel.Controls.Add(descriptionLabel, 0, 1);

            RichTextBox descriptionTextBox = new RichTextBox();
            descriptionTextBox.Margin = new Padding(20, 10, 20, 10);
            descriptionTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            descriptionTextBox.Font = new Font("Segoe UI Semibold", 12F);
            descriptionTextBox.Height = 100;
            descriptionTextBox.Width = 400;
            descriptionTextBox.Top = 15;

            mainPanel.Controls.Add(descriptionTextBox, 1, 1);
            
            ////---------------------------------------------------------

            Button addButton = new Button();
            addButton.Text = "Add";
            addButton.Dock = DockStyle.Fill;
            addButton.Height = 65;
            //createButton.Dock = DockStyle.Bottom;
            addButton.Margin = new Padding(150, 300, 150, 20);
            addButton.Width = 70;
            addButton.TextAlign = ContentAlignment.MiddleCenter;
            addButton.Padding = new Padding(5, 15, 5, 15);
            addButton.Font = new Font("Segoe UI Semibold", 12F);
            addButton.BackColor = Color.DarkSlateBlue;
            addButton.ForeColor = Color.White;
            addButton.Click += async (sender, e) =>
            {
                if (!string.IsNullOrEmpty(weekNameTextBox.Text) && !string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    WeekModel weekModel = new WeekModel();
                    weekModel.course_offering_id = myCourse.course_offering_id;
                    weekModel.week_name = weekNameTextBox.Text;
                    weekModel.description = descriptionTextBox.Text;
                    weekModel.week_sequence = 0;
                    int newWeekId = await weekApi.InsertWeekData(weekModel);
                    if (newWeekId != -1)
                    {
                        MessageBox.Show("Week Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        weekNameTextBox.Text = "";
                        descriptionTextBox.Text = "";
                    }
                    else
                    {
                        await weekApi.deleteWeekByWeekId(newWeekId);
                        MessageBox.Show("Fill the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };
            mainPanel.Controls.Add(addButton, 1, 2);
        }
    }
}
