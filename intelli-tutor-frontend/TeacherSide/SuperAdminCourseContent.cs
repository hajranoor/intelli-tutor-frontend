using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    internal class SuperAdminCourseContent
    {
        List<MainContentModel> contentList = new List<MainContentModel>();
        MainContentApi mainContentApi = new MainContentApi();
        public async void SuperAdminCourseContentShow(MainWeekModel weekData , FlowLayoutPanel flowLayoutPanel1)
        {
            contentList = await mainContentApi.getMainContentByWeekId(weekData.week_id);

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel1.Width-10;
            mainPanel.Height = flowLayoutPanel1.Height-10;
            mainPanel.AutoScroll = true;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            //mainPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Controls.Add(mainPanel);
            //---------------------------------------------------------------

            Panel contentOuterPanel = new Panel();
            contentOuterPanel.Width = mainPanel.Width - 20;
            contentOuterPanel.BorderStyle = BorderStyle.FixedSingle;
            contentOuterPanel.BackColor = Color.Lavender;
            contentOuterPanel.Margin = new Padding(10, 10, 10, 10);

            TableLayoutPanel contentCardPanel = new TableLayoutPanel();
            contentCardPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            contentCardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            contentCardPanel.Width = mainPanel.Width - 20;
            contentCardPanel.ColumnCount = 4;
            contentCardPanel.Height = 100;
            contentCardPanel.Margin = new Padding(20, 10, 20, 10);
            contentCardPanel.BackColor = Color.Lavender;
            contentCardPanel.AutoScroll = true;

            contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            flowLayoutPanel1.SizeChanged += (sender, e) =>
            {

                mainPanel.Size = new Size(flowLayoutPanel1.Width - 10, flowLayoutPanel1.Height - 10);
                contentOuterPanel.Size = new Size(mainPanel.Width - 12, contentOuterPanel.Height);
                flowLayoutPanel1.Margin = new Padding(3, 3, 3, 3);
            };
            Label contentTypeLabel = new Label();
            contentTypeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentTypeLabel.Margin = new Padding(20, 10, 20, 10);
            contentTypeLabel.Text = "Course Type";
            contentTypeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentTypeLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentTypeLabel.Height = 30;
            //contentTypeLabel.Width = 400;
            contentTypeLabel.Top = 15;

            contentCardPanel.Controls.Add(contentTypeLabel, 0, 0);

            Label contentNameLabel = new Label();
            contentNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentNameLabel.Margin = new Padding(20, 10, 20, 10);
            contentNameLabel.Text = "Name";
            contentNameLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentNameLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentNameLabel.Height = 30;
            //contentNameLabel.Width = 400;
            contentNameLabel.Top = 15;

            contentCardPanel.Controls.Add(contentNameLabel, 1, 0);

            Label contentSequenceLabel = new Label();
            contentSequenceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentSequenceLabel.Margin = new Padding(20, 10, 20, 10);
            contentSequenceLabel.Text = "Sequence";
            contentSequenceLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentSequenceLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentSequenceLabel.Height = 30;
            //contentSequenceLabel.Width = 400;
            contentSequenceLabel.Top = 15;
            contentCardPanel.Controls.Add(contentSequenceLabel, 2, 0);

            Label contentActionLabel = new Label();
            contentActionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentActionLabel.Margin = new Padding(20, 10, 20, 10);
            contentActionLabel.Text = "Action";
            contentActionLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentActionLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentActionLabel.Height = 30;
            //contentSequenceLabel.Width = 400;
            contentActionLabel.Top = 15;

            contentCardPanel.Controls.Add(contentActionLabel, 3, 0);
            //cardPanel.SetColumnSpan(titleLabel, 1);
            contentOuterPanel.Controls.Add(contentCardPanel);
            mainPanel.Controls.Add(contentOuterPanel);

            //---------------------------------------------------------------

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
                cardPanel.Width = mainPanel.Width-20;
                cardPanel.ColumnCount = 4;
                cardPanel.Height = 100;
                cardPanel.Margin = new Padding(20, 10, 20, 10);
                cardPanel.BackColor = Color.Lavender;
                cardPanel.AutoScroll = true;
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

                flowLayoutPanel1.SizeChanged += (sender, e) =>
                {
                    
                    mainPanel.Size = new Size(flowLayoutPanel1.Width - 10, flowLayoutPanel1.Height - 10);
                    outerPanel.Size = new Size(mainPanel.Width-12, outerPanel.Height);
                    flowLayoutPanel1.Margin = new Padding(3, 3, 3, 3);
                };

                Label typeLabel = new Label();
                typeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                typeLabel.Margin = new Padding(20, 10, 20, 10);
                typeLabel.Text = item.content_type;
                typeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                typeLabel.Font = new Font("Segoe UI Semibold", 12F);
                typeLabel.Height = 30;
                //contentTypeLabel.Width = 400;
                typeLabel.Top = 15;

                cardPanel.Controls.Add(typeLabel, 0, 0);

                Label nameLabel = new Label();
                nameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                nameLabel.Margin = new Padding(20, 10, 20, 10);
                nameLabel.Text = item.content_name;
                nameLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                nameLabel.Font = new Font("Segoe UI Semibold", 12F);
                nameLabel.Height = 30;
                //contentNameLabel.Width = 400;
                nameLabel.Top = 15;

                cardPanel.Controls.Add(nameLabel, 1, 0);

                Label sequenceLabel = new Label();
                sequenceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                sequenceLabel.Margin = new Padding(20, 10, 20, 10);
                sequenceLabel.Text = item.sequence_number.ToString();
                sequenceLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                sequenceLabel.Font = new Font("Segoe UI Semibold", 12F);
                sequenceLabel.Height = 30;
                //contentSequenceLabel.Width = 400;
                sequenceLabel.Top = 15;
                cardPanel.Controls.Add(sequenceLabel, 2, 0);


                Panel buttonPanel = new Panel();
                buttonPanel.Height = 70;
                //buttonPanel.Dock = DockStyle.Right; // Position the panel on the right
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
                    //SolveProblem solveProblem = new SolveProblem(item.content_id);
                    //solveProblem.Show();
                };

                buttonPanel.Controls.Add(enrollButton);

                // Add the label and button to the same row
                
                cardPanel.Controls.Add(buttonPanel, 3,0);
                count ++;
                //cardPanel.SetColumnSpan(titleLabel, 1);
                outerPanel.Controls.Add(cardPanel);
                mainPanel.Controls.Add(outerPanel);


            }


        }
    }
}
