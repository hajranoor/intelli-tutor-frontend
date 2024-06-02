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

namespace intelli_tutor_frontend.StudentSide
{
    internal class StudentNotification
    {
        NotificationApi notificationApi = new NotificationApi();
        List<Notification> notificationList = new List<Notification>();    
        public async void ShowStudentNotification(FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "Notifications";

            flowLayoutPanel.Controls.Clear();
            notificationList = await notificationApi.getAllStudentNotifications(1);

            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TableLayoutPanel mainPanel = new TableLayoutPanel();
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Width = flowLayoutPanel.Width - 10;
            mainPanel.Height = flowLayoutPanel.Height - 10;
            mainPanel.AutoScroll = true;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            flowLayoutPanel.Controls.Add(mainPanel);

            if (notificationList.Count == 0)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = mainPanel.Width;
                outerPanel.Height = mainPanel.Height;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                Label messageLabel = new Label();
                messageLabel.Text = "No Notifications";
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
                foreach (var notification in notificationList)
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
                    cardPanel.ColumnCount = 2;
                    cardPanel.Height = 100;
                    cardPanel.Margin = new Padding(20, 10, 20, 10);
                    cardPanel.BackColor = Color.Lavender;
                    //cardPanel.AutoScroll = true;
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75));
                    cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

                    

                    TableLayoutPanel notificationContent = new TableLayoutPanel();
                    notificationContent.RowCount = 2;
                    notificationContent.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;


                    Label notificationTitleLabel = new Label();
                    notificationTitleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    notificationTitleLabel.Margin = new Padding(20, 10, 20, 10);
                    notificationTitleLabel.Text = notification.title;
                    notificationTitleLabel.TextAlign = ContentAlignment.TopLeft; // Align text to the left
                    notificationTitleLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
                    notificationTitleLabel.Height = 30;
                    notificationTitleLabel.Top = 15;

                    NoCaretRichTextBox descriptionLabel = new NoCaretRichTextBox();
                    descriptionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    descriptionLabel.Margin = new Padding(20, 10, 20, 10);
                    descriptionLabel.Text = notification.description;
                    descriptionLabel.Font = new Font("Segoe UI", 12F);
                    descriptionLabel.Top = 15;
                    descriptionLabel.Width = 500;
                    descriptionLabel.Top = 15;
                    descriptionLabel.Multiline = true;
                    descriptionLabel.BackColor = Color.Lavender;
                    descriptionLabel.BorderStyle = BorderStyle.None;
                    notificationContent.Controls.Add(notificationTitleLabel, 0,0);
                    notificationContent.Controls.Add(descriptionLabel,0,1);
                    int preferredHeight = descriptionLabel.PreferredSize.Height + descriptionLabel.Padding.Vertical + notificationTitleLabel.PreferredSize.Height + notificationTitleLabel.Padding.Vertical;
                    //MessageBox.Show(notification.description + " : " + descriptionLabel.Text + " : " + descriptionLabel.PreferredSize.Height.ToString() + " : " + preferredHeight.ToString());
                    cardPanel.Height = preferredHeight+100;
                    outerPanel.Height = preferredHeight+100;

                    cardPanel.Controls.Add(notificationContent, 0, 0);
                    flowLayoutPanel.SizeChanged += (sender, e) =>
                    {

                        mainPanel.Size = new Size(flowLayoutPanel.Width - 10, flowLayoutPanel.Height - 10);
                        outerPanel.Size = new Size(mainPanel.Width - 12, outerPanel.Height);
                        flowLayoutPanel.Margin = new Padding(3, 3, 3, 3);
                        descriptionLabel.Height = descriptionLabel.Height + 10;
                        preferredHeight = descriptionLabel.PreferredSize.Height + descriptionLabel.Padding.Vertical + notificationTitleLabel.PreferredSize.Height + notificationTitleLabel.Padding.Vertical;
                        cardPanel.Height = preferredHeight + 100;
                        outerPanel.Height = preferredHeight + 100;
                    };
                    if (notification.status == "read")
                    {
                        Label notificationDate = new Label();
                        notificationDate.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        notificationDate.Dock = DockStyle.Fill;
                        notificationDate.Margin = new Padding(20, 10, 20, 10);
                        notificationDate.Text = notification.time_stamp.ToString("yyyy-MM-dd HH:mm:ss");
                        notificationDate.TextAlign = ContentAlignment.MiddleRight; // Align text to the left
                        notificationDate.Font = new Font("Segoe UI", 12F);
                        notificationDate.Height = 30;
                        notificationDate.Top = 15;

                        cardPanel.Controls.Add(notificationDate, 1, 0);

                    }
                    else
                    {
                        Panel buttonPanel = new Panel();
                        buttonPanel.Height = 70;
                        buttonPanel.Margin = new Padding(0, 0, 20, 0); // Adjust margin for spacing
                        buttonPanel.Dock = DockStyle.Right;
                        Button statusButton = new Button();
                        statusButton.Text = "Marked as Read";
                        statusButton.TextAlign = ContentAlignment.MiddleCenter;
                        statusButton.Height = 120;
                        statusButton.Width = 130;
                        statusButton.Top = 15;
                        statusButton.Padding = new Padding(5, 5, 5, 5); // Adjust padding
                        statusButton.Font = new Font("Segoe UI", 12F);
                        statusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                        statusButton.ForeColor = Color.Black;
                        statusButton.Click += async (sender, e) =>
                        {
                            bool result = await notificationApi.ChangeNotificationStatusToRead(notification);
                            if(result == false)
                            {
                                MessageBox.Show("Something went wrong try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            ShowStudentNotification(flowLayoutPanel, formName);
                        };

                        buttonPanel.Controls.Add(statusButton);
                        cardPanel.Controls.Add(buttonPanel, 1, 0);  
                    }
                    outerPanel.Controls.Add(cardPanel);
                    mainPanel.Controls.Add(outerPanel);


                }
            }
        }
    }
}
