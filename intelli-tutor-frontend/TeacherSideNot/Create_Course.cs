using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
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
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;

namespace intelli_tutor_frontend.TeacherSide
{
    public partial class Create_Course : Form
    {
        CourseApi courseApi = new CourseApi();
       
        public Create_Course()
        {
            InitializeComponent();
            panel5.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;    
            pictureBox3.Visible = false;

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
            SetPanelRegion(panel9);
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
            SetPanelRegion(panel9);
            SetPanelRegion(panel10);
            SetPanelRegion(panel11);
            SetPanelRegion(panel12);
            SetPanelRegion(panel13);
            SetPanelRegion(panel14);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            pictureBox1.Visible= true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            pictureBox2.Visible= true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            pictureBox3.Visible= true;
            pictureBox2.Visible = false;
            pictureBox2.Visible = false;
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            panel14.BackColor = Color.White;
            panel9.BackColor = Color.MediumPurple;
            panel10.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.MediumPurple;
            panel12.BackColor = Color.MediumPurple;
            panel13.BackColor = Color.MediumPurple;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel10.BackColor = Color.White;
            panel11.BackColor = Color.MediumPurple;
            panel12.BackColor = Color.MediumPurple;
            panel13.BackColor = Color.MediumPurple;
            panel14.BackColor = Color.MediumPurple;
            panel9.BackColor= Color.MediumPurple;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            panel13.BackColor = Color.White;
            panel14.BackColor = Color.MediumPurple;
            panel10.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.MediumPurple;
            panel12.BackColor = Color.MediumPurple;
            panel9.BackColor = Color.MediumPurple;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel12.BackColor = Color.White;
            panel13.BackColor = Color.MediumPurple;
            panel14.BackColor = Color.MediumPurple;
            panel10.BackColor = Color.MediumPurple;
            panel11.BackColor = Color.MediumPurple;
            panel9.BackColor = Color.MediumPurple;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panel11.BackColor = Color.White;
            panel12.BackColor = Color.MediumPurple;
            panel13.BackColor = Color.MediumPurple;
            panel14.BackColor = Color.MediumPurple;
            panel10.BackColor = Color.MediumPurple;
            panel9.BackColor = Color.MediumPurple;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            coursesModel cm = new coursesModel();
             cm.course_title = textBox1.Text;
             cm.description = textBox2.Text;
            cm.course_session = int.Parse(comboBox1.SelectedItem as string);
             cm.credit_hour = int.Parse(comboBox2.SelectedItem as string);
             cm.weekcount = int.Parse(textBox3.Text);

            try
            {
                var apiResponse = courseApi.InsertCourseData(cm);
                Console.WriteLine(apiResponse.ToString());
               
                  
                    YourDialogBoxMethod("Course inserted successfully!");
               
            }
            catch (Exception ex)
            {
              
                YourDialogBoxMethod($"An error occurred: {ex.Message}");
            }


        
        }

        private void YourDialogBoxMethod(string message)
        {
          
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
