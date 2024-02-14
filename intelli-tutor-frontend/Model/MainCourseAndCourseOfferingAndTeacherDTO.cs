namespace intelli_tutor_frontend.Model
{
    public class MainCourseAndCourseOfferingAndTeacherDTO
    {
        public int course_id { get; set; }
        public string course_code { get; set; }
        public string course_name { get; set; }
        public int credit_hour { get; set; }
        public int contact_hour { get; set; }
        public string course_type { get; set; }
        public int number_of_weeks { get; set; }
        public byte[] icon { get; set; }
        public int course_offering_id { get; set; }
        public int teacher_id { get; set; }
        public int offering_year { get; set; }
        public string semester { get; set; }
        public int capacity { get; set; }
        public string description { get; set; }
        public string username { get; set; }
        public string email { get; set; }
    }
}
