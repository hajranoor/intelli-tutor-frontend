using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend
{
    public partial class Register : Form
    {
        UserApi userApi = new UserApi();

        List<userModel> userList;

        public Register()
        {
            InitializeComponent();
            Teacher_Role.Visible = false;
            StudentInfo.Visible = false;
            registerBtn.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItem = roleComboBox.SelectedItem.ToString();
            Teacher_Role.Visible = false;
            StudentInfo.Visible = false;
            if (selectedItem == "Teacher")
            {
                Teacher_Role.Visible = true;
                registerBtn.Visible=true;
            }
            else if (selectedItem == "Student")
            {
                StudentInfo.Visible = true;
                registerBtn.Visible=true;
            }
        }

        private void StudentInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConPassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Registerbtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(cPassword.Text) || string.IsNullOrEmpty(roleComboBox.Text))
            {
               if(roleComboBox.Text == "Teacher")
               {
                    if(!string.IsNullOrEmpty(designationComboBox.Text) && !string.IsNullOrEmpty(qualification.Text))
                    {
                        if (CheckValidations())
                        {
                            userList = await userApi.checkUserEmailExists(email.Text);
                            if(userList.Count == 0)
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill all the fields");
                    }

               }
               if(roleComboBox.Text == "Student")
               {
                    if(!string.IsNullOrEmpty(semester.Text) && !string.IsNullOrEmpty(session.Text))
                    {
                        if (CheckValidations())
                        {
                            userList = await userApi.checkUserEmailExists(email.Text);
                            if (userList.Count == 0)
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill all the fields");
                    }

               }
            }
            else
            {
                MessageBox.Show("Fill all the fileds");
            }
        }

        private bool CheckValidations()
        {
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Invalid email format!", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                //MessageBox.Show("Email is valid!", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(password.Text != cPassword.Text)
            {
                MessageBox.Show("Password does not match", "Match Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool IsValidEmail(string email)
        {
            // Define a simple regular expression for email validation
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        

        private void Register_Resize(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BasicInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
