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
    internal class TeacherViewProblem
    {
        ProblemModel problem = new ProblemModel();
        ProblemApi problemApi = new ProblemApi();
        public async void ShowTeacherViewProblem(ContentModel content, FlowLayoutPanel flowLayoutPanel, Label formName, WeekModel weekData)
        {
            formName.Text = "View Problem";

            problem = await problemApi.getproblemData(content.content_id);

            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel.Width - 10;
            mainPanel.Height = flowLayoutPanel.Height - 10;
            mainPanel.AutoScroll = true;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            

            flowLayoutPanel.Controls.Add(mainPanel);

            if (problem != null)
            {
                Label titleLabel = new Label();
                titleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                titleLabel.Margin = new Padding(20, 10, 20, 10);
                titleLabel.Text = "Problem Name";
                titleLabel.TextAlign = ContentAlignment.TopLeft; // Align text to the left
                titleLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
                titleLabel.Height = 35;
                titleLabel.Top = 15;

                mainPanel.Controls.Add(titleLabel, 0, 0);


                Label titleContent = new Label();
                titleContent.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                titleContent.Margin = new Padding(20, 10, 20, 20);
                titleContent.Text = problem.problem_name;
                titleContent.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                titleContent.Font = new Font("Segoe UI ", 12F);
                titleContent.Height = 35;
                //titleContent.Top = 15;

                mainPanel.Controls.Add(titleContent, 0, 1);

                Label descriptionLabel = new Label();
                descriptionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                descriptionLabel.Margin = new Padding(20, 10, 20, 10);
                descriptionLabel.Text = "Description";
                descriptionLabel.TextAlign = ContentAlignment.TopLeft; // Align text to the left
                descriptionLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
                descriptionLabel.Height = 35;
                descriptionLabel.Top = 15;

                mainPanel.Controls.Add(descriptionLabel, 0, 2);

                NoCaretRichTextBox descriptionContent = new NoCaretRichTextBox();
                descriptionContent.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                descriptionContent.Margin = new Padding(20, 10, 20, 20);
                descriptionContent.Text = problem.description;
                descriptionContent.Font = new Font("Segoe UI", 12F);
                descriptionContent.Top = 15;
                descriptionContent.Multiline = true;
                descriptionContent.BackColor = Color.Lavender;
                descriptionContent.BorderStyle = BorderStyle.FixedSingle;

                mainPanel.Controls.Add(descriptionContent, 0, 3);

                Label regexLabel = new Label();
                regexLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                regexLabel.Margin = new Padding(20, 10, 20, 10);
                regexLabel.Text = "Regex";
                regexLabel.TextAlign = ContentAlignment.TopLeft; // Align text to the left
                regexLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
                regexLabel.Height = 35;
                regexLabel.Top = 15;

                mainPanel.Controls.Add(regexLabel, 0, 4);

                NoCaretRichTextBox regContent = new NoCaretRichTextBox();
                regContent.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                regContent.Margin = new Padding(20, 10, 20, 10);
                regContent.Text = problem.regex;
                regContent.Font = new Font("Segoe UI", 12F);
                regContent.Multiline = true;
                regContent.BackColor = Color.Lavender;
                regContent.BorderStyle = BorderStyle.FixedSingle;

                mainPanel.Controls.Add(regContent, 0, 5);

                Label starterCodeLabel = new Label();
                starterCodeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                starterCodeLabel.Margin = new Padding(20, 10, 20, 10);
                starterCodeLabel.Text = "Starter Code";
                starterCodeLabel.TextAlign = ContentAlignment.TopLeft; // Align text to the left
                starterCodeLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
                starterCodeLabel.Height = 35;
                starterCodeLabel.Top = 15;

                mainPanel.Controls.Add(starterCodeLabel, 0, 6);

                NoCaretRichTextBox starterCodeContent = new NoCaretRichTextBox();
                starterCodeContent.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                starterCodeContent.Margin = new Padding(20, 10, 20, 10);
                starterCodeContent.Text = problem.starter_code;
                starterCodeContent.Font = new Font("Segoe UI", 12F);
                starterCodeContent.Multiline = true;
                starterCodeContent.BackColor = Color.Lavender;
                starterCodeContent.BorderStyle = BorderStyle.FixedSingle;

                mainPanel.Controls.Add(starterCodeContent, 0, 7);
                TableLayoutPanel buttonPanel = new TableLayoutPanel();
                buttonPanel.Height = 65;
                buttonPanel.Margin = new Padding(150, 0, 150, 20);
                buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
                buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));


                Button backButton = new Button();

                backButton.Text = "Back";
                backButton.Dock = DockStyle.Fill;
                backButton.Width = 70;
                backButton.TextAlign = ContentAlignment.MiddleCenter;
                backButton.Padding = new Padding(5, 15, 5, 15);
                backButton.Font = new Font("Segoe UI Semibold", 12F);
                backButton.BackColor = Color.DarkSlateBlue;
                backButton.ForeColor = Color.White;
                backButton.Click += async (sender, e) =>
                {
                    flowLayoutPanel.Controls.Clear();
                    TeacherCourseContent teacherCourseContent = new TeacherCourseContent();
                    teacherCourseContent.TeacherMyCoursesContentShow(weekData, flowLayoutPanel, formName);

                };

                buttonPanel.Controls.Add(backButton,1,0);
                mainPanel.Controls.Add(buttonPanel, 0, 8);

            }
            else
            {
                Label messageLabel = new Label();
                messageLabel.Text = "No Problem exists available!";
                messageLabel.Dock = DockStyle.Fill;
                messageLabel.TextAlign = ContentAlignment.MiddleCenter;
                messageLabel.Font = new Font("Segoe UI Semibold", 16F);
                messageLabel.Height = 30;
                messageLabel.ForeColor = Color.Black;
                mainPanel.Controls.Add(messageLabel);
            }
        }
    }
}
