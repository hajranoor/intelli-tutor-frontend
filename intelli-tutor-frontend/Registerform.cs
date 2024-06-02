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
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend
{
    
    public partial class Registerform : Form
    {
        UserApi userApi = new UserApi();
        TeacherApi teacherApi = new TeacherApi();
        StudentApi studentApi = new StudentApi();
        UniversityApi universityApi = new UniversityApi();
        List<UserModel> userList;

        CurrentUser currentUser = CurrentUser.Instance;
        public Registerform()
        {
            InitializeComponent();
            Teacher_Role.Visible = false;
            StudentInfo.Visible = false;
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = roleComboBox.SelectedItem.ToString();
            Teacher_Role.Visible = false;
            StudentInfo.Visible = false;
            if (selectedItem == "Teacher")
            {
                Teacher_Role.Visible = true;
            }
            else if (selectedItem == "Student")
            {
                StudentInfo.Visible = true;
                List<string> data = await universityApi.getAllUniversity();
                universityComboBox.DataSource = data;
                
            }
        }

        private bool CheckValidations()
        {
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Invalid email format!", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password.Text != cPassword.Text)
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

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(cPassword.Text) || string.IsNullOrEmpty(roleComboBox.Text))
            {
                if (roleComboBox.Text == "Teacher")
                {
                    if (!string.IsNullOrEmpty(designationComboBox.Text) && !string.IsNullOrEmpty(qualification.Text))
                    {
                        if (CheckValidations())
                        {
                            userList = await userApi.checkUserEmailExists(email.Text);
                            if (userList.Count == 0)
                            {
                                UserModel u = new UserModel();
                                u.email = email.Text;
                                u.username = username.Text;
                                u.pass_word = password.Text;
                                u.active = true;
                                u.google_verification = true;
                                u.user_role = roleComboBox.Text;
                                int newUserId = await userApi.insertUser(u);
                                if ( newUserId != -1)
                                {   
                                    TeacherModel t = new TeacherModel();
                                    t.user_id = newUserId;
                                    t.qualification = qualification.Text;
                                    t.designation = designationComboBox.Text;
                                    MessageBox.Show(await teacherApi.insertTeacherData(t));
                                    this.Hide();
                                    Loginform loginform = new Loginform();
                                    loginform.Show();
                                    //currentUser.User = u;
                                    //currentUser.TeacherModel = t;
                                    //TeacherSideDashbaord teacherSideDashbaord = new TeacherSideDashbaord();
                                    //teacherSideDashbaord.Show();
                                }
                                else
                                {
                                    await userApi.DeleteUserById(newUserId);
                                    MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (roleComboBox.Text == "Student")
                {
                    if (!string.IsNullOrEmpty(sectionComboBox.Text) && !string.IsNullOrEmpty(sessionComboBox.Text) && !string.IsNullOrEmpty(regNo.Text))
                    {
                        if (CheckValidations())
                        {
                            userList = await userApi.checkUserEmailExists(email.Text);
                            if (userList.Count == 0)
                            {
                                UserModel u = new UserModel();
                                u.email = email.Text;
                                u.username = username.Text;
                                u.pass_word = password.Text;
                                u.active = true;
                                u.google_verification = true;
                                u.user_role = roleComboBox.Text;
                                int newUserId = await userApi.insertUser(u);
                                if (newUserId != -1)
                                {
                                    StudentModel s = new StudentModel();
                                    s.user_id = newUserId;
                                    s.session_student = int.Parse(sessionComboBox.Text);
                                    s.section_student = sectionComboBox.Text;
                                    s.registration_no = regNo.Text;
                                    s.university_id = await universityApi.getUniversityId(universityComboBox.Text);


                                    
                                    MessageBox.Show(await studentApi.insertStudentData(s));
                                    this.Hide();
                                    Loginform loginform = new Loginform();
                                    loginform.Show();
                                    //currentUser.User = u;
                                    //currentUser.StudentModel = s;
                                    //Dashboard dashboard = new Dashboard();
                                    //dashboard.Show();
                                }
                                else
                                {
                                    await userApi.DeleteUserById(newUserId);
                                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Fill all the fileds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registerform_Load(object sender, EventArgs e)
        {

        }

        private void accountExists_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform loginform = new Loginform();
            loginform.Show();
        }
    }
}
