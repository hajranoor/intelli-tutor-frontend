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
    internal class TeacherCourseContent
    {
        List<MainContentModel> mainContentModels = new List<MainContentModel>();
        MainContentApi mainContentApi = new MainContentApi();   
        public async void CourseContentShow(int week_id, FlowLayoutPanel flowLayoutPanel)
        {
            mainContentModels = await mainContentApi.getMainContentByWeekId(week_id);
            //MessageBox.Show(mainContentModels.Count.ToString());
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

            Label contentTypeLabel = new Label();
            contentTypeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentTypeLabel.Margin = new Padding(20, 10, 20, 10);
            contentTypeLabel.Text = "Course Type";
            contentTypeLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentTypeLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentTypeLabel.Height = 30;
            //contentTypeLabel.Width = 400;
            contentTypeLabel.Top = 15;

            mainPanel.Controls.Add(contentTypeLabel, 0, 0);

            Label contentNameLabel = new Label();
            contentNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentNameLabel.Margin = new Padding(20, 10, 20, 10);
            contentNameLabel.Text = "Name";
            contentNameLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentNameLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentNameLabel.Height = 30;
            //contentNameLabel.Width = 400;
            contentNameLabel.Top = 15;

            mainPanel.Controls.Add(contentNameLabel, 1, 0);

            Label contentSequenceLabel = new Label();
            contentSequenceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            contentSequenceLabel.Margin = new Padding(20, 10, 20, 10);
            contentSequenceLabel.Text = "Sequence";
            contentSequenceLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
            contentSequenceLabel.Font = new Font("Segoe UI Semibold", 12F);
            contentSequenceLabel.Height = 30;
            //contentSequenceLabel.Width = 400;
            contentSequenceLabel.Top = 15;

            mainPanel.Controls.Add(contentSequenceLabel, 2, 0);
            //---------------------------------------------------------------------------------------

            int row = 1;
            foreach (var item in mainContentModels)
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
                Label contentTypeLabel1 = new Label();
                contentTypeLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                contentTypeLabel1.Margin = new Padding(20, 10, 20, 10);
                contentTypeLabel1.Text = item.content_type;
                contentTypeLabel1.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                contentTypeLabel1.Font = new Font("Segoe UI Semibold", 12F);
                contentTypeLabel1.Height = 30;
                //contentTypeLabel1.Width = 400;
                contentTypeLabel1.Top = 15;

                mainPanel.Controls.Add(contentTypeLabel1, 0, row);

                Label contentNameLabel1 = new Label();
                contentNameLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                contentNameLabel1.Margin = new Padding(20, 10, 20, 10);
                contentNameLabel1.Text = item.content_name;
                contentNameLabel1.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                contentNameLabel1.Font = new Font("Segoe UI Semibold", 12F);
                contentNameLabel1.Height = 30;
                //contentNameLabel1.Width = 400;
                contentNameLabel1.Top = 15;

                mainPanel.Controls.Add(contentNameLabel1, 1, row);

                Label contentSequenceLabel1 = new Label();
                contentSequenceLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                contentSequenceLabel1.Margin = new Padding(20, 10, 20, 10);
                contentSequenceLabel1.Text = item.sequence_number.ToString();
                contentSequenceLabel1.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                contentSequenceLabel1.Font = new Font("Segoe UI Semibold", 12F);
                contentSequenceLabel1.Height = 30;
                //contentSequenceLabel1.Width = 400;
                contentSequenceLabel1.Top = 15;

                mainPanel.Controls.Add(contentSequenceLabel1, 2, row);

                row++;
            }
        }
    }
}
