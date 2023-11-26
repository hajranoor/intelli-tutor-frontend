using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class userModel
    {
        public int userid { get; set; } // Assuming you have an ID column as well, adjust the data type accordingly
        public string username { get; set; }
        public string email { get; set; }
        public string pass_word { get; set; }
        public string google_verification { get; set; }
        public string user_role { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }
        public bool active { get; set; }

    }
}
