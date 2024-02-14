using intelli_tutor_frontend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend
{
    internal class CurrentUser
    {
        private static CurrentUser instance;
        private CurrentUser()
        {
        }

        public static CurrentUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CurrentUser();
                }
                return instance;
            }
        }

        public UserModel User { get; set; }
        public TeacherModel TeacherModel { get; set; }
        public StudentModel StudentModel { get; set; }
    }

}
