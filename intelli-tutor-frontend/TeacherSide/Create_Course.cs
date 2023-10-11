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
    public partial class Create_Course : Form
    {
        public Create_Course()
        {
            InitializeComponent();
            panel5.Visible = false;
        }

        private void formName_Click(object sender, EventArgs e)
        {

        }

        private void Create_Course_Load(object sender, EventArgs e)
        {
            SetPanelRegion(panel1);
            SetPanelRegion(panel3);
            SetPanelRegion(panel4);
            SetPanelRegion(panel5);
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

        private void Create_Course_Resize(object sender, EventArgs e)
        {
            SetPanelRegion(panel1);
            SetPanelRegion(panel3);
            SetPanelRegion(panel4);
            SetPanelRegion(panel5);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }
    }
}
