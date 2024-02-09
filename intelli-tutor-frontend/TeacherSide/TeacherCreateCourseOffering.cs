using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace intelli_tutor_frontend.TeacherSide
{
    internal class TeacherCreateCourseOffering
    {
        CourseOfferingApi courseOfferingApi = new CourseOfferingApi();

        MainContentApi mainContentApi = new MainContentApi();
        List<MainContentModel> mainContentList = new List<MainContentModel>();  

        ContentApi contentApi = new ContentApi();

        MainWeekApi mainWeekApi = new MainWeekApi();  
        List<MainWeekModel> mainWeekList = new List<MainWeekModel>();

        WeekApi weekApi = new WeekApi();    

        MainProblemApi mainProblemApi = new MainProblemApi();
        List<MainProblemsModel> mainProblemsList = new List<MainProblemsModel>();

        ProblemApi problemApi = new ProblemApi();   

        MainTestCaseApi mainTestCaseApi = new MainTestCaseApi();
        List<MainTestCaseModel> mainTestCaseList = new List<MainTestCaseModel>();

        TestCasesApi TestCasesApi = new TestCasesApi(); 

        RadioButton defaultRadioButton = new RadioButton();
        RadioButton newRadioButton = new RadioButton();
        public void CourseOfferingShow(MainCoursesModel selectedCourse, FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "Course Offering";

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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

            Label offeringYearLabel = new Label();
            offeringYearLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            offeringYearLabel.Margin = new Padding(20, 10, 20, 10);
            offeringYearLabel.Text = "Offering Year";
            offeringYearLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            offeringYearLabel.Font = new Font("Segoe UI Semibold", 12F);
            offeringYearLabel.Height = 30;
            offeringYearLabel.Width = 400;
            offeringYearLabel.Top = 15;

            mainPanel.Controls.Add(offeringYearLabel, 0,0);

            TextBox offeringYearTextBox = new TextBox();
            offeringYearTextBox.Margin = new Padding(20, 10, 20, 10);
            offeringYearTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            offeringYearTextBox.Font = new Font("Segoe UI Semibold", 12F);
            offeringYearTextBox.Height = 30;
            offeringYearTextBox.Width = 400;
            offeringYearTextBox.Top = 15;

            mainPanel.Controls.Add(offeringYearTextBox, 1, 0);
            //---------------------------------------------------------

            Label semesterLabel = new Label();
            semesterLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            semesterLabel.Margin = new Padding(20, 10, 20, 10);
            semesterLabel.Text = "Semester";
            semesterLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            semesterLabel .Font = new Font("Segoe UI Semibold", 12F);
            semesterLabel.Height = 30;
            semesterLabel.Width = 400;
            semesterLabel.Top = 15;

            mainPanel.Controls.Add(semesterLabel, 0, 1);

            ComboBox semesterComboBox = new ComboBox();
            semesterComboBox.Items.Add("Fall");
            semesterComboBox.Items.Add("Summer");
            semesterComboBox.Items.Add("Spring");
            semesterComboBox.Font = new Font("Segoe UI Semibold", 12F);
            semesterComboBox.Height = 30;
            semesterComboBox.Width = 400;
            semesterComboBox.Top = 15; semesterComboBox.Margin = new Padding(20, 10, 20, 10);
            semesterComboBox.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(semesterComboBox, 1, 1);
            //---------------------------------------------------------

            Label capacityLabel = new Label();
            capacityLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            capacityLabel.Margin = new Padding(20, 10, 20, 10);
            capacityLabel.Text = "Capacity";
            capacityLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            capacityLabel.Font = new Font("Segoe UI Semibold", 12F);
            capacityLabel.Height = 30;
            capacityLabel.Width = 400;
            capacityLabel.Top = 15;

            mainPanel.Controls.Add(capacityLabel, 0, 2);

            TextBox capacityTextBox = new TextBox();
            capacityTextBox.Margin = new Padding(20, 10, 20, 10);
            capacityTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            capacityTextBox.Font = new Font("Segoe UI Semibold", 12F);
            capacityTextBox.Height = 30;
            capacityTextBox.Width = 400;
            capacityTextBox.Top = 15;

            mainPanel.Controls.Add(capacityTextBox, 1, 2);
            //---------------------------------------------------------

            Label descriptionLabel = new Label();
            descriptionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            descriptionLabel.Margin = new Padding(20, 10, 20, 10);
            descriptionLabel.Text = "Description";
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            descriptionLabel.Font = new Font("Segoe UI Semibold", 12F);
            descriptionLabel.Height = 30;
            descriptionLabel.Width = 400;
            descriptionLabel.Top = 15;

            mainPanel.Controls.Add(descriptionLabel, 0, 3);

            RichTextBox descriptionTextBox = new RichTextBox();
            descriptionTextBox.Margin = new Padding(20, 10, 20, 10);
            descriptionTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            descriptionTextBox.Font = new Font("Segoe UI Semibold", 12F);
            descriptionTextBox.Height = 100;
            descriptionTextBox.Width = 400;
            descriptionTextBox.Top = 15;
            mainPanel.Controls.Add(descriptionTextBox, 1, 3);
            //---------------------------------------------------------

            Label planLabel = new Label();
            planLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            planLabel.Margin = new Padding(20, 10, 20, 10);
            planLabel.Text = "Course Plan";
            planLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            planLabel.Font = new Font("Segoe UI Semibold", 12F);
            planLabel.Height = 30;
            planLabel.Width = 400;
            planLabel.Top = 15;

            mainPanel.Controls.Add(planLabel, 0, 4);

            
            defaultRadioButton = new RadioButton();
            defaultRadioButton.Text = "Default";
            defaultRadioButton.Height = 30;
            defaultRadioButton.Font = new Font("Segoe UI Semibold", 12F);
            //defaultRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            
            newRadioButton.Text = "New";
            newRadioButton.Height = 30; 
            newRadioButton.Font = new Font("Segoe UI Semibold", 12F);
            //newRadioButton.CheckedChanged += RadioButton_CheckedChanged;

            mainPanel.Controls.Add(defaultRadioButton, 1, 4);
            mainPanel.Controls.Add(newRadioButton, 1, 4);
            //---------------------------------------------------------

            Button createButton = new Button();

            createButton.Text = "Create";
            createButton.Dock = DockStyle.Fill;
            createButton.Height = 65;
            //createButton.Dock = DockStyle.Bottom;
            createButton.Margin = new Padding(150, 300, 150, 20);
            createButton.Width = 70;
            createButton.TextAlign = ContentAlignment.MiddleCenter;
            createButton.Padding = new Padding(5, 15, 5, 15);
            createButton.Font = new Font("Segoe UI Semibold", 12F);
            createButton.BackColor = Color.DarkSlateBlue;
            createButton.ForeColor = Color.White;
            createButton.Click += async (sender, e) =>
            {
                if (!string.IsNullOrEmpty(offeringYearTextBox.Text) && !string.IsNullOrEmpty(semesterComboBox.Text) && !string.IsNullOrEmpty(capacityTextBox.Text) && !string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    if (defaultRadioButton.Checked || newRadioButton.Checked)
                    {
                        if (int.TryParse(offeringYearTextBox.Text, out int offeringYear) && offeringYear > 0)
                        {
                            if (int.TryParse(capacityTextBox.Text, out int capacity) && capacity > 0)
                            {
                                CourseOfferingModel courseOfferingModel = new CourseOfferingModel();
                                courseOfferingModel.description = descriptionTextBox.Text;  
                                courseOfferingModel.offering_year = offeringYear;
                                courseOfferingModel.capacity = capacity;
                                courseOfferingModel.course_id = selectedCourse.course_id;
                                courseOfferingModel.semester = semesterComboBox.Text;
                                courseOfferingModel.teacher_id = 1;

                                int courseOfferingId = await courseOfferingApi.InsertCourseOfferingData(courseOfferingModel);
                                if(defaultRadioButton.Checked == true)
                                {
                                    copyCourseData(courseOfferingId);
                                }
                                MessageBox.Show("Course is created: ");
                                flowLayoutPanel.Controls.Clear();
                                teacherAvailableCourses teacherAvailableCourses = new teacherAvailableCourses(); ;
                                await teacherAvailableCourses.availableCoursesAsync(flowLayoutPanel, formName);
                            }
                            else
                            {

                                MessageBox.Show("Please enter a valid positive integer for capacity.");
                            }
                        }
                        else
                        {

                            MessageBox.Show("Please enter a valid positive integer for offering year e.g 2020.");
                        }
                        
                    }
                    else
                    {
                        // No option is selected
                        MessageBox.Show("Please select an option.");
                    }
                }
                else
                {
                    MessageBox.Show("Select/fill all options");
                }
                //DialogResult result = MessageBox.Show("Do you want to enroll in this course " + item.course_title + " ?", "Enrollment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result == DialogResult.Yes)
                //{
                //    enrolledCourses enrolledCourses = new enrolledCourses();
                //    enrolledCourses.courseId = item.course_id;
                //    enrolledCourses.studentId = 1;
                //    enrolledCourses.grade = "";
                //    string data = await enrolledCourseApi.makeEnrollmentInCourse(enrolledCourses);

                    //    MessageBox.Show(data);
                    //}
                    //else
                    //{
                    //}
            };

            mainPanel.Controls.Add(createButton, 1, 5);
            //---------------------------------------------------------

        }

        private void RadioButton_CheckedChanged()
        {
            if (defaultRadioButton.Checked || newRadioButton.Checked)
            {
               
            }
            else
            {
                // No option is selected
                MessageBox.Show("Please select an option.");
            }
        }
        private async void copyCourseData(int courseOfferingId)
        {
            mainWeekList = await mainWeekApi.getAllMainWeekData(1);
            foreach (var mainWeekItem in mainWeekList)
            {
                int insertedWeekId = await weekApi.InsertWeekData(new WeekModel
                {
                    week_name = mainWeekItem.week_name,
                    course_offering_id = courseOfferingId,
                    description = mainWeekItem.description,
                });

                mainContentList = await mainContentApi.getMainContentByWeekId(mainWeekItem.week_id);
                foreach (var mainContentItem in mainContentList)
                {
                    int insertedContentId = await contentApi.insertContentData(new ContentModel
                    {
                        content_name = mainContentItem.content_name,
                        content_type = mainContentItem.content_type,
                        sequence_number = mainContentItem.sequence_number,
                        week_id = insertedWeekId,
                    });

                    mainProblemsList = await mainProblemApi.getAllMainProblemData(mainContentItem.content_id);
                    foreach (var mainProblemItem in mainProblemsList)
                    {
                        int insertedProblemId = await problemApi.insertProblemData(new ProblemModel
                        {
                            content_id = insertedContentId,
                            problem_name = mainProblemItem.problem_name,
                            description = mainProblemItem.description,
                            regex = mainProblemItem.regex,
                            starter_code = mainProblemItem.starter_code,
                            right_code = mainProblemItem.right_code,
                            complexity_level = mainProblemItem.complexity_level,
                            category = mainProblemItem.category,

                        });

                        mainTestCaseList = await mainTestCaseApi.getAllMainTestCaseData(mainProblemItem.problem_id);
                        foreach (var mainTestCaseItem in mainTestCaseList)
                        {
                            int insertedTestCaseId = await TestCasesApi.InsertTestCaseData(new TestCaseModel
                            {
                                problem_id = insertedProblemId,
                                input_data = mainTestCaseItem.input_data,
                                output_data = mainTestCaseItem.output_data, 
                            });
                        }
                    }

                    //assignment
                    //quiz

                }

            }
        }
    }
}
