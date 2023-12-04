using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class courseOfferingModel
    {
        public int course_offering_id { get; set; }
        public int course_id { get; set; }

        public int offering_year { get; set; }
        public string semester { get; set; }
        public int capacity { get; set; }
        public string description { get; set; }
        public int teacher_id { get; set; }
    }
}
