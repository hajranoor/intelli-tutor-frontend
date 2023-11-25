using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class TeacherModel
    {
        public int teacher_id { get; set; }
        public int user_id { get; set; }
        public string qualification { get; set; }
        public string designation { get; set; }
    }
}
