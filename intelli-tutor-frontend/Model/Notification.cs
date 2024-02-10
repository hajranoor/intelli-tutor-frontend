using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.Model
{
    internal class Notification
    {
        public int notification_id { get; set; }
        public int receiver_id { get; set; }
        public int sender_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public DateTime time_stamp { get; set; }
    }
}
