using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace intelli_tutor_frontend.StudentSide
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            loadIcons();
            
        }
        public void loadIcons()
        {
            this.notificationIcon.Image = IconChar.Bell.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);
            this.accountIcon.Image = IconChar.Person.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);

           
        }
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashboardToolStripMenuItem.Enabled = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void availableCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            availableCourses availableCourses = new availableCourses();
            availableCourses.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void myCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            myCourses myCourses = new myCourses();
            myCourses.Show();
        }
    }
}
