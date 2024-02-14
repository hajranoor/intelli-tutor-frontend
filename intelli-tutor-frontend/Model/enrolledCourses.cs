using System;

namespace intelli_tutor_frontend.Model

{
    public class EnrolledCourses
    {
        public int enrollment_id { get; set; }
        public int student_id { get; set; }
        public int course_offering_id { get; set; }
        public string grade { get; set; }

        public string status { get; set; }

        public DateTime enrolled_at { get; set; }
    }
}
