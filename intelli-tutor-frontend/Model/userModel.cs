using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class userModel
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string pass_word { get; set; }
        public bool google_verification { get; set; }
        public string user_role { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }
        public bool active { get; set; }

    }
}
