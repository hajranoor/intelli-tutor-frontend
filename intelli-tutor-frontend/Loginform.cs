using intelli_tutor_frontend.BackendApi;
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

            string result = await uApi.checkUserExists(u);
            Console.WriteLine("result");
            Console.WriteLine(result);

            if (result == "true")
            {
                MessageBox.Show("Hello,sign in !");
            }

            else if ( result == "false")
            {
                MessageBox.Show("incorrect credentials");
            }

            else
            {
                MessageBox.Show("jkndkffkff");
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}