using FontAwesome.Sharp;
using intelli_tutor_frontend.Model;
using intelli_tutor_frontend.StudentSide;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    public partial class TeacherSideDashbaord : Form
    {
        public static string actualMenuStrip;
        //NewMenuStrip newMenuStrip = new NewMenuStrip();
        public static List<ToolStripMenuItem> originalMenuItems = new List<ToolStripMenuItem>();
        public static ToolStripItem lastClickedItem;

        public TeacherSideDashbaord()
        {
            InitializeComponent();
            loadIcons();
            lastClickedItem = this.dashboardToolStripMenuItem;
            originalMenuItems.Clear();
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                originalMenuItems.Add(item);
            }
        }

        
        public void loadIcons()
        {
            this.notificationIcon.Image = IconChar.Bell.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);
            this.accountIcon.Image = IconChar.Person.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);


        }

        private void TeacherSideDashbaord_Load(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            DashboardClass dashboardClass = new DashboardClass();
            dashboardClass.ShowDashbooard(flowLayoutPanel2, formName);
            //dashboardToolStripMenuItem.Enabled = true;
            //List<string> enrolledCourseNames = new List<string>();

            //// Add course names to the list
            //enrolledCourseNames.Add("Course 1");
            //enrolledCourseNames.Add("Course 2");
            //enrolledCourseNames.Add("Course 3");
            //enrolledCourseNames.Add("Course 4");

            //List<int> attendancePercentages = new List<int> { 95, 80, 60, 40 };
            //int numberOfCoursesEnrolled = enrolledCourseNames.Count;

            //showdata(numberOfCoursesEnrolled, enrolledCourseNames, attendancePercentages);
        }
        private void availableCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            teacherAvailableCourses teacherAvailableCourses = new teacherAvailableCourses();
            teacherAvailableCourses.availableCoursesAsync(flowLayoutPanel2, formName);
        }

        public void myCourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            flowLayoutPanel2.Controls.Clear();
            TeacherMyCourses teacherMyCourses = new TeacherMyCourses();
            teacherMyCourses.ShowMyCoursesAsync(flowLayoutPanel2, formName, menuStrip1);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if(lastClickedItem != null)
            {
                lastClickedItem.ForeColor = Color.Black; 
                lastClickedItem.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));    
            }

            ToolStripItem clickedItem = e.ClickedItem;
            clickedItem.ForeColor = Color.White;            
            clickedItem.BackColor = Color.DarkSlateBlue;   

            lastClickedItem = clickedItem;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            DashboardClass dashboardClass = new DashboardClass();
            dashboardClass.ShowDashbooard(flowLayoutPanel2, formName);
            //this.Hide();
            //TeacherSideDashbaord teacherSideDashbaord = new TeacherSideDashbaord();
            //teacherSideDashbaord.Show();
        }
        private bool courseNamesVisible = false; // Initialize as hidden

        private void showdata(int numberOfCoursesEnrolled, List<string> enrolledCourseNames, List<int> attendancePercentages)
        {
            Panel outerPanel = new Panel();
            outerPanel.Width = 400;
            outerPanel.Height = 300;
            outerPanel.Margin = new Padding(50, 20, 20, 20);

            TableLayoutPanel cardPanel = new TableLayoutPanel();
            cardPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cardPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            cardPanel.Width = 400;
            cardPanel.Height = 300;
            cardPanel.Margin = new Padding(50, 20, 20, 20);
            cardPanel.BackColor = Color.Lavender;
            cardPanel.AutoScroll = true;
            Label enrolledCoursesLabel = new Label();
            enrolledCoursesLabel.Text = "Total Teaching Courses: " + numberOfCoursesEnrolled.ToString();
            enrolledCoursesLabel.Dock = DockStyle.Fill;
            enrolledCoursesLabel.TextAlign = ContentAlignment.MiddleCenter;
            enrolledCoursesLabel.Font = new Font("Segoe UI Semibold", 15F);
            enrolledCoursesLabel.Height = 35;
            cardPanel.Controls.Add(enrolledCoursesLabel, 0, 0);
            ListBox courseListBox = new ListBox();
            courseListBox.Dock = DockStyle.Fill;
            courseListBox.Font = new Font("Segoe UI", 12F);
            courseListBox.FormattingEnabled = true;
            courseListBox.Items.AddRange(enrolledCourseNames.ToArray());
            courseListBox.Visible = courseNamesVisible; 
            cardPanel.Controls.Add(courseListBox, 0, 1);

            Panel buttonPanel = new Panel();
            buttonPanel.Height = 50;
            buttonPanel.Width = 40;
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Margin = new Padding(130, 0, 100, 10);

            Button showHideButton = new Button();
            showHideButton.Text = "Show Course Names";
            showHideButton.Dock = DockStyle.Fill;
            showHideButton.Width = 70;
            showHideButton.TextAlign = ContentAlignment.MiddleCenter;
            showHideButton.Padding = new Padding(5, 15, 5, 15);
            showHideButton.Font = new Font("Segoe UI Semibold", 9F);
            showHideButton.BackColor = Color.DarkSlateBlue;
            showHideButton.ForeColor = Color.White;
            showHideButton.Click += (sender, e) =>
            {
                courseNamesVisible = !courseNamesVisible; 
                courseListBox.Visible = courseNamesVisible; 
                showHideButton.Text = courseNamesVisible ? "Hide Course Names" : "Show Course Names";
            };

            buttonPanel.Controls.Add(showHideButton);

            cardPanel.Controls.Add(buttonPanel, 0, 2);
            outerPanel.Controls.Add(cardPanel);
            TableLayoutPanel StudentPanel = new TableLayoutPanel();
            Panel Numberofstdpanel = new Panel();
            Numberofstdpanel.Width = 400;
            Numberofstdpanel.Height = 300;
            Numberofstdpanel.Margin = new Padding(50, 20, 20, 20);
            StudentPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StudentPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            StudentPanel.Width = 400;
            StudentPanel.Height = 300;
            StudentPanel.Margin = new Padding(50, 20, 20, 20);
            StudentPanel.BackColor = Color.Lavender;
            StudentPanel.AutoScroll = true;
            Label StudentNumberinCourses = new Label();
            StudentNumberinCourses.Text = "Student Number In Courses";
            StudentNumberinCourses.Dock = DockStyle.Fill;
            StudentNumberinCourses.TextAlign = ContentAlignment.MiddleCenter;
            StudentNumberinCourses.Font = new Font("Segoe UI Semibold", 15F);
            StudentNumberinCourses.Height = 35;
            StudentPanel.Controls.Add(StudentNumberinCourses, 0, 0);

            StudentPanel.ColumnCount = 2;
            StudentPanel.RowCount = enrolledCourseNames.Count + 1; // +1 for the header row
            StudentPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F)); 
            StudentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            StudentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

            StudentPanel.Controls.Add(StudentNumberinCourses, 0, 0);
            StudentPanel.SetColumnSpan(StudentNumberinCourses, 3);

            for (int i = 0; i < enrolledCourseNames.Count; i++)
            {
                Label courseNameLabel = new Label();
                courseNameLabel.Text = enrolledCourseNames[i];
                courseNameLabel.Dock = DockStyle.Fill;
                courseNameLabel.TextAlign = ContentAlignment.MiddleLeft;
                courseNameLabel.Font = new Font("Segoe UI", 12F);
                StudentPanel.Controls.Add(courseNameLabel, 0, i); 
                Label NumberOfStudent = new Label();
                NumberOfStudent.Text = attendancePercentages[i].ToString();
                NumberOfStudent.Dock = DockStyle.Fill;
                NumberOfStudent.TextAlign = ContentAlignment.MiddleCenter;
                NumberOfStudent.Font = new Font("Segoe UI", 12F);
                StudentPanel.Controls.Add(NumberOfStudent, 1, i); 
               
            }



            Numberofstdpanel.Controls.Add(StudentPanel);
            flowLayoutPanel2.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel2.Controls.Add(outerPanel);
            flowLayoutPanel2.Controls.Add(Numberofstdpanel);
        }

       
    }
}
