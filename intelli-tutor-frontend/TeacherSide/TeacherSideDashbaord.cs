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
        NewMenuStrip newMenuStrip = new NewMenuStrip();
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
            dashboardToolStripMenuItem.Enabled = true;
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

        private void courseOfferingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void courseContenttoolStripMenuItem2_Click(object sender, EventArgs e)
        {

            flowLayoutPanel2.Controls.Clear();
            formName.Text = "Course Content";
            TeacherCourseContent courseContent = new TeacherCourseContent();
            courseContent.CourseContentShow(1, flowLayoutPanel2);
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
    }
}
