using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class ViewEnrollmentsDTO
    {

        public int course_id { get; set; }
        public string course_code { get; set; }

        public int course_offering_id { get; set; }

        public int teacher_id { get; set; }
        public int enrollment_id { get; set; }

        public int student_id { get; set; }

        public int user_id { get; set; }

        public string registration_no { get; set; }

        public string section_student { get; set; }
        public string username { get; set; }
    }
}
