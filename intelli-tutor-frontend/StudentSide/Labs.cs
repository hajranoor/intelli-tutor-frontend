using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.StudentSide
{
    public partial class Labs : Dashboard

    {
        LabApi labApi = new LabApi();
        List<LabModel> labList;
        public Labs()
        {
            formName.Text = "Labs";
            InitializeComponent();
           
        }

        private async void labs_Load(object sender, EventArgs e)
        {
            int id = 8;
            labList = await labApi.getAlllabData(id);
            showLabData();

        }
        private void showLabData()
        {
            foreach (var item in labList)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = 480;
                outerPanel.Height = 400;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                //outerPanel.BackColor = Color.Lavender;
                outerPanel.BorderStyle = BorderStyle.FixedSingle;

                TableLayoutPanel cardPanel = new TableLayoutPanel();
                cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = 480;
                cardPanel.Height = 400;
                cardPanel.Margin = new Padding(20, 20, 20, 20);
                cardPanel.BackColor = Color.Lavender;
                cardPanel.AutoScroll = true;

                PictureBox pictureBox = new PictureBox();
                //pictureBox.Image = FontAwesome.Sharp.IconChar.Book.ToBitmap(color: Color.Black, size: 40, rotation: 0, flip: FlipOrientation.Normal);
                pictureBox.Load("C:\\Users\\Laiba\\Documents\\GitHub\\intelli-tutor-frontend\\intelli-tutor-frontend\\labimage.png");

                pictureBox.Width = 200;
                pictureBox.Height = 200;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                cardPanel.Controls.Add(pictureBox, 0, 0);

                Label titleLabel = new Label();
                titleLabel.Text = "lab"+ item.labid.ToString();
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 16F);
                titleLabel.Height = 60;
                cardPanel.Controls.Add(titleLabel, 0, 1);


                Panel buttonPanel = new Panel();
                buttonPanel.Height = 70;
                buttonPanel.Width = 130;
                //buttonPanel.BackColor = Color.DarkSlateBlue;
                buttonPanel.Dock = DockStyle.Bottom;
                buttonPanel.Margin = new Padding(150, 0, 150, 20);

                Button enrollButton = new Button();

                enrollButton.Text = "Problems";
                enrollButton.Dock = DockStyle.Fill;
                enrollButton.Width = 130;
                enrollButton.TextAlign = ContentAlignment.MiddleCenter;
                enrollButton.Padding = new Padding(5, 15, 5, 15);
                enrollButton.Font = new Font("Segoe UI Semibold", 12F);
                enrollButton.BackColor = Color.DarkSlateBlue;
                enrollButton.ForeColor = Color.White;
                enrollButton.Click += (sender, e) =>
                {
                    int problemsCount = item.problemcount;
                    int realLabid = item.labid;
                    this.Hide();
                    problems p = new problems(problemsCount, realLabid);
                    p.Show();
                  

                };

                buttonPanel.Controls.Add(enrollButton);

                cardPanel.Controls.Add(buttonPanel, 0, 3);
                outerPanel.Controls.Add(cardPanel);

                flowLayoutPanel1.Controls.Add(outerPanel);

            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
