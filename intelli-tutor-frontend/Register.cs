using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend
{
    public partial class Register : Form
    {
        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;
        private Rectangle panel2OriginalRecatngle;
        private Rectangle StudentInfoOriginalRecatngle;
        private Rectangle BasicInforiginalRecatngle;
        private Rectangle pictureBox1OriginalRectangle;
        private Rectangle Teacher_RoleOriginalRecatngle;
        private Rectangle textBox1OriginalRectangle;
        private Rectangle textBox2OriginalRectangle;
        private Rectangle textBox3OriginalRectangle;
        private Rectangle textBox7OriginalRectangle;
        private Rectangle textBox6OriginalRectangle;
        private Rectangle ConPassTBOriginalRectangle;
        private Rectangle comboBox1OriginalRectangle;
        private Rectangle comboBox2OriginalRectangle;
        private Rectangle label5OriginalRectangle;
        public Register()
        {
            InitializeComponent();
            Teacher_Role.Visible = false;
            StudentInfo.Visible = false;
            Registerbtn.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            Teacher_Role.Visible = false;
            StudentInfo.Visible = false;
            if (selectedItem == "Teacher")
            {
                Teacher_Role.Visible = true;
                Registerbtn.Visible=true;
            }
            else if (selectedItem == "Student")
            {
                StudentInfo.Visible = true;
                Registerbtn.Visible=true;
            }
        }

        private void StudentInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConPassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
           
                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                buttonOriginalRectangle = new Rectangle(Registerbtn.Location.X, Registerbtn.Location.Y, Registerbtn.Width, Registerbtn.Height);
                BasicInforiginalRecatngle = new Rectangle(BasicInfo.Location.X, BasicInfo.Location.Y, BasicInfo.Width, BasicInfo.Height);
                panel2OriginalRecatngle = new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Width, panel2.Height);
                Teacher_RoleOriginalRecatngle = new Rectangle(Teacher_Role.Location.X, Teacher_Role.Location.Y, Teacher_Role.Width, Teacher_Role.Height);
                StudentInfoOriginalRecatngle = new Rectangle(StudentInfo.Location.X, StudentInfo.Location.Y, StudentInfo.Width, StudentInfo.Height);
                textBox1OriginalRectangle = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
                textBox2OriginalRectangle = new Rectangle(textBox2.Location.X, textBox2.Location.Y, textBox2.Width, textBox2.Height);
                textBox3OriginalRectangle = new Rectangle(textBox3.Location.X, textBox3.Location.Y, textBox3.Width, textBox3.Height);
                textBox6OriginalRectangle = new Rectangle(textBox6.Location.X, textBox6.Location.Y, textBox6.Width, textBox6.Height);
                textBox7OriginalRectangle = new Rectangle(textBox7.Location.X, textBox7.Location.Y, textBox7.Width, textBox7.Height);
                ConPassTBOriginalRectangle = new Rectangle(ConPassTB.Location.X, ConPassTB.Location.Y, ConPassTB.Width, ConPassTB.Height);
                comboBox1OriginalRectangle = new Rectangle(comboBox1.Location.X, comboBox1.Location.Y, comboBox1.Width, comboBox1.Height);
                comboBox2OriginalRectangle = new Rectangle(comboBox2.Location.X, comboBox2.Location.Y, comboBox2.Width, comboBox2.Height);
                pictureBox1OriginalRectangle = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
                label5OriginalRectangle = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Register_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonOriginalRectangle, Registerbtn);
            resizeControl(panel2OriginalRecatngle, panel2);
            resizeControl(BasicInforiginalRecatngle, BasicInfo);
            resizeControl(pictureBox1OriginalRectangle, pictureBox1);
            resizeControl(StudentInfoOriginalRecatngle, StudentInfo);
            resizeControl(Teacher_RoleOriginalRecatngle, Teacher_Role);
            resizeControl(textBox2OriginalRectangle, textBox2);
            resizeControl(textBox1OriginalRectangle, textBox1);
            resizeControl(textBox6OriginalRectangle, textBox6);
            resizeControl(textBox7OriginalRectangle, textBox7);
            resizeControl(ConPassTBOriginalRectangle, ConPassTB);
            resizeControl(textBox3OriginalRectangle, textBox3);
            resizeControl(comboBox1OriginalRectangle, comboBox1);
            resizeControl(comboBox2OriginalRectangle, comboBox2);
            resizeControl(label5OriginalRectangle, label5);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BasicInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
