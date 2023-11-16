using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    public partial class My_Courses : Form
    {
        public My_Courses()
        {
            InitializeComponent();
        }

        private void My_Courses_Load(object sender, EventArgs e)
        {
            SetPanelRegion(panel1);
            SetPanelRegion(panel3);
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

        private void My_Courses_Resize(object sender, EventArgs e)
        {
            SetPanelRegion(panel1);
            SetPanelRegion(panel3);
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            panel14.BackColor = Color.White;
            panel9.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.MediumPurple;
            panel13.BackColor = Color.MediumPurple;
            panel12.BackColor = Color.MediumPurple;
            panel10.BackColor = Color.MediumPurple;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel10.BackColor = Color.White;
            panel9.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.MediumPurple;
            panel13.BackColor = Color.MediumPurple;
            panel14.BackColor = Color.MediumPurple;
            panel12.BackColor = Color.MediumPurple;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            panel13.BackColor = Color.White;
            panel14.BackColor = Color.MediumPurple;
            panel9.BackColor = Color.MediumPurple;
            panel10.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.MediumPurple;
            panel12.BackColor = Color.MediumPurple;

        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.MediumPurple;
            panel10.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.MediumPurple;
            panel12.BackColor = Color.White;
            panel13.BackColor = Color.MediumPurple;
            panel14.BackColor = Color.MediumPurple;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.MediumPurple;
            panel10.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.White;
            panel12.BackColor = Color.MediumPurple;
            panel13.BackColor = Color.MediumPurple;
            panel14.BackColor = Color.MediumPurple;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.White;
            panel10.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.MediumPurple;
            panel12.BackColor = Color.MediumPurple;
            panel13.BackColor = Color.MediumPurple;
            panel14.BackColor = Color.MediumPurple;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
