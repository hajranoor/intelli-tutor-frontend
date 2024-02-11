using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using intelli_tutor_frontend.StudentSide;
using intelli_tutor_frontend.TeacherSide;
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
    public partial class Loginform : Form

    {

        UserApi uApi = new UserApi();
        public Loginform()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor= Color.White;
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            pictureBox2.BackColor= SystemColors.Control;
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private async void SignIn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            UserModel u = new UserModel();
            u.username = username;
            u.pass_word = password;

           // string result = await uApi.AuthenticateUser(u);

            UserModel user = await uApi.checkUserExists(u);
            Console.WriteLine("result");
            Console.WriteLine(user.email);

            if (user != null)
            {
                if(user.user_role == "Teacher")
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                if(user.user_role == "Student")
                {
                    this.Hide();
                    TeacherSideDashbaord teacherSideDashbaord = new TeacherSideDashbaord();
                    teacherSideDashbaord.Show();
                }
            }

            else
            {
                MessageBox.Show("incorrect credentials");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registerform registerform = new Registerform();
            registerform.Show();
        }
    }
}