using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.StudentSide
{
    public partial class problems : Dashboard
    {
        public int problemcount;
        public int labid;
        ProblemApi ProblemApi = new ProblemApi();
        List<ProblemModel> problemList;
        public problems(int problemsCount , int reallabid )
        {
            formName.Text = "Problems";
            problemcount = problemsCount;
            labid = reallabid;
            InitializeComponent();
        }

        private async void problems_Load(object sender, EventArgs e)
        {
           
            //problemList = await ProblemApi.getAllproblemData(labid);
            showProblemData();

        }
        private void showProblemData()
        {
            int count = 1;
            foreach (var item in problemList)
            {
               
                Panel outerPanel = new Panel();
                outerPanel.Width = 1300;
                outerPanel.Height = 100;
                outerPanel.Margin = new Padding(20, 0, 20, 20);
                outerPanel.BorderStyle = BorderStyle.FixedSingle;



                TableLayoutPanel cardPanel = new TableLayoutPanel();
                cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = 1300;
                cardPanel.Height = 100;
                cardPanel.Margin = new Padding(20, 10, 20, 10);
                cardPanel.BackColor = Color.Lavender;
                cardPanel.AutoScroll = true;

                cardPanel.ColumnCount = 2;

                Label titleLabel = new Label();
                titleLabel.Margin = new Padding(20, 10, 20, 10);
                titleLabel.Text = count +".  "+ item.problem_name;
                titleLabel.TextAlign = ContentAlignment.MiddleLeft; // Align text to the left
                titleLabel.Font = new Font("Segoe UI Semibold", 12F);
                titleLabel.Height = 30;
                titleLabel.Width = 400;
                titleLabel.Top = 15;
                count = count + 1;
               

                Panel buttonPanel = new Panel();
                buttonPanel.Height = 70;
                buttonPanel.Dock = DockStyle.Right; // Position the panel on the right
                buttonPanel.Margin = new Padding(0, 0, 20, 0); // Adjust margin for spacing

                Button enrollButton = new Button();
                enrollButton.Text = "Solve";
                enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                enrollButton.Height = 60;
                enrollButton.Width = 200;
                enrollButton.Top = 15;
                enrollButton.Padding = new Padding(5, 5, 5, 5); // Adjust padding
                enrollButton.Font = new Font("Segoe UI Semibold", 12F);
                enrollButton.BackColor = Color.DarkSlateBlue;
                enrollButton.ForeColor = Color.White;
                enrollButton.Click += (sender, e) =>
                {
                    SolveProblem solveProblem = new SolveProblem(item.problem_id);
                    solveProblem.Show();
                };

                buttonPanel.Controls.Add(enrollButton);

                // Add the label and button to the same row
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // First column
                cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // Second column
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(buttonPanel);
                //cardPanel.SetColumnSpan(titleLabel, 1);

                outerPanel.Controls.Add(cardPanel);
                flowLayoutPanel1.Controls.Add(outerPanel);


            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
