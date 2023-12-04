using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class ContentModel
    {
        public int content_id { get; set; }
        public int week_id { get; set; }
        public string content_type { get; set; }
        public string content_name { get; set; }
        public int sequence_number { get; set; }
    }
}
