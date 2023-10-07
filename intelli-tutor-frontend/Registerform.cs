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
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
            Teacher_Role.Visible = false;
            StudentInfo.Visible = false;
        }

        private void Registerform_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            Teacher_Role.Visible = false;
            StudentInfo.Visible = false;
            if (selectedItem == "Teacher")
            {
                Teacher_Role.Visible = true;
            }
            else if (selectedItem == "Student")
            {
                StudentInfo.Visible = true;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
