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
    internal class SuperAdmin_coursecontent
    {
        List<MainWeekModel> mainWeekList = new List<MainWeekModel>(); 
        MainWeekApi mainWeekApi = new MainWeekApi();
        public async Task CourseContentSuperAdmin(MainCoursesModel myCourseData, FlowLayoutPanel flowLayoutPanel1, Label formName)
        {
            mainWeekList = await mainWeekApi.getAllMainWeekData(myCourseData.course_id);
            formName.Text = "Available Course Description";
           
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

            NoCaretRichTextBox CourseDescription = new NoCaretRichTextBox();
            CourseDescription.Text = myCourseData.course_description;
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
            descriptionPanel.Height = 500;
            descriptionPanel.Controls.Add(CourseDescription);
            descriptionPanel.BackColor = Color.Lavender;
            descriptionPanel.Padding = new Padding(10, 10, 10, 10);
            descriptionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

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
            int counter = 0;
            weekPanel.Margin = new Padding(10, 20, 10, 20);

            //int numberofweeks = myCourseData.number_of_weeks;
            //Console.WriteLine(numberofweeks);

            if(mainWeekList.Count == 0)
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
                foreach (var weekData in mainWeekList)
                {
                    counter += 1;
                    Panel outerPanel = new Panel();
                    outerPanel.Width = 180;
                    outerPanel.Height = 180;
                    outerPanel.Margin = new Padding(20, 20, 20, 20);
                    ////outerPanel.BackColor = Color.Lavender;
                    outerPanel.BorderStyle = BorderStyle.FixedSingle;

                    TableLayoutPanel cardPanel = new TableLayoutPanel();
                    //cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                    cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                    cardPanel.Width = 180;
                    cardPanel.Height = 180;
                    cardPanel.Margin = new Padding(20, 20, 20, 20);
                    cardPanel.BackColor = Color.DarkSlateBlue;
                    //cardPanel.AutoScroll = true;

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

                        flowLayoutPanel1.Controls.Clear();
                        SuperAdminCourseContent superAdminCourseContent = new SuperAdminCourseContent();
                        superAdminCourseContent.SuperAdminCourseContentShow(weekData, flowLayoutPanel1);
                        //NoUseLabsContent l = new NoUseLabsContent();
                        //l.LabContentShow(item.week_id, flowLayoutPanel1);

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
