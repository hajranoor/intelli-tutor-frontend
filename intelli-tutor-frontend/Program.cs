using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QuestionForm());
            problemModel p = new problemModel();
            //Application.Run(new QuestionForm(p));
            //Application.Run(new StudentSide.Dashboard());
            //Application.Run(new Loginform());
            Application.Run(new TeacherSide.TeacherDashboard());
            //Application.Run(new TeacherSide.CreateCourse());
            //Application.Run(new TeacherSide.My_Courses());
            //Application.Run(new TeacherSide.Available_Courses());
            //Application.Run(new QuestionForm(p));
            //Application.Run(new StudentSide.Dashboard());
            //Application.Run(new Loginform());
        }
    }
}