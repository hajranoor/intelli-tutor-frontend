﻿using intelli_tutor_frontend.Model;
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
            ProblemModel p = new ProblemModel();
            //Application.Run(new TeacherSide.TeacherSideDashbaord());
            Application.Run(new StudentSide.Dashboard());
        }
    }
}