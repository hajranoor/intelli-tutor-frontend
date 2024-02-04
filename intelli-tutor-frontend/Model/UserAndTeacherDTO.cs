using System;

namespace MVCproject.DTO
{
    public class UserAndTeacherDTO
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public int teacher_id { get; set; }
        public string qualification { get; set; }
        public string designation { get; set; }
    }
}
