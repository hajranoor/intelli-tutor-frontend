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

namespace intelli_tutor_frontend.StudentSide
{
    internal class ProblemsContent
    {

        ProblemApi ProblemApi = new ProblemApi();
        List<ProblemModel> problemList;

        public async void ProblemContentShow(int labId, FlowLayoutPanel flowLayoutPanel1)
        {
            problemList = await ProblemApi.getAllproblemData(labId);

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel1.Width-10;
            mainPanel.Height = flowLayoutPanel1.Height-10;
            mainPanel.AutoScroll = true;


            flowLayoutPanel1.Controls.Add(mainPanel);

            flowLayoutPanel1.SizeChanged += (sender, e) =>
            {
                mainPanel.Size = new Size(flowLayoutPanel1.Width-10, flowLayoutPanel1.Height-10);
                //flowLayoutPanel1.Margin = new Padding(3, 3, 3, 3);
            };
            int count = 1;
            foreach (var item in problemList)
            {

                Panel outerPanel = new Panel();
                ////outerPanel.Width = 1300;
                outerPanel.Height = 100;
                outerPanel.Margin = new Padding(20, 0, 20, 20);
                outerPanel.BorderStyle = BorderStyle.FixedSingle;
                outerPanel.Width = 1200;
                outerPanel.BackColor = Color.Lavender;
                mainPanel.SizeChanged += (sender, e) =>
                {
                    outerPanel.Size = new Size(mainPanel.Width - 10, outerPanel.Height);
                    //flowLayoutPanel1.Margin = new Padding(3, 3, 3, 3);
                };
                //outerPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

                TableLayoutPanel cardPanel = new TableLayoutPanel();
                cardPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = outerPanel.Width;
                cardPanel.Height = 100;
                cardPanel.Margin = new Padding(20, 10, 20, 10);
                cardPanel.BackColor = Color.Lavender;
                cardPanel.AutoScroll = true;

                flowLayoutPanel1.SizeChanged += (sender, e) =>
                {
                    outerPanel.Size = new Size(flowLayoutPanel1.Width - 60, outerPanel.Height);
                };
                cardPanel.ColumnCount = 2;

                Label titleLabel = new Label();
                titleLabel.Margin = new Padding(20, 10, 20, 10);
                titleLabel.Text = count + ".  " + item.problem_name;
                titleLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                titleLabel.Font = new Font("Segoe UI Semibold", 12F);
                titleLabel.Height = 30;
                titleLabel.Width = 300;
                titleLabel.Top = 15;
                titleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                count = count + 1;


                Panel buttonPanel = new Panel();
                buttonPanel.Height = 70;
                buttonPanel.Dock = DockStyle.Right; // Position the panel on the right
                buttonPanel.Margin = new Padding(0, 0, 20, 0); // Adjust margin for spacing

                Button enrollButton = new Button();
                enrollButton.Text = "Solve";
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
                    SolveProblem solveProblem = new SolveProblem(item);
                    solveProblem.Show();
                };

                buttonPanel.Controls.Add(enrollButton);

                // Add the label and button to the same row
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // First column
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200)); // Second column
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(buttonPanel);
                //cardPanel.SetColumnSpan(titleLabel, 1);

                outerPanel.Controls.Add(cardPanel);
                mainPanel.Controls.Add(outerPanel);


            }


        }
        public async void ProblemContentSho(int labId, FlowLayoutPanel flowLayoutPanel1)
        {
            problemList = await ProblemApi.getAllproblemData(labId);
            flowLayoutPanel1.AutoScroll = false;
            //flowLayoutPanel1.HorizontalScroll.Enabled = false;
            //flowLayoutPanel1.HorizontalScroll.Visible = false;
            //flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            //flowLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            int count = 1;
            Panel mainPanel = new Panel();
            //mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel1.Width-60;
            mainPanel.Height = flowLayoutPanel1.Height;
            mainPanel.AutoScroll = true;
            mainPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            flowLayoutPanel1.Controls.Add(mainPanel);

            flowLayoutPanel1.SizeChanged += (sender, e) =>
            {
                mainPanel.Size = new Size(flowLayoutPanel1.Width-60, flowLayoutPanel1.Height);
                flowLayoutPanel1.Margin = new Padding(3, 3, 3, 3);
            };

            foreach (var item in problemList)
            {
               
                Panel outerPanel = new Panel();
                ////outerPanel.Width = 1300;
                outerPanel.Height = 100;
                outerPanel.Margin = new Padding(20, 0, 20, 20);
                outerPanel.BorderStyle = BorderStyle.FixedSingle;
                outerPanel.Width = flowLayoutPanel1.Width - 60;
                outerPanel.BackColor = Color.Lavender;
                //outerPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;

                TableLayoutPanel cardPanel = new TableLayoutPanel();
                cardPanel.Anchor =AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = outerPanel.Width;
                cardPanel.Height = 100;
                cardPanel.Margin = new Padding(20, 10, 20, 10);
                cardPanel.BackColor = Color.Lavender;
                cardPanel.AutoScroll = true;

                flowLayoutPanel1.SizeChanged += (sender, e) =>
                {
                    outerPanel.Size = new Size(flowLayoutPanel1.Width - 60, outerPanel.Height);
                };
                cardPanel.ColumnCount = 2;

                Label titleLabel = new Label();
                titleLabel.Margin = new Padding(20, 10, 20, 10);
                titleLabel.Text = count + ".  " + item.problem_name;
                titleLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                titleLabel.Font = new Font("Segoe UI Semibold", 12F);
                titleLabel.Height = 30;
                titleLabel.Width = 300;
                titleLabel.Top = 15;
                titleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                count = count + 1;


                Panel buttonPanel = new Panel();
                buttonPanel.Height = 70;
                buttonPanel.Dock = DockStyle.Right; // Position the panel on the right
                buttonPanel.Margin = new Padding(0, 0, 20, 0); // Adjust margin for spacing

                Button enrollButton = new Button();
                enrollButton.Text = "Solve";
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
                    SolveProblem solveProblem = new SolveProblem(item);
                    solveProblem.Show();
                };

                buttonPanel.Controls.Add(enrollButton);

                // Add the label and button to the same row
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // First column
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200)); // Second column
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(buttonPanel);
                //cardPanel.SetColumnSpan(titleLabel, 1);

                outerPanel.Controls.Add(cardPanel);
                mainPanel.Controls.Add(outerPanel);


            }
        }
    }
}
