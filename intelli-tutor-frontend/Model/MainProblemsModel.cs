using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class MainProblemsModel
    {
        public int problem_id { get; set; }
        public int content_id { get; set; }
        public string problem_name { get; set; }
        public string description { get; set; }
        public string regex { get; set; }
        public string starter_code { get; set; }
        public string right_code { get; set; }
        public string category { get; set; }
        public string complexity_level { get; set; }
    }
}
