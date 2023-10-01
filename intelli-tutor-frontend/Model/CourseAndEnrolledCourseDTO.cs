﻿namespace intelli_tutor_frontend.Model
{
    public class CourseAndEnrolledCourseDTO
    {
        public int course_id { get; set; }
        public string course_title { get; set; }
        public string description { get; set; }
        public int credit_hour { get; set; }
        public int course_session { get; set; }
        public int studentId { get; set; }
        public string grade { get; set; }
        public int enrollmentId { get; set; }

    }
}