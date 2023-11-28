using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
  
    public partial class CreateCourse : Form

    {
        EnrolledCourseApi enrolledCourseApi = new EnrolledCourseApi();
        WeekApi weekApi = new WeekApi();
        List<weekModel> weeksList;
        List<CourseAndEnrolledCourseDTO> enrolledCourseList;
        private Label labelCourseTitle;
        private TextBox textBoxCourseTitle;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelSession;
        private ComboBox comboBoxSession;
        private Button buttonCreate;
        private Button buttonCancel;
        public CreateCourse()
        {
            InitializeComponent();
            enrolledCourseList = new List<CourseAndEnrolledCourseDTO>
        {
            new CourseAndEnrolledCourseDTO
            {
                course_title = "Object Oriented Programming",

            },
             new CourseAndEnrolledCourseDTO
            {
                course_title = "Data Structures and Algorithm",

            },
        };
    }
        private void showData()
        {
            foreach (var item in enrolledCourseList)
            {
                Panel outerPanel = new Panel();
                outerPanel.Width = 250;
                outerPanel.Height = 120;
                outerPanel.Margin = new Padding(20, 20, 20, 20);
                outerPanel.BorderStyle= BorderStyle.FixedSingle;
                outerPanel.BackColor = Color.DarkSlateBlue;
                

                TableLayoutPanel cardPanel = new TableLayoutPanel();
                cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                cardPanel.Width = 200;
                cardPanel.Height = 150;
                cardPanel.Margin = new Padding(50, 20, 20, 20);
                cardPanel.BackColor = Color.DarkSlateBlue;
                outerPanel.Controls.Add(cardPanel);

                Label titleLabel = new Label();
                titleLabel.Text = item.course_title;
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font("Segoe UI Semibold", 12F);
                titleLabel.Height = 35;
                titleLabel.ForeColor = Color.White;
                cardPanel.Controls.Add(titleLabel, 0, 1);

                //PictureBox pictureBox = new PictureBox();
                //pictureBox.Width = 100; // Adjust the size as needed
                //pictureBox.Height = 100;
                //pictureBox.Visible = false; // Initially invisible
                //pictureBox.BackColor = Color.Transparent; // Make the background transparent
                //string imagePath = "C:\\Users\\Aqsa\\Desktop\\intelli-tutor-frontend\\intelli-tutor-frontend\\Resources\\check.png";
                //pictureBox.Load(imagePath);
                //cardPanel.Controls.Add(pictureBox, 0, 2);
                TableLayoutPanel currentCardPanel = null;
                outerPanel.Click += (sender, e) =>
                {
                    if (currentCardPanel != null)
                    {
                        currentCardPanel.Visible = false;
                    }

                    // Create a new cardPanel1
                    TableLayoutPanel cardPanel1 = new TableLayoutPanel();
                    cardPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                    cardPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                    cardPanel1.Width = 740;
                    cardPanel1.MaximumSize = new Size(750, 400);
                    cardPanel1.Height = 370;
                    cardPanel1.MinimumSize = new Size(500, 300);
                    cardPanel1.Margin = new Padding(30, 20, 20, 20);
                    cardPanel1.BackColor = Color.FromArgb(169, 169, 169); 
                    cardPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

                    Label labelCourseTitle = new Label();
                    labelCourseTitle.Text = "Offering Year";
                    labelCourseTitle.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                    labelCourseTitle.ForeColor = Color.White;
                    labelCourseTitle.Font = new Font("Segoe UI Semibold", 12);
                    labelCourseTitle.AutoSize = false;
                    labelCourseTitle.Margin = new Padding(10);
                    labelCourseTitle.Dock = DockStyle.Fill;

                    TextBox coursetitletextbox = new TextBox();
                    coursetitletextbox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                    coursetitletextbox.Dock = DockStyle.Fill;



                    Label SemesterLabel = new Label();
                    SemesterLabel.Text = "Semester";
                    SemesterLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                    SemesterLabel.ForeColor = Color.White;
                    SemesterLabel.Font = new Font("Segoe UI Semibold", 12);
                    SemesterLabel.AutoSize = false;
                    SemesterLabel.Margin = new Padding(10);
                    SemesterLabel.Dock = DockStyle.Fill;



                    ComboBox semestercombobox = new ComboBox();
                    semestercombobox.Items.Add("Fall");
                    semestercombobox.Items.Add("Summer");
                    semestercombobox.Items.Add("Spring");
                    semestercombobox.Height = 70;
                    semestercombobox.Dock = DockStyle.Fill;

          
                    TextBox CapacityTextBox = new TextBox();
                    CapacityTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                    Label CapacityLabel = new Label();
                    CapacityLabel.Text = "Capacity";
                    CapacityLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                    CapacityLabel.ForeColor = Color.White;
                    CapacityLabel.Font = new Font("Segoe UI Semibold", 12);
                    CapacityLabel.AutoSize = false;
                    CapacityLabel.Margin = new Padding(20);
                    CapacityLabel.Dock = DockStyle.Fill;

                    Label Desclabel = new Label();
                    Desclabel.Text = "Description";
                    Desclabel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                    Desclabel.ForeColor = Color.White;
                    Desclabel.Font = new Font("Segoe UI Semibold", 12);
                    Desclabel.AutoSize = false;
                    Desclabel.Margin = new Padding(10);
                    Desclabel.Dock = DockStyle.Fill;

                    TextBox DescTextBox = new TextBox();
                    DescTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

                    Button createInitButton = new Button();
                    createInitButton.Text = "Create";
                    createInitButton.BackColor = Color.DarkSlateBlue;
                    createInitButton.Height = 50;
                    createInitButton.Width = 100;

                    Button CancelButton = new Button();
                    CancelButton.Text = "Cacel";
                    CancelButton.BackColor = Color.DarkSlateBlue;
                    CancelButton.Height = 50;
                    CancelButton.Width = 100;

                    // Set the background color to DarkSlateBlue
                    createInitButton.BackColor = Color.DarkSlateBlue;

                    // Add the label and textbox to the cardPanel1
                    cardPanel1.Controls.Add(labelCourseTitle, 0, 0);
                    cardPanel1.Controls.Add(coursetitletextbox, 0, 1);
                    cardPanel1.Controls.Add(SemesterLabel, 0, 2);
                    cardPanel1.Controls.Add(semestercombobox, 0, 3);
                    cardPanel1.Controls.Add(CapacityLabel, 0, 4);
                    cardPanel1.Controls.Add(CapacityTextBox, 0, 5);
                    cardPanel1.Controls.Add(Desclabel, 0, 6);
                    cardPanel1.Controls.Add(DescTextBox, 0, 7);
                    cardPanel1.Controls.Add(createInitButton, 0, 8);
                    cardPanel1.Controls.Add(CancelButton, 2, 8);
                    //cardPanel1.Controls.Add(textBoxCourseTitle, 1, 0); // Column 1, Row 0
                    // Add the new cardPanel1 to the flowLayoutPanel1
                    flowLayoutPanel1.Controls.Add(cardPanel1);
                    // Configure TextBox

                    // Set it as the currently displayed cardPanel1
                    currentCardPanel = cardPanel1;
                    SetPanelRegion(cardPanel1);

                };

                SetPanelRegion(outerPanel);
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(outerPanel);
            }
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {
            showData();
            SetPanelRegion(panel9);
            SetPanelRegion(panel10);
            SetPanelRegion(panel11);
            SetPanelRegion(panel12);
            SetPanelRegion(panel13);
            SetPanelRegion(panel14);
        }
        private void SetPanelRegion(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(panel.Width - (radius * 2), 0, radius * 2, radius * 2, -90, 90);
            path.AddArc(panel.Width - (radius * 2), panel.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(0, panel.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void CreateCourse_Resize(object sender, EventArgs e)
        {
           
          
        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void panel3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel4_Click(object sender, EventArgs e)
        {
          
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            panel14.BackColor= Color.White;
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel13.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor = Color.FromArgb(192, 192, 255);
            TeacherDashboard dashboard = new TeacherDashboard();
            dashboard.Show();
            this.Close();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel10.BackColor= Color.White;
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel13.BackColor = Color.FromArgb(192, 192, 255);
            panel14.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            panel13.BackColor= Color.White;
            panel14.BackColor = Color.FromArgb(192, 192, 255);
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor = Color.FromArgb(192, 192, 255);
            panel12.BackColor = Color.FromArgb(192, 192, 255); 
            Available_Courses available_Courses = new Available_Courses();
            available_Courses.Show();
            this.Close ();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor=Color.FromArgb(192, 192, 255);
            panel11.BackColor= Color.FromArgb(192, 192, 255);
            panel12.BackColor= Color.White;
            panel13.BackColor= Color.FromArgb(192, 192, 255);
            panel14.BackColor= Color.FromArgb(192, 192, 255);
            My_Courses my_Courses= new My_Courses();
            my_Courses.Show ();
            this.Close ();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panel9.BackColor= Color.FromArgb(192, 192, 255);
            panel10.BackColor= Color.FromArgb(192, 192, 255);
            panel11.BackColor= Color.White;
            panel12.BackColor= Color.FromArgb(192, 192, 255);
            panel13.BackColor= Color.FromArgb(192, 192, 255);
            panel14.BackColor= Color.FromArgb(192, 192, 255);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel9.BackColor= Color.White;
            panel10.BackColor = Color.FromArgb(192, 192, 255);
            panel11.BackColor= Color.FromArgb(192, 192, 255);
            panel12.BackColor= Color.FromArgb(192, 192, 255);
            panel13.BackColor= Color.FromArgb(192, 192, 255);
            panel14.BackColor= Color.FromArgb(192, 192, 255);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
