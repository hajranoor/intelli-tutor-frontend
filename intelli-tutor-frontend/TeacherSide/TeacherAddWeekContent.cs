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
    internal class TeacherAddWeekContent
    {
        ContentApi contentApi = new ContentApi();
        ProblemApi problemApi = new ProblemApi();
        TestCasesApi testCasesApi = new TestCasesApi();

        public async void ShowTeacherAddWeekContent(WeekModel weekData, FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "Add New Content";

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
            Label contentNameLabel = new Label();
            contentNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentNameLabel.Margin = new Padding(20, 10, 20, 10);
            contentNameLabel.Text = "Content Name";
            contentNameLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentNameLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentNameLabel.Height = 30;
            contentNameLabel.Width = 400;
            contentNameLabel.Top = 15;

            mainPanel.Controls.Add(contentNameLabel, 0, 0);

            TextBox contentNameTextBox = new TextBox();
            contentNameTextBox.Margin = new Padding(20, 10, 20, 10);
            contentNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentNameTextBox.Font = new Font("Segoe UI Semibold", 12F);
            contentNameTextBox.Height = 30;
            contentNameTextBox.Width = 400;
            contentNameTextBox.Top = 15;

            mainPanel.Controls.Add(contentNameTextBox, 1, 0);
            //--------------------------------------
            //-----------------------------------------------
            //
            //contentTypeLabel
            //
            Label contentTypeLabel = new Label();
            contentTypeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentTypeLabel.Margin = new Padding(20, 10, 20, 10);
            contentTypeLabel.Text = "Content Type";
            contentTypeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentTypeLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentTypeLabel.Height = 30;
            contentTypeLabel.Width = 400;
            contentTypeLabel.Top = 15;

            mainPanel.Controls.Add(contentTypeLabel, 0, 1);
            //
            //contentTypeComboBox
            //
            ComboBox contentTypeComboBox = new ComboBox();
            contentTypeComboBox.Height = 30;
            contentTypeComboBox.Width = 400;
            contentTypeComboBox.Top = 15;
            contentTypeComboBox.Font = new Font("Segoe UI Semibold", 12F);
            contentTypeComboBox.Items.AddRange(new object[] {
            "Problem",
            "Assignment",
            "Quiz"});
            contentTypeComboBox.Margin = new Padding(20, 10, 20, 10);
            contentTypeComboBox.Dock = DockStyle.Fill;
            //this.roleComboBox.Margin = new System.Windows.Forms.Padding(4);
            contentTypeComboBox.Name = "contentTypeComboBox";
            contentTypeComboBox.SelectedIndex = 0;
            contentTypeComboBox.KeyPress += (sender, e) => e.Handled = true;


            mainPanel.Controls.Add(contentTypeComboBox, 1, 1);
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

            mainPanel.Controls.Add(descriptionLabel, 0, 2);

            RichTextBox descriptionTextBox = new RichTextBox();
            descriptionTextBox.Margin = new Padding(20, 10, 20, 10);
            descriptionTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            descriptionTextBox.Font = new Font("Segoe UI Semibold", 12F);
            descriptionTextBox.Height = 100;
            descriptionTextBox.Width = 400;
            descriptionTextBox.Top = 15;

            mainPanel.Controls.Add(descriptionTextBox, 1, 2);
            //----------------------------------------------
            //
            //regexLabel
            //
            Label regexLabel = new Label();
            regexLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            regexLabel.Margin = new Padding(20, 10, 20, 10);
            regexLabel.Text = "Regex";
            regexLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            regexLabel.Font = new Font("Segoe UI Semibold", 12F);
            regexLabel.Height = 30;
            regexLabel.Width = 400;
            regexLabel.Top = 15;

            mainPanel.Controls.Add(regexLabel, 0, 3);

            TextBox regexTextBox = new TextBox();
            regexTextBox.Margin = new Padding(20, 10, 20, 10);
            regexTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            regexTextBox.Font = new Font("Segoe UI Semibold", 12F);
            regexTextBox.Height = 30;
            regexTextBox.Width = 400;
            regexTextBox.Top = 15;

            mainPanel.Controls.Add(regexTextBox, 1, 3);
            //--------------------------------------

            //
            //starterCodeLabel
            //
            Label starterCodeLabel = new Label();
            starterCodeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            starterCodeLabel.Margin = new Padding(20, 10, 20, 10);
            starterCodeLabel.Text = "Starter Code";
            starterCodeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            starterCodeLabel.Font = new Font("Segoe UI Semibold", 12F);
            starterCodeLabel.Height = 30;
            starterCodeLabel.Width = 400;
            starterCodeLabel.Top = 15;

            mainPanel.Controls.Add(starterCodeLabel, 0, 4);

            RichTextBox starterCodeTextBox = new RichTextBox();
            starterCodeTextBox.Margin = new Padding(20, 10, 20, 10);
            starterCodeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            starterCodeTextBox.Font = new Font("Segoe UI Semibold", 12F);
            starterCodeTextBox.Height = 100;
            starterCodeTextBox.Width = 400;
            starterCodeTextBox.Top = 15;

            mainPanel.Controls.Add(starterCodeTextBox, 1, 4);
            //--------------------------------------

            //
            //rightCodeLabel
            //
            Label rightCodeLabel = new Label();
            rightCodeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            rightCodeLabel.Margin = new Padding(20, 10, 20, 10);
            rightCodeLabel.Text = "Right Code";
            rightCodeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            rightCodeLabel.Font = new Font("Segoe UI Semibold", 12F);
            rightCodeLabel.Height = 30;
            rightCodeLabel.Width = 400;
            rightCodeLabel.Top = 15;

            mainPanel.Controls.Add(rightCodeLabel, 0, 5);

            RichTextBox rightCodeTextBox = new RichTextBox();
            rightCodeTextBox.Margin = new Padding(20, 10, 20, 10);
            rightCodeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            rightCodeTextBox.Font = new Font("Segoe UI Semibold", 12F);
            rightCodeTextBox.Height = 100;
            rightCodeTextBox.Width = 400;
            rightCodeTextBox.Top = 15;

            mainPanel.Controls.Add(rightCodeTextBox, 1, 5);
            ////---------------------------------------------------------

            //
            //inputDataLabel
            //
            Label inputDataLabel = new Label();
            inputDataLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            inputDataLabel.Margin = new Padding(20, 10, 20, 10);
            inputDataLabel.Text = "Input Data";
            inputDataLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            inputDataLabel.Font = new Font("Segoe UI Semibold", 12F);
            inputDataLabel.Height = 30;
            inputDataLabel.Width = 400;
            inputDataLabel.Top = 15;

            mainPanel.Controls.Add(inputDataLabel, 0, 6);

            TextBox inputDataTextBox = new TextBox();
            inputDataTextBox.Margin = new Padding(20, 10, 20, 10);
            inputDataTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            inputDataTextBox.Font = new Font("Segoe UI Semibold", 12F);
            inputDataTextBox.Height = 30;
            inputDataTextBox.Width = 400;
            inputDataTextBox.Top = 15;

            mainPanel.Controls.Add(inputDataTextBox, 1, 6);
            ////---------------------------------------------------------
            ///
            //
            //outputDataLabel
            //
            Label outputDataLabel = new Label();
            outputDataLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            outputDataLabel.Margin = new Padding(20, 10, 20, 10);
            outputDataLabel.Text = "Output Data";
            outputDataLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            outputDataLabel.Font = new Font("Segoe UI Semibold", 12F);
            outputDataLabel.Height = 30;
            outputDataLabel.Width = 400;
            outputDataLabel.Top = 15;

            mainPanel.Controls.Add(outputDataLabel, 0, 7);

            TextBox outputDataTextBox = new TextBox();
            outputDataTextBox.Margin = new Padding(20, 10, 20, 10);
            outputDataTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            outputDataTextBox.Font = new Font("Segoe UI Semibold", 12F);
            outputDataTextBox.Height = 30;
            outputDataTextBox.Width = 400;
            outputDataTextBox.Top = 15;

            mainPanel.Controls.Add(outputDataTextBox, 1, 7);
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
                if (!string.IsNullOrEmpty(contentNameTextBox.Text) && !string.IsNullOrEmpty(regexTextBox.Text) && !string.IsNullOrEmpty(inputDataTextBox.Text) && !string.IsNullOrEmpty(outputDataTextBox.Text))
                {
                    ContentModel contentModel = new ContentModel();
                    contentModel.week_id = weekData.week_id;
                    contentModel.content_name = contentNameTextBox.Text;
                    contentModel.content_type = "Problem";
                    contentModel.sequence_number = 0;
                    int newContentId = await contentApi.insertContentData(contentModel);
                    if (newContentId != -1)
                    {
                        ProblemModel problemModel = new ProblemModel();
                        problemModel.content_id = newContentId;
                        problemModel.problem_name = contentNameTextBox.Text;
                        problemModel.description = descriptionTextBox.Text;
                        problemModel.regex = regexTextBox.Text;
                        problemModel.starter_code = starterCodeTextBox.Text;
                        problemModel.right_code = rightCodeTextBox.Text;
                        problemModel.category = "";
                        problemModel.complexity_level = "";

                        int newProblemId = await problemApi.insertProblemData(problemModel);

                        if (newProblemId != -1)
                        {
                            TestCaseModel testCaseModel = new TestCaseModel();
                            testCaseModel.problem_id = newProblemId;
                            string[] test = inputDataTextBox.Text.Split(',')
                                                       .Where(item => !string.IsNullOrWhiteSpace(item))
                                                       .ToArray();
                            testCaseModel.input_data = inputDataTextBox.Text.Split(',')
                                                       .Where(item => !string.IsNullOrWhiteSpace(item))
                                                       .ToArray();
                            testCaseModel.output_data = outputDataTextBox.Text.Split(',')
                                                       .Where(item => !string.IsNullOrWhiteSpace(item))
                                                       .ToArray();

                            int newTestCaseId = await testCasesApi.InsertTestCaseData(testCaseModel);
                            if (newTestCaseId != -1)
                            {
                                MessageBox.Show("Problem Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information );

                                contentNameTextBox.Text = "";
                                descriptionTextBox.Text = "";
                                regexTextBox.Text = "";
                                starterCodeTextBox.Text = "";
                                rightCodeTextBox.Text = "";
                                inputDataTextBox.Text = "";
                                outputDataTextBox.Text = "";
                            }
                            else
                            {
                                await contentApi.deleteContentById(newContentId);
                                await problemApi.deleteProblemById(newProblemId);
                                await testCasesApi.deleteTestCaseByTestCaseId(newTestCaseId);
                                MessageBox.Show("Something went wrong. try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            await contentApi.deleteContentById(newContentId);
                            await problemApi.deleteProblemById(newProblemId);
                            MessageBox.Show("Something went wrong. try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        await contentApi.deleteContentById(newContentId);
                        MessageBox.Show("Problem Content with this name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Fill the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            mainPanel.Controls.Add(addButton, 1, 8);
        }
    }
}
