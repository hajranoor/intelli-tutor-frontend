using FontAwesome.Sharp;
using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using intelli_tutor_frontend.StudentSide;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    internal class ViewEnrollments
    {
        CurrentUser currentLoginUser = CurrentUser.Instance;

        List<ViewEnrollmentsDTO> enrollmentList;

        NotificationApi notificationApi = new NotificationApi();

        ViewEnrollmentsApi Viewenrollments = new ViewEnrollmentsApi();

        public ViewEnrollments() { }

        public async Task ViewEnrollmentsAsync(FlowLayoutPanel flowLayoutPanel, Label formName,  MainCourseAndCourseOfferingDTO myCourse)
        {
            flowLayoutPanel.Controls.Clear();
            formName.Text = "Enrollments";
            enrollmentList = await Viewenrollments.getAllEnrollments(currentLoginUser.TeacherModel.teacher_id,myCourse.course_offering_id);

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel.Width - 10;
            mainPanel.Height = flowLayoutPanel.Height - 10;
            mainPanel.AutoScroll = true;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            flowLayoutPanel.Controls.Add(mainPanel);
            if (enrollmentList.Count == 0)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = mainPanel.Width;
                outerPanel.Height = mainPanel.Height;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                Label messageLabel = new Label();
                messageLabel.Text = "No current Enrollment Requests!";
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

                contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                contentCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                flowLayoutPanel.SizeChanged += (sender, e) =>
                {

                    mainPanel.Size = new Size(flowLayoutPanel.Width - 10, flowLayoutPanel.Height - 10);
                    contentOuterPanel.Size = new Size(mainPanel.Width - 12, contentOuterPanel.Height);
                    flowLayoutPanel.Margin = new Padding(3, 3, 3, 3);
                };


                Label contentTypeLabel = new Label();
                contentTypeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                contentTypeLabel.Margin = new Padding(20, 10, 20, 10);
                contentTypeLabel.Text = "RegNo# ";
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
                contentSequenceLabel.Text = "Section";
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
                foreach (var item in enrollmentList)
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
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));

                    flowLayoutPanel.SizeChanged += (sender, e) =>
                    {

                        mainPanel.Size = new Size(flowLayoutPanel.Width - 10, flowLayoutPanel.Height - 10);
                        outerPanel.Size = new Size(mainPanel.Width - 12, outerPanel.Height);
                        flowLayoutPanel.Margin = new Padding(3, 3, 3, 3);
                    };

                    Label typeLabel = new Label();
                    typeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    typeLabel.Margin = new Padding(20, 10, 20, 10);
                    typeLabel.Text = item.registration_no;
                    typeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                    typeLabel.Font = new Font("Segoe UI Semibold", 12F);
                    typeLabel.Height = 30;
                    typeLabel.Top = 15;

                    cardPanel.Controls.Add(typeLabel, 0, 0);

                    Label nameLabel = new Label();
                    nameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    nameLabel.Margin = new Padding(20, 10, 20, 10);
                    nameLabel.Text = item.username;
                    nameLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                    nameLabel.Font = new Font("Segoe UI Semibold", 12F);
                    nameLabel.Height = 30;
                    nameLabel.Top = 15;

                    cardPanel.Controls.Add(nameLabel, 1, 0);

                    Label sequenceLabel = new Label();
                    sequenceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    sequenceLabel.Margin = new Padding(20, 10, 20, 10);
                    sequenceLabel.Text = item.section_student;
                    sequenceLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                    sequenceLabel.Font = new Font("Segoe UI Semibold", 12F);
                    sequenceLabel.Height = 30;
                    sequenceLabel.Top = 15;
                    cardPanel.Controls.Add(sequenceLabel, 2, 0);


                    TableLayoutPanel buttonPanel = new TableLayoutPanel();
                    buttonPanel.Height = 80;
                    buttonPanel.Margin = new Padding(0, 0, 0, 0); // Adjust margin for spacing
                    buttonPanel.RowCount = 1;
                    buttonPanel.ColumnCount = 2;
                    buttonPanel.Width = 400;
                    buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                    Button enrollButton = new Button();
                    enrollButton.Text = "Approved";
                    enrollButton.Anchor = AnchorStyles.Left;
                    enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                    enrollButton.Height = 70;
                    enrollButton.Width = 150;
                    enrollButton.Top = 15;
                    enrollButton.Padding = new Padding(5, 5, 5, 5); // Adjust padding
                    enrollButton.Font = new Font("Segoe UI Semibold", 12F);
                    enrollButton.BackColor = Color.DarkSlateBlue;
                    enrollButton.ForeColor = Color.White;
                    enrollButton.Click += async (sender, e) =>
                    {
                        Console.WriteLine("student ID");
                        Console.WriteLine(item.student_id);
                        ViewEnrollmentsApi N = new ViewEnrollmentsApi();
                        var result = N.ChangeEnrollmentStatus(item.student_id,  item.course_offering_id,item.teacher_id);
                        if (result != null)
                        {
                            MessageBox.Show("Enrollment has been successfully approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await ViewEnrollmentsAsync(flowLayoutPanel, formName, myCourse);
                            
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    };

                    Button disApproveButton = new Button();
                    disApproveButton.Text = "Disapprove";
                    disApproveButton.Anchor = AnchorStyles.Right;
                    disApproveButton.TextAlign = ContentAlignment.MiddleCenter;
                    disApproveButton.Height = 70;
                    disApproveButton.Width = 150;
                    disApproveButton.Top = 15;
                    disApproveButton.Padding = new Padding(5, 5, 5, 5); // Adjust padding
                    disApproveButton.Font = new Font("Segoe UI Semibold", 12F);
                    disApproveButton.BackColor = Color.DarkSlateBlue;
                    disApproveButton.ForeColor = Color.White;
                    disApproveButton.Click += async (sender, e) =>
                    {
                        EnrolledCourseApi enrolledCourseApi = new EnrolledCourseApi();
                        if (await enrolledCourseApi.deleteEnrollment(item.enrollment_id))
                        {
                            CurrentUser currentLoginUser = CurrentUser.Instance;
                            Notification notification = new Notification();
                            notification.sender_id = currentLoginUser.User.user_id;
                            notification.receiver_id = item.user_id;
                            notification.status = "unread";
                            notification.title = "Disapproval of Enrolment Request";
                            notification.description = "Your enrollment request in " + item.course_code + " " + myCourse.course_name + " has been disapproved by " + currentLoginUser.User.username;
                            notification.time_stamp = DateTime.UtcNow;
                            if(await notificationApi.insertNotification(notification))
                            {
                                MessageBox.Show("Disapproved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await ViewEnrollmentsAsync(flowLayoutPanel, formName, myCourse);

                            }
                            else
                            {
                                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                    buttonPanel.Controls.Add(enrollButton, 0, 0);
                    buttonPanel.Controls.Add(disApproveButton, 1, 0);

                    cardPanel.Controls.Add(buttonPanel, 3,0);
                    count++;
                    outerPanel.Controls.Add(cardPanel);
                    mainPanel.Controls.Add(outerPanel);
                }
            }






        }


    }
}
