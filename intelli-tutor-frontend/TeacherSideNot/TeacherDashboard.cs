using FontAwesome.Sharp;
using intelli_tutor_frontend.StudentSide;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace intelli_tutor_frontend.TeacherSide
{
    public partial class TeacherDashboard : Form
    {
        public TeacherDashboard()
        {
            InitializeComponent();
            chart1.Series["s1"].Points.AddXY("Complete", "64");
            chart1.Series["s1"].Points.AddXY("InComplete", "36");
            chart1.Series["s1"].Points[0].Color = Color.DarkSlateBlue;
            chart1.Series["s1"].Points[1].Color = Color.LightCyan;
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.Legends.Clear();
            Title chartTitle = new Title("Course Completion");
            chartTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            chartTitle.Alignment = ContentAlignment.TopCenter;
            chart1.Titles.Add(chartTitle);
            chart1.ChartAreas[0].Position.X = 0; 
            chart1.ChartAreas[0].Position.Y = 100; 
            chart1.ChartAreas[0].Position.Width = 80; 
            chart1.ChartAreas[0].Position.Height = 80;
            chart2.ChartAreas[0].BackColor = Color.Transparent;
            chart2.Legends.Clear();
            chart2.Series["s2"].Points.AddXY("1", "355");
            chart2.Series["s2"].Points.AddXY("2", "400");
            chart2.Series["s2"].Points.AddXY("3", "50");
            chart2.Series["s2"].Points[0].Color = Color.DarkSlateBlue;
            chart2.Series["s2"].Points[1].Color = Color.DarkSlateBlue;
            chart2.Series["s2"].Points[2].Color = Color.DarkSlateBlue;
            chart3.Series["s3"].Points.AddXY("1", "355");
            chart3.Series["s3"].Points.AddXY("2", "100");
            chart3.Series["s3"].Points.AddXY("3", "600");
            chart3.Series["s3"].Points[0].Color = Color.DarkSlateBlue;
            chart3.Series["s3"].Points[1].Color = Color.DarkSlateBlue;
            chart3.Legends.Clear();
            chart3.ChartAreas[0].BackColor = Color.Transparent;
            loadIcons();
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            SetPanelRegion(panel1);
            SetPanelRegion(panel3);
            SetPanelRegion(panel4);
            SetPanelRegion(panel5);
            SetPanelRegion(panel6);
            SetPanelRegion(panel7);
            SetPanelRegion(panel8);
            SetPanelRegion(panel9);
            SetPanelRegion(panel10);
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        private void TeacherDashboard_Resize(object sender, EventArgs e)
        {
            SetPanelRegion(panel3);
            SetPanelRegion(panel1);
            SetPanelRegion(panel4);
            //bool switchToVertical = this.Width <= thresholdWidth;

            //// Update the layout of tableLayoutPanelMain
            //tableLayoutPanelMain.SuspendLayout();

            //if (switchToVertical)
            //{
            //    // Switch to vertical layout
            //    tableLayoutPanelMain.ColumnStyles[0].SizeType = SizeType.Percent;
            //    tableLayoutPanelMain.ColumnStyles[1].SizeType = SizeType.Percent;
            //    tableLayoutPanelMain.RowStyles[0].SizeType = SizeType.AutoSize;
            //}
            //else
            //{
            //    // Use horizontal layout
            //    tableLayoutPanelMain.ColumnStyles[0].SizeType = SizeType.AutoSize;
            //    tableLayoutPanelMain.ColumnStyles[1].SizeType = SizeType.AutoSize;
            //    tableLayoutPanelMain.RowStyles[0].SizeType = SizeType.Percent;

            //    // Disable scrolling
            //    this.AutoScroll = false;
            //}

            //tableLayoutPanelMain.ResumeLayout();

        }

        
        private void panel5_Click(object sender, EventArgs e)
        {
            panel5.BackColor= Color.White;
            panel6.BackColor = Color.FromArgb(192, 192, 255);
            panel7.BackColor = Color.FromArgb(192, 192, 255);
            panel8.BackColor = Color.FromArgb(192, 192, 255);
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel10.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel5.BackColor= Color.FromArgb(192, 192, 255); 
            panel6.BackColor= Color.White;
            panel7.BackColor = Color.FromArgb(192, 192, 255);
            panel8.BackColor = Color.FromArgb(192, 192, 255);
            panel9.BackColor = Color.FromArgb(192, 192, 255); 
            panel10.BackColor = Color.FromArgb(192, 192, 255); 
            Available_Courses available_CoursesForm= new Available_Courses();
            available_CoursesForm.Show();
            this.Hide();
                 }

        private void panel7_Click(object sender, EventArgs e)
        {
            panel5.BackColor= Color.FromArgb(192, 192, 255); 
            panel6.BackColor= Color.FromArgb(192, 192, 255); 
            panel7.BackColor= Color.White;
            panel8.BackColor = Color.FromArgb(192, 192, 255);   
            panel9.BackColor = Color.FromArgb(192, 192, 255); 
            panel10.BackColor = Color.FromArgb(192, 192, 255); 
            My_Courses MyCoursesForm = new My_Courses();
            MyCoursesForm.Show();
            this.Hide();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel8.BackColor= Color.White;
            panel9.BackColor= Color.FromArgb(192, 192, 255); 
            panel7.BackColor= Color.FromArgb(192, 192, 255); 
            panel5.BackColor= Color.FromArgb(192, 192, 255); 
            panel6.BackColor= Color.FromArgb(192, 192, 255); 
            panel10.BackColor= Color.FromArgb(192, 192, 255); 
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel9.BackColor= Color.White;
            panel5.BackColor = Color.FromArgb(192, 192, 255); 
            panel6.BackColor = Color.FromArgb(192, 192, 255);
            panel7.BackColor = Color.FromArgb(192, 192, 255); 
            panel8.BackColor = Color.FromArgb(192, 192, 255); 
            panel10.BackColor= Color.FromArgb(192, 192, 255); 
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel10.BackColor = Color.White;
            panel9.BackColor=Color.FromArgb(192, 192, 255); 
            panel5.BackColor=Color.FromArgb(192, 192, 255); 
            panel6.BackColor= Color.FromArgb(192, 192, 255);   
            panel7.BackColor= Color.FromArgb(192, 192, 255); 
            panel8.BackColor= Color.FromArgb(192, 192, 255); 
            CreateCourse CreateCourseForm = new CreateCourse();
            CreateCourseForm.Show();
            this.Hide();
        }

        public void loadIcons()
        {
            this.notificationIcon.Image = IconChar.Bell.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);
            this.accountIcon.Image = IconChar.Person.ToBitmap(color: Color.White, size: 40, rotation: 0, flip: FlipOrientation.Normal);


        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
