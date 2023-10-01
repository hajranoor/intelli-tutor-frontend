using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace intelli_tutor_frontend
{
    public partial class Form1 : Form
    {
        private Rectangle buttonOriginalRectangle; 
        private Rectangle originalFormSize;
        private Rectangle panel1OriginalRecatngle;
        private Rectangle panel2OriginalRecatngle;
        private Rectangle panel3OriginalRecatngle;
        private Rectangle textBox1OriginalRectangle;
        private Rectangle textBox2OriginalRectangle;
        private Rectangle LeftPanalOriginalRectangle;
        private Rectangle BasicpanalOriginalRectangle;
        private Rectangle pictureBox3OriginalRectangle;
        private Rectangle label1OriginalRectangle;
        private Rectangle label2OriginalRectangle;
        private Rectangle label5OriginalRectangle;
        private Rectangle label6OriginalRectangle;
        private Rectangle label3OriginalRectangle;
        private Rectangle label4OriginalRectangle;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(SignIn.Location.X, SignIn.Location.Y, SignIn.Width, SignIn.Height);
            panel1OriginalRecatngle = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            panel2OriginalRecatngle = new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Width, panel2.Height);
            panel3OriginalRecatngle = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
            textBox1OriginalRectangle = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            textBox2OriginalRectangle = new Rectangle(textBox2.Location.X, textBox2.Location.Y, textBox2.Width, textBox2.Height);
            LeftPanalOriginalRectangle = new Rectangle(LeftPanal.Location.X, LeftPanal.Location.Y, LeftPanal.Width, LeftPanal.Height);
            BasicpanalOriginalRectangle = new Rectangle(Basicpanal.Location.X, Basicpanal.Location.Y, Basicpanal.Width, Basicpanal.Height);
            pictureBox3OriginalRectangle = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Width, pictureBox3.Height);
            label5OriginalRectangle = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);
            label6OriginalRectangle = new Rectangle(label6.Location.X, label6.Location.Y, label6.Width, label6.Height);
            label3OriginalRectangle = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label4OriginalRectangle = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            label1OriginalRectangle = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            label2OriginalRectangle = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;      
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            textBox1.BackColor = Color.White;
            panel3.BackColor= Color.White;
            panel2.BackColor = SystemColors.Control;
            textBox2.BackColor=SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel2.BackColor= Color.White;
            textBox1.BackColor= SystemColors.Control;
            panel3.BackColor= SystemColors.Control;
        }

        private void Basicpanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {

            Register mainForm2 = new Register();
            this.Hide();
            mainForm2.ShowDialog();
            this.Close();
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonOriginalRectangle, SignIn);
            resizeControl(panel1OriginalRecatngle, panel1);
            resizeControl(panel2OriginalRecatngle, panel2);
            resizeControl(panel3OriginalRecatngle, panel3);
            resizeControl(textBox2OriginalRectangle, textBox2);
            resizeControl(textBox1OriginalRectangle, textBox1);
            resizeControl(LeftPanalOriginalRectangle, LeftPanal);
            resizeControl(BasicpanalOriginalRectangle, Basicpanal);
            resizeControl(pictureBox3OriginalRectangle, pictureBox3);
            resizeControl(label5OriginalRectangle, label5);
            resizeControl(label3OriginalRectangle, label3);
            resizeControl(label4OriginalRectangle, label4);
            resizeControl(label1OriginalRectangle, label1);
            resizeControl(label6OriginalRectangle, label6);
            resizeControl(label2OriginalRectangle, label2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
