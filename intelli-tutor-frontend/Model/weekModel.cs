

using intelli_tutor_frontend.BackendApi;
using intelli_tutor_frontend.Model;
using System.Drawing;
using System.Windows.Forms;

namespace intelli_tutor_frontend.Model
{
    internal class weekModel
    {
        public int week_id { get; set; }
        public int course_id { get; set; }
        public string description { get; set; }
        public int labCount { get; set; }
    }
}


