using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class StudentModel
    {
        public int student_id { get; set; }
        public int user_id { get; set; }
        public string registration_no { get; set; }
        public int session_student { get; set; }
        public string section_student { get; set; }
        public int university_id { get; set; }
    }
}
