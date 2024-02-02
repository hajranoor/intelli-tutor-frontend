using FontAwesome.Sharp;
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

namespace intelli_tutor_frontend.TeacherSide
{
    public partial class TeacherSideDashbaord : Form
    {
        public TeacherSideDashbaord()
        {
            InitializeComponent();
            loadIcons();

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

        private void myCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            formName.Text = "Create Course Offering";
            TeacherCourseOffering courseOffering = new TeacherCourseOffering();
            MainCoursesModel c = new MainCoursesModel();
            courseOffering.CourseOfferingShow(c, flowLayoutPanel2, formName);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            formName.Text = "Course Content";
            TeacherCourseContent courseContent = new TeacherCourseContent();
            courseContent.CourseContentShow(1,flowLayoutPanel2);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void availableCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            teacherAvailableCourses teacherAvailableCourses = new teacherAvailableCourses();
            teacherAvailableCourses.availableCoursesAsync(flowLayoutPanel2, formName);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            TeacherMyCourses teacherMyCourses = new TeacherMyCourses();
            teacherMyCourses.ShowMyCoursesAsync(flowLayoutPanel2, formName);
        }
    }
}
