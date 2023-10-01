using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    public class problemModel
    {
        public int problem_id { get; set; }
        public string problem_name { get; set; }
        public string description { get; set; }
        public string complexity_level { get; set; }
        public int labid { get; set; }
        public string rightcode { get; set; }
        public string startercode { get; set; }

        public string category { get; set; }
        public int teastcasescount { get; set; }
    }
}
