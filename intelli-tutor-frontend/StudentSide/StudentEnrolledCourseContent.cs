﻿using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.StudentSide
{
    internal class StudentEnrolledCourseContent
    {
        List<ContentModel> contentList = new List<ContentModel>();
        ContentApi contentApi = new ContentApi();
        public async void StudentEnrolledCourseContentShow(WeekModel weekData, FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "Course Content";
            contentList = await contentApi.getContentByWeekId(weekData.week_id);

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel.Width - 10;
            mainPanel.Height = flowLayoutPanel.Height - 10;
            mainPanel.AutoScroll = true;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            flowLayoutPanel.Controls.Add(mainPanel);

            if (contentList.Count == 0)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = mainPanel.Width;
                outerPanel.Height = mainPanel.Height;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                Label messageLabel = new Label();
                messageLabel.Text = "No content available!";
                messageLabel.Dock = DockStyle.Fill;
                messageLabel.TextAlign = ContentAlignment.MiddleCenter;
                messageLabel.Font = new Font("Segoe UI Semibold", 16F);
                messageLabel.Height = 30;
                messageLabel.ForeColor = Color.Black;
                flowLayoutPanel.Controls.Add(messageLabel);

                outerPanel.Controls.Add(messageLabel);

                mainPanel.Controls.Add(outerPanel);
            }
            else
            {
                Panel contentOuterPanel = new Panel();
                contentOuterPanel.Width = mainPanel.Width - 20;
                contentOuterPanel.BorderStyle = BorderStyle.FixedSingle;
                contentOuterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                contentOuterPanel.Margin = new Padding(10, 10, 10, 10);

                TableLayoutPanel contentCardPanel = new TableLayoutPanel();
                contentCardPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                contentCardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                contentCardPanel.Width = mainPanel.Width - 20;
                contentCardPanel.ColumnCount = 4;
                contentCardPanel.Height = 100;
                contentCardPanel.Margin = new Padding(20, 10, 20, 10);
                contentCardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                contentCardPanel.AutoScroll = true;

                contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                flowLayoutPanel.SizeChanged += (sender, e) =>
                {

                    mainPanel.Size = new Size(flowLayoutPanel.Width - 10, flowLayoutPanel.Height - 10);
                    contentOuterPanel.Size = new Size(mainPanel.Width - 12, contentOuterPanel.Height);
                    flowLayoutPanel.Margin = new Padding(3, 3, 3, 3);
                };
                Label contentTypeLabel = new Label();
                contentTypeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                contentTypeLabel.Margin = new Padding(20, 10, 20, 10);
                contentTypeLabel.Text = "Course Type";
                contentTypeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                contentTypeLabel.Font = new Font("Segoe UI Semibold", 12F);
                contentTypeLabel.Height = 30;
                contentTypeLabel.Top = 15;

                contentCardPanel.Controls.Add(contentTypeLabel, 0, 0);

                Label contentNameLabel = new Label();
                contentNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                contentNameLabel.Margin = new Padding(20, 10, 20, 10);
                contentNameLabel.Text = "Name";
                contentNameLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                contentNameLabel.Font = new Font("Segoe UI Semibold", 12F);
                contentNameLabel.Height = 30;
                contentNameLabel.Top = 15;

                contentCardPanel.Controls.Add(contentNameLabel, 1, 0);

                Label contentSequenceLabel = new Label();
                contentSequenceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                contentSequenceLabel.Margin = new Padding(20, 10, 20, 10);
                contentSequenceLabel.Text = "Sequence";
                contentSequenceLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                contentSequenceLabel.Font = new Font("Segoe UI Semibold", 12F);
                contentSequenceLabel.Height = 30;
                contentSequenceLabel.Top = 15;
                contentCardPanel.Controls.Add(contentSequenceLabel, 2, 0);

                Label contentActionLabel = new Label();
                contentActionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                contentActionLabel.Margin = new Padding(20, 10, 20, 10);
                contentActionLabel.Text = "Action";
                contentActionLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                contentActionLabel.Font = new Font("Segoe UI Semibold", 12F);
                contentActionLabel.Height = 30;
                contentActionLabel.Top = 15;

                contentCardPanel.Controls.Add(contentActionLabel, 3, 0);
                contentOuterPanel.Controls.Add(contentCardPanel);
                mainPanel.Controls.Add(contentOuterPanel);

                int count = 0;
                foreach (var item in contentList)
                {
                    Panel outerPanel = new Panel();
                    outerPanel.Width = mainPanel.Width - 20;
                    outerPanel.BorderStyle = BorderStyle.FixedSingle;
                    outerPanel.BackColor = Color.Lavender;
                    outerPanel.Margin = new Padding(10, 10, 10, 10);
                    TableLayoutPanel cardPanel = new TableLayoutPanel();
                    cardPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                    cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                    cardPanel.Width = mainPanel.Width - 20;
                    cardPanel.ColumnCount = 4;
                    cardPanel.Height = 100;
                    cardPanel.Margin = new Padding(20, 10, 20, 10);
                    cardPanel.BackColor = Color.Lavender;
                    cardPanel.AutoScroll = true;
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

                    flowLayoutPanel.SizeChanged += (sender, e) =>
                    {

                        mainPanel.Size = new Size(flowLayoutPanel.Width - 10, flowLayoutPanel.Height - 10);
                        outerPanel.Size = new Size(mainPanel.Width - 12, outerPanel.Height);
                        flowLayoutPanel.Margin = new Padding(3, 3, 3, 3);
                    };

                    Label typeLabel = new Label();
                    typeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    typeLabel.Margin = new Padding(20, 10, 20, 10);
                    typeLabel.Text = item.content_type;
                    typeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                    typeLabel.Font = new Font("Segoe UI Semibold", 12F);
                    typeLabel.Height = 30;
                    typeLabel.Top = 15;

                    cardPanel.Controls.Add(typeLabel, 0, 0);

                    Label nameLabel = new Label();
                    nameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    nameLabel.Margin = new Padding(20, 10, 20, 10);
                    nameLabel.Text = item.content_name;
                    nameLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                    nameLabel.Font = new Font("Segoe UI Semibold", 12F);
                    nameLabel.Height = 30;
                    nameLabel.Top = 15;

                    cardPanel.Controls.Add(nameLabel, 1, 0);

                    Label sequenceLabel = new Label();
                    sequenceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    sequenceLabel.Margin = new Padding(20, 10, 20, 10);
                    sequenceLabel.Text = item.sequence_number.ToString();
                    sequenceLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                    sequenceLabel.Font = new Font("Segoe UI Semibold", 12F);
                    sequenceLabel.Height = 30;
                    sequenceLabel.Top = 15;
                    cardPanel.Controls.Add(sequenceLabel, 2, 0);


                    Panel buttonPanel = new Panel();
                    buttonPanel.Height = 70;
                    buttonPanel.Margin = new Padding(0, 0, 20, 0); // Adjust margin for spacing

                    Button enrollButton = new Button();
                    enrollButton.Text = "View";
                    enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                    enrollButton.Height = 60;
                    enrollButton.Width = 100;
                    enrollButton.Top = 15;
                    enrollButton.Padding = new Padding(5, 5, 5, 5); // Adjust padding
                    enrollButton.Font = new Font("Segoe UI Semibold", 12F);
                    enrollButton.BackColor = Color.DarkSlateBlue;
                    enrollButton.ForeColor = Color.White;
                    enrollButton.Click += (sender, e) =>
                    {
                        if (item.content_type == "Problem")
                        {
                            SolveProblem solveProblem = new SolveProblem(item.content_id);
                            solveProblem.Show();
                        }

                    };

                    buttonPanel.Controls.Add(enrollButton);
                    cardPanel.Controls.Add(buttonPanel, 3, 0);
                    count++;
                    outerPanel.Controls.Add(cardPanel);
                    mainPanel.Controls.Add(outerPanel);
                }
            }
        }
    }
}
