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
            CourseOffering courseOffering = new CourseOffering();
            coursesModel c = new coursesModel();
            courseOffering.CourseOfferingShow(c, flowLayoutPanel2);
        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void availableCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            formName.Text = "Available Courses";
            teacherAvailableCourses ta = new teacherAvailableCourses();
            MainCourse c = new MainCourse();
            _ = ta.availableCoursesAsync(c, flowLayoutPanel2);
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            CourseContent cdinstance  = new CourseContent();
            //CourseAndEnrolledCourseDTO course = new CourseAndEnrolledCourseDTO();
            cdinstance.CourseContentSjow(flowLayoutPanel2);
        }
    }
}
