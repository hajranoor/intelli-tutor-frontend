using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.BackendApi
{
    internal class WeekApi
    {
        public async Task<List<weekModel>> getAllWeekData(int courseId)
        {
            List<weekModel> list = new List<weekModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/Week/"+ courseId +  "?courseId=" + courseId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<weekModel>>(apiResponse);
                }
            }
            return list;
        }
    }
}
