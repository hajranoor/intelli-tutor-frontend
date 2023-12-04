using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    public class MainCourse
    {

        public int course_id { get; set; }
        public string course_code { get; set; }
        public string course_name { get; set; }
        public string course_description { get; set; }
        public int credit_hour { get; set; }
        public int contact_hour { get; set; }
        public string course_type { get; set; }
        public int number_of_weeks { get; set; }
       
        public byte[] icon { get; set; }
    }
}
